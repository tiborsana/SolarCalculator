using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photovoltaics {
    public partial class CalculationForm : Form {
        Installation instalace;
        public CalculationForm(Installation instalace) {
            InitializeComponent();
            this.instalace = instalace;
            txb_installedPowerCalc.Text = instalace.TotalInstalledPower.ToString("0.##");
            txt_YearProductionLocalityCalc.Text = CityTotalProduction(instalace).ToString("0.##");
            txt_YearProductionCalc.Text = TotalProduction(instalace).ToString("0.##");
            lab_return100val.Text = nper(instalace, 1).ToString("0.##") + " let";
            lab_return75val.Text = nper(instalace, 0.75).ToString("0.##") + " let";
            lab_return50val.Text = nper(instalace, 0.50).ToString("0.##") + " let";
            lab_yearProductionLocalityCalc.Text += " (" + instalace.City + "): ";

        }

        private static double CityTotalProduction(Installation instalace) {
            return (instalace.TotalInstalledPower * instalace.CityProduction);
        }

        private static double TotalProduction(Installation instalace) {
            double cityProduction= CityTotalProduction(instalace);
            double koef = 1;
            if (instalace.RoofOrientation == "Západní") {
                if (instalace.RoofSlope > 0 && instalace.RoofSlope < 25) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 26 && instalace.RoofSlope < 40) {
                    koef = 0.80;
                }
                else if (instalace.RoofSlope > 41 && instalace.RoofSlope < 50) {
                    koef = 0.75;
                }
                else if (instalace.RoofSlope > 51 && instalace.RoofSlope < 60) {
                    koef = 0.70;
                }
                else if (instalace.RoofSlope > 61 && instalace.RoofSlope < 75) {
                    koef = 0.60;
                }
            }
            if (instalace.RoofOrientation == "Jihozápadní") {
                if (instalace.RoofSlope >= 0 && instalace.RoofSlope < 5) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 6 && instalace.RoofSlope < 10) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 11 && instalace.RoofSlope < 45) {
                    koef = 0.95;
                }
                else if (instalace.RoofSlope > 46 && instalace.RoofSlope < 55) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 56 && instalace.RoofSlope <= 75) {
                    koef = 0.80;
                }
            }
            if (instalace.RoofOrientation == "Jižní") {
                if (instalace.RoofSlope >= 0 && instalace.RoofSlope < 5) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 6 && instalace.RoofSlope < 10) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 11 && instalace.RoofSlope < 15) {
                    koef = 0.95;
                }
                else if (instalace.RoofSlope > 16 && instalace.RoofSlope < 45) {
                    koef = 1.00;
                }
                else if (instalace.RoofSlope > 46 && instalace.RoofSlope < 55) {
                    koef = 0.95;
                }
                else if (instalace.RoofSlope > 56 && instalace.RoofSlope < 65) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 66 && instalace.RoofSlope <= 75) {
                    koef = 0.80;
                }
            }
            if (instalace.RoofOrientation == "Jihovýchodní") {
                if (instalace.RoofSlope >= 0 && instalace.RoofSlope < 5) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 6 && instalace.RoofSlope < 10) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 11 && instalace.RoofSlope < 45) {
                    koef = 0.95;
                }
                else if (instalace.RoofSlope > 46 && instalace.RoofSlope < 50) {
                    koef = 0.90;
                }
                else if (instalace.RoofSlope > 51 && instalace.RoofSlope < 60) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 61 && instalace.RoofSlope <= 75) {
                    koef = 0.80;
                }
            }
            if (instalace.RoofOrientation == "Východní") {
                if (instalace.RoofSlope > 0 && instalace.RoofSlope < 25) {
                    koef = 0.85;
                }
                else if (instalace.RoofSlope > 26 && instalace.RoofSlope < 40) {
                    koef = 0.80;
                }
                else if (instalace.RoofSlope > 41 && instalace.RoofSlope < 50) {
                    koef = 0.75;
                }
                else if (instalace.RoofSlope > 51 && instalace.RoofSlope < 60) {
                    koef = 0.70;
                }
                else if (instalace.RoofSlope > 61 && instalace.RoofSlope < 75) {
                    koef = 0.60;
                }
            }
            return cityProduction*koef;
        }

        private static double nper(Installation instalace, double koef) {

            double sazba = instalace.ElectricityExpectedGrowth;
            double futureValue = instalace.InstallationPriceCosts;
            double payments = instalace.ElectricityPrice * (TotalProduction(instalace) * koef);
            sazba = sazba / (12 * 100);
            double nper;
            nper=Math.Log((futureValue * sazba + payments) / (payments + sazba)) / Math.Log(1 + sazba);
            return nper;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photovoltaics {
     public class Installation {
        int installationPriceTotal;
        int installationPriceGrant;
        int installationPriceCosts;
        double totalInstalledPower;
        string city;
        double cityProduction;
        int roofSlope;
        string roofOrientation;
        double electricityPrice;
        double electricityExpectedGrowth;

        //properties

        public int InstallationPriceTotal { get => installationPriceTotal; set => installationPriceTotal = value; }
        public int InstallationPriceGrant { get => installationPriceGrant; set => installationPriceGrant = value; }
        public int InstallationPriceCosts { get => installationPriceCosts; set => installationPriceCosts = value; }
        public double TotalInstalledPower { get => totalInstalledPower; set => totalInstalledPower = value; }
        public string City { get => city; set => city = value; }
        public int RoofSlope { get => roofSlope; set => roofSlope = value; }
        public string RoofOrientation { get => roofOrientation; set => roofOrientation = value; }
        public double ElectricityPrice { get => electricityPrice; set => electricityPrice = value; }
        public double ElectricityExpectedGrowth { get => electricityExpectedGrowth; set => electricityExpectedGrowth = value; }
        public double CityProduction { get => cityProduction; set => cityProduction = value; }

        //konstruktor

        public Installation(int InstallationPriceTotal, int InstallationPriceGrant, int InstallationPriceCosts, double TotalInstalledPower, string City, int RoofSlope, string RoofOrientation, double ElectricityPrice, double ElectricityExpectedGrowth, double cityProduction) {
            this.InstallationPriceTotal = InstallationPriceTotal;
            this.InstallationPriceGrant = InstallationPriceGrant;
            this.InstallationPriceCosts = InstallationPriceCosts;
            this.TotalInstalledPower = TotalInstalledPower;
            this.City = City;
            this.RoofSlope = RoofSlope;
            this.RoofOrientation = RoofOrientation;
            this.ElectricityPrice = ElectricityPrice;
            this.ElectricityExpectedGrowth = ElectricityExpectedGrowth;
            this.cityProduction = cityProduction;
        }

        public override string ToString() {
            return "Celková cena: " + installationPriceTotal + "\n" +
                    "Dotace: " + InstallationPriceGrant + "\n" +
                    "Celkové náklady: " + InstallationPriceCosts + "\n" +
                    "Celkový instalovaný výkon: " + TotalInstalledPower + "\n" +
                    "Město: " + City + "\n" +
                    "Sklon střechy: " + roofSlope + "\n" +
                    "Orientace střechy: " + RoofOrientation + "\n" +
                    "Cena elektřiny: " + electricityPrice + "\n" +
                    "Očekávaný růst ceny elektřiny: " + electricityExpectedGrowth;
        }

    }
}

using Microsoft.VisualBasic;
using Photovoltaics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace photovoltaics {
    public partial class mainForm : Form  {

        Dictionary<TextBox, string> lastValidTexts = new Dictionary<TextBox, string>();
        public int roofslope;

        public mainForm() {
            InitializeComponent();
        }

        // pro výpoèet ceny
        private void tBox_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string aux1 = (tb.Text == "") ? "0" : tb.Text;

            if (int.TryParse(aux1, out int x)) {

                if (lastValidTexts.ContainsKey(tb))
                    lastValidTexts[tb] = tb.Text;
                else
                    lastValidTexts.Add(tb, tb.Text);
            }
            else {
                if (lastValidTexts.ContainsKey(tb))
                    tb.Text = lastValidTexts[tb];
                else
                    tb.Text = "";
                tb.SelectionStart = tb.Text.Length;
            }
            string grant = txt_Grant.Text;
            string totalprice = txt_PriceWithoutGrant.Text;
            lab_total.Text = (Sum(txt_PriceWithoutGrant.Text, txt_Grant.Text) + " Kè");
        }


        // ostatní
        private void tBox_TextChanged2(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string aux1 = (tb.Text == "") ? "0" : tb.Text;

            if (double.TryParse(aux1, out double x)) {

                if (lastValidTexts.ContainsKey(tb))
                    lastValidTexts[tb] = tb.Text;
                else
                    lastValidTexts.Add(tb, tb.Text);
            }
            else {
                if (lastValidTexts.ContainsKey(tb))
                    tb.Text = lastValidTexts[tb];
                else
                    tb.Text = "";
                tb.SelectionStart = tb.Text.Length;
            }
        }

        //kalkulace

        public string Sum(string a, string b) {
            try {
                if (string.IsNullOrEmpty(a)) {
                    return 0.ToString();
                }
                else {
                    int sum = Convert.ToInt32(a) - Convert.ToInt32(b);
                    return sum.ToString();
                }
            }
            catch (FormatException) {
                return "Chybí hodnota v";
            }
            catch (Exception) {
                return "Chybí hodnota v";
            }
            
        }

        private void tb_Slope_Scroll(object sender, EventArgs e) {
            lab_roof.Text = tb_Slope.Value.ToString();
            roofslope = Convert.ToInt32(lab_roof.Text);
            lab_roof.Text = lab_roof.Text + "°";

            if (tb_Slope.Value < 15) {
                pictureBox2.Refresh();
                pictureBox2.ImageLocation = @"Images\0.png";
            }
            else if ((tb_Slope.Value > 16) && (tb_Slope.Value < 29)) {
                pictureBox2.Refresh();
                pictureBox2.ImageLocation = @"Images\20.png";
            }
            else if ((tb_Slope.Value > 30) && (tb_Slope.Value < 55)) {
                pictureBox2.Refresh();
                pictureBox2.ImageLocation = @"Images\45.png";
            }
            else if ((tb_Slope.Value > 56) && (tb_Slope.Value < 75)) {
                pictureBox2.Refresh();
                pictureBox2.ImageLocation = @"Images\60.png";
            }
        }

        private void btn_exchange_Click(object sender, EventArgs e) {
            txbElectricityPrice.Text = Exchange.burza().ToString("0.##");


        }

        private void btn_Next_Click(object sender, EventArgs e) {
            try {
                int priceWithoutGrant = Convert.ToInt32(txt_PriceWithoutGrant.Text);
                int grant = Convert.ToInt32(txt_Grant.Text);
                int totalPrice = priceWithoutGrant - grant;
                string city = "";
                city = CityVal();
                string orientation = "";
                orientation = OrientationVal(orientation);
                double cityProduction = 0;
                cityProduction = CityProductionVal();
                double installedPower = Convert.ToDouble(txt_installedPower.Text);
                double electricityPrice = Convert.ToDouble(txbElectricityPrice.Text);
                double expectedPrice = Convert.ToDouble(txbExpectedElectricityPrice.Text);

                Installation instalace = new Installation(
                priceWithoutGrant,
                grant,
                totalPrice,
                installedPower,
                city,
                roofslope,
                orientation,
                electricityPrice,
                expectedPrice,
                cityProduction
                );

                CalculationForm vypocet = new CalculationForm(instalace);
                vypocet.Show();
            }
            catch (FormatException) {
                MessageBox.Show("Formuláø neobsahuje všechny potøebné informace nebo nejsou ve správném formátu.");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + " Formuláø neobsahuje všechny potøebné informace nebo nejsou ve správném formátu.");

            }


        }

        private double CityProductionVal() {
            double cityProduction;
            switch (cb_cities.Text) {
                case "Praha":
                    cityProduction = 0.998;
                    break;
                case "Brno":
                    cityProduction = 1.049;
                    break;
                case "Olomouc":
                    cityProduction = 1.018;
                    break;
                case "Ostrava":
                    cityProduction = 1.001;
                    break;
                case "Liberec":
                    cityProduction = 0.996;
                    break;
                case "Ústí nad Labem":
                    cityProduction = 0.980;
                    break;
                case "Karlovy Vary":
                    cityProduction = 0.987;
                    break;
                case "Plzeò":
                    cityProduction = 1.004;
                    break;
                case "Èeské Budìjovice":
                    cityProduction = 1.029;
                    break;
                case "Jihlava":
                    cityProduction = 1.026;
                    break;
                case "Pardubice":
                    cityProduction = 1.008;
                    break;
                case "Hradec Králové":
                    cityProduction = 1.013;
                    break;
                case "Zlín":
                    cityProduction = 1.044;
                    break;
                default:
                    cityProduction = 1;
                    break;
            }

            return cityProduction;
        }

        private string CityVal() {
            string city;
            if (string.IsNullOrEmpty(cb_cities.Text)) {
                throw new FormatException();
            }
            else {
                city = cb_cities.Text;
            }

            return city;
        }

        private string OrientationVal(string orientation) {
            if (rb_Z.Checked) { orientation = "Západní"; }
            if (rb_J.Checked) { orientation = "Jižní"; }
            if (rb_V.Checked) { orientation = "Východní"; }
            if (rb_JZ.Checked) { orientation = "Jihozápadní"; }
            if (rb_JV.Checked) { orientation = "Jihovýchodní"; }
            if (string.IsNullOrEmpty(orientation)) { throw new FormatException(); }

            return orientation;
        }
    }
}
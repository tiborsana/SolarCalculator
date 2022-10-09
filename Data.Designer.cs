using System.Drawing;

namespace photovoltaics {
    partial class mainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_installationPrice = new System.Windows.Forms.GroupBox();
            this.lab_total = new System.Windows.Forms.Label();
            this.lab_Kc3 = new System.Windows.Forms.Label();
            this.lab_Kc2 = new System.Windows.Forms.Label();
            this.lab_Grant = new System.Windows.Forms.Label();
            this.lab_withoutGrant = new System.Windows.Forms.Label();
            this.lab_TotalPrice = new System.Windows.Forms.Label();
            this.txt_Grant = new System.Windows.Forms.TextBox();
            this.txt_PriceWithoutGrant = new System.Windows.Forms.TextBox();
            this.gb_Calculation = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lab_roof = new System.Windows.Forms.Label();
            this.cb_cities = new System.Windows.Forms.ComboBox();
            this.lab_location = new System.Windows.Forms.Label();
            this.panel_sklon = new System.Windows.Forms.Panel();
            this.rb_V = new System.Windows.Forms.RadioButton();
            this.rb_JV = new System.Windows.Forms.RadioButton();
            this.rb_Z = new System.Windows.Forms.RadioButton();
            this.rb_J = new System.Windows.Forms.RadioButton();
            this.rb_JZ = new System.Windows.Forms.RadioButton();
            this.tb_Slope = new System.Windows.Forms.TrackBar();
            this.lab_roofOrientation = new System.Windows.Forms.Label();
            this.lab_mgw = new System.Windows.Forms.Label();
            this.txt_installedPower = new System.Windows.Forms.TextBox();
            this.lab_roofSlope = new System.Windows.Forms.Label();
            this.lab_installedCapacity = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.gb_electricityPrice = new System.Windows.Forms.GroupBox();
            this.btn_exchange = new System.Windows.Forms.Button();
            this.lab_percent = new System.Windows.Forms.Label();
            this.lab_price = new System.Windows.Forms.Label();
            this.txbExpectedElectricityPrice = new System.Windows.Forms.TextBox();
            this.txbElectricityPrice = new System.Windows.Forms.TextBox();
            this.lab_expectedElectricityPrice = new System.Windows.Forms.Label();
            this.lab_currentElectricityPrice = new System.Windows.Forms.Label();
            this.tt_exchangeInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_installationPrice.SuspendLayout();
            this.gb_Calculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_sklon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slope)).BeginInit();
            this.gb_electricityPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gb_installationPrice
            // 
            this.gb_installationPrice.BackColor = System.Drawing.SystemColors.Control;
            this.gb_installationPrice.Controls.Add(this.lab_total);
            this.gb_installationPrice.Controls.Add(this.lab_Kc3);
            this.gb_installationPrice.Controls.Add(this.lab_Kc2);
            this.gb_installationPrice.Controls.Add(this.lab_Grant);
            this.gb_installationPrice.Controls.Add(this.lab_withoutGrant);
            this.gb_installationPrice.Controls.Add(this.lab_TotalPrice);
            this.gb_installationPrice.Controls.Add(this.txt_Grant);
            this.gb_installationPrice.Controls.Add(this.txt_PriceWithoutGrant);
            this.gb_installationPrice.Location = new System.Drawing.Point(19, 20);
            this.gb_installationPrice.Name = "gb_installationPrice";
            this.gb_installationPrice.Size = new System.Drawing.Size(758, 115);
            this.gb_installationPrice.TabIndex = 1;
            this.gb_installationPrice.TabStop = false;
            this.gb_installationPrice.Text = "Cena instalace";
            this.tt_exchangeInfo.SetToolTip(this.gb_installationPrice, "Stáhne\r\n aktuální cenu elektřiny na burze z portálu Kurzy.cz");
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(572, 76);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(0, 25);
            this.lab_total.TabIndex = 9;
            // 
            // lab_Kc3
            // 
            this.lab_Kc3.AutoSize = true;
            this.lab_Kc3.Location = new System.Drawing.Point(325, 70);
            this.lab_Kc3.Name = "lab_Kc3";
            this.lab_Kc3.Size = new System.Drawing.Size(30, 25);
            this.lab_Kc3.TabIndex = 8;
            this.lab_Kc3.Text = "Kč";
            // 
            // lab_Kc2
            // 
            this.lab_Kc2.AutoSize = true;
            this.lab_Kc2.Location = new System.Drawing.Point(325, 36);
            this.lab_Kc2.Name = "lab_Kc2";
            this.lab_Kc2.Size = new System.Drawing.Size(30, 25);
            this.lab_Kc2.TabIndex = 7;
            this.lab_Kc2.Text = "Kč";
            // 
            // lab_Grant
            // 
            this.lab_Grant.AutoSize = true;
            this.lab_Grant.Location = new System.Drawing.Point(16, 70);
            this.lab_Grant.Name = "lab_Grant";
            this.lab_Grant.Size = new System.Drawing.Size(112, 25);
            this.lab_Grant.TabIndex = 5;
            this.lab_Grant.Text = "Výše dotace:";
            // 
            // lab_withoutGrant
            // 
            this.lab_withoutGrant.AutoSize = true;
            this.lab_withoutGrant.Location = new System.Drawing.Point(16, 36);
            this.lab_withoutGrant.Name = "lab_withoutGrant";
            this.lab_withoutGrant.Size = new System.Drawing.Size(147, 25);
            this.lab_withoutGrant.TabIndex = 4;
            this.lab_withoutGrant.Text = "Cena bez dotace:";
            // 
            // lab_TotalPrice
            // 
            this.lab_TotalPrice.AutoSize = true;
            this.lab_TotalPrice.Location = new System.Drawing.Point(416, 76);
            this.lab_TotalPrice.Name = "lab_TotalPrice";
            this.lab_TotalPrice.Size = new System.Drawing.Size(150, 25);
            this.lab_TotalPrice.TabIndex = 3;
            this.lab_TotalPrice.Text = "Celková investice:";
            // 
            // txt_Grant
            // 
            this.txt_Grant.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Grant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Grant.Location = new System.Drawing.Point(169, 70);
            this.txt_Grant.Name = "txt_Grant";
            this.txt_Grant.Size = new System.Drawing.Size(150, 31);
            this.txt_Grant.TabIndex = 2;
            this.txt_Grant.Text = "0";
            this.txt_Grant.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // txt_PriceWithoutGrant
            // 
            this.txt_PriceWithoutGrant.BackColor = System.Drawing.SystemColors.Window;
            this.txt_PriceWithoutGrant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_PriceWithoutGrant.Location = new System.Drawing.Point(169, 33);
            this.txt_PriceWithoutGrant.Name = "txt_PriceWithoutGrant";
            this.txt_PriceWithoutGrant.Size = new System.Drawing.Size(150, 31);
            this.txt_PriceWithoutGrant.TabIndex = 1;
            this.txt_PriceWithoutGrant.Text = "0";
            this.txt_PriceWithoutGrant.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // gb_Calculation
            // 
            this.gb_Calculation.Controls.Add(this.pictureBox2);
            this.gb_Calculation.Controls.Add(this.lab_roof);
            this.gb_Calculation.Controls.Add(this.cb_cities);
            this.gb_Calculation.Controls.Add(this.lab_location);
            this.gb_Calculation.Controls.Add(this.panel_sklon);
            this.gb_Calculation.Controls.Add(this.tb_Slope);
            this.gb_Calculation.Controls.Add(this.lab_roofOrientation);
            this.gb_Calculation.Controls.Add(this.lab_mgw);
            this.gb_Calculation.Controls.Add(this.txt_installedPower);
            this.gb_Calculation.Controls.Add(this.lab_roofSlope);
            this.gb_Calculation.Controls.Add(this.lab_installedCapacity);
            this.gb_Calculation.Location = new System.Drawing.Point(21, 148);
            this.gb_Calculation.Name = "gb_Calculation";
            this.gb_Calculation.Size = new System.Drawing.Size(756, 310);
            this.gb_Calculation.TabIndex = 2;
            this.gb_Calculation.TabStop = false;
            this.gb_Calculation.Text = "Údaje potřebné pro výpočet návratnosti:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Photovoltaics.Properties.Resources._45;
            this.pictureBox2.InitialImage = global::Photovoltaics.Properties.Resources._45;
            this.pictureBox2.Location = new System.Drawing.Point(586, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lab_roof
            // 
            this.lab_roof.AutoSize = true;
            this.lab_roof.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_roof.Location = new System.Drawing.Point(468, 118);
            this.lab_roof.Name = "lab_roof";
            this.lab_roof.Size = new System.Drawing.Size(0, 27);
            this.lab_roof.TabIndex = 8;
            // 
            // cb_cities
            // 
            this.cb_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cities.FormattingEnabled = true;
            this.cb_cities.Items.AddRange(new object[] {
            "Brno",
            "České Budějovice",
            "Hradec Králové",
            "Jihlava",
            "Karlovy Vary",
            "Liberec",
            "Olomouc",
            "Ostrava",
            "Pardubice",
            "Plzeň",
            "Praha",
            "Ústí nad Labem",
            "Zlín"});
            this.cb_cities.Location = new System.Drawing.Point(553, 36);
            this.cb_cities.Name = "cb_cities";
            this.cb_cities.Size = new System.Drawing.Size(197, 33);
            this.cb_cities.Sorted = true;
            this.cb_cities.TabIndex = 7;
            // 
            // lab_location
            // 
            this.lab_location.AutoSize = true;
            this.lab_location.Location = new System.Drawing.Point(477, 39);
            this.lab_location.Name = "lab_location";
            this.lab_location.Size = new System.Drawing.Size(76, 25);
            this.lab_location.TabIndex = 6;
            this.lab_location.Text = "Lokalita:";
            // 
            // panel_sklon
            // 
            this.panel_sklon.Controls.Add(this.rb_V);
            this.panel_sklon.Controls.Add(this.rb_JV);
            this.panel_sklon.Controls.Add(this.rb_Z);
            this.panel_sklon.Controls.Add(this.rb_J);
            this.panel_sklon.Controls.Add(this.rb_JZ);
            this.panel_sklon.Location = new System.Drawing.Point(14, 247);
            this.panel_sklon.Name = "panel_sklon";
            this.panel_sklon.Size = new System.Drawing.Size(736, 44);
            this.panel_sklon.TabIndex = 3;
            // 
            // rb_V
            // 
            this.rb_V.AutoSize = true;
            this.rb_V.Location = new System.Drawing.Point(539, 3);
            this.rb_V.Name = "rb_V";
            this.rb_V.Size = new System.Drawing.Size(111, 29);
            this.rb_V.TabIndex = 5;
            this.rb_V.TabStop = true;
            this.rb_V.Text = "Východní";
            this.rb_V.UseVisualStyleBackColor = true;
            // 
            // rb_JV
            // 
            this.rb_JV.AutoSize = true;
            this.rb_JV.Location = new System.Drawing.Point(393, 3);
            this.rb_JV.Name = "rb_JV";
            this.rb_JV.Size = new System.Drawing.Size(140, 29);
            this.rb_JV.TabIndex = 4;
            this.rb_JV.TabStop = true;
            this.rb_JV.Text = "Jihovýchodní";
            this.rb_JV.UseVisualStyleBackColor = true;
            // 
            // rb_Z
            // 
            this.rb_Z.AutoSize = true;
            this.rb_Z.Location = new System.Drawing.Point(57, 3);
            this.rb_Z.Name = "rb_Z";
            this.rb_Z.Size = new System.Drawing.Size(101, 29);
            this.rb_Z.TabIndex = 1;
            this.rb_Z.TabStop = true;
            this.rb_Z.Text = "Západní";
            this.rb_Z.UseVisualStyleBackColor = true;
            // 
            // rb_J
            // 
            this.rb_J.AutoSize = true;
            this.rb_J.Location = new System.Drawing.Point(309, 3);
            this.rb_J.Name = "rb_J";
            this.rb_J.Size = new System.Drawing.Size(69, 29);
            this.rb_J.TabIndex = 3;
            this.rb_J.TabStop = true;
            this.rb_J.Text = "Jižní";
            this.rb_J.UseVisualStyleBackColor = true;
            // 
            // rb_JZ
            // 
            this.rb_JZ.AutoSize = true;
            this.rb_JZ.Location = new System.Drawing.Point(173, 3);
            this.rb_JZ.Name = "rb_JZ";
            this.rb_JZ.Size = new System.Drawing.Size(130, 29);
            this.rb_JZ.TabIndex = 2;
            this.rb_JZ.TabStop = true;
            this.rb_JZ.Text = "Jihozápadní";
            this.rb_JZ.UseVisualStyleBackColor = true;
            // 
            // tb_Slope
            // 
            this.tb_Slope.Location = new System.Drawing.Point(87, 127);
            this.tb_Slope.Maximum = 75;
            this.tb_Slope.Name = "tb_Slope";
            this.tb_Slope.Size = new System.Drawing.Size(381, 69);
            this.tb_Slope.SmallChange = 5;
            this.tb_Slope.TabIndex = 4;
            this.tb_Slope.TickFrequency = 5;
            this.tb_Slope.Scroll += new System.EventHandler(this.tb_Slope_Scroll);
            // 
            // lab_roofOrientation
            // 
            this.lab_roofOrientation.AutoSize = true;
            this.lab_roofOrientation.Location = new System.Drawing.Point(12, 219);
            this.lab_roofOrientation.Name = "lab_roofOrientation";
            this.lab_roofOrientation.Size = new System.Drawing.Size(152, 25);
            this.lab_roofOrientation.TabIndex = 5;
            this.lab_roofOrientation.Text = "Orientace střechy:";
            // 
            // lab_mgw
            // 
            this.lab_mgw.AutoSize = true;
            this.lab_mgw.Location = new System.Drawing.Point(397, 39);
            this.lab_mgw.Name = "lab_mgw";
            this.lab_mgw.Size = new System.Drawing.Size(40, 25);
            this.lab_mgw.TabIndex = 3;
            this.lab_mgw.Text = "Wp";
            // 
            // txt_installedPower
            // 
            this.txt_installedPower.Location = new System.Drawing.Point(242, 36);
            this.txt_installedPower.Name = "txt_installedPower";
            this.txt_installedPower.Size = new System.Drawing.Size(150, 31);
            this.txt_installedPower.TabIndex = 2;
            this.txt_installedPower.TextChanged += new System.EventHandler(this.tBox_TextChanged2);
            // 
            // lab_roofSlope
            // 
            this.lab_roofSlope.AutoSize = true;
            this.lab_roofSlope.Location = new System.Drawing.Point(11, 79);
            this.lab_roofSlope.Name = "lab_roofSlope";
            this.lab_roofSlope.Size = new System.Drawing.Size(121, 25);
            this.lab_roofSlope.TabIndex = 1;
            this.lab_roofSlope.Text = "Sklon střechy:";
            // 
            // lab_installedCapacity
            // 
            this.lab_installedCapacity.AutoSize = true;
            this.lab_installedCapacity.Location = new System.Drawing.Point(11, 36);
            this.lab_installedCapacity.Name = "lab_installedCapacity";
            this.lab_installedCapacity.Size = new System.Drawing.Size(225, 25);
            this.lab_installedCapacity.TabIndex = 0;
            this.lab_installedCapacity.Text = "Celkový instalovaný výkon:";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(659, 694);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 34);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Vypočítat";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // gb_electricityPrice
            // 
            this.gb_electricityPrice.Controls.Add(this.btn_exchange);
            this.gb_electricityPrice.Controls.Add(this.lab_percent);
            this.gb_electricityPrice.Controls.Add(this.lab_price);
            this.gb_electricityPrice.Controls.Add(this.txbExpectedElectricityPrice);
            this.gb_electricityPrice.Controls.Add(this.txbElectricityPrice);
            this.gb_electricityPrice.Controls.Add(this.lab_expectedElectricityPrice);
            this.gb_electricityPrice.Controls.Add(this.lab_currentElectricityPrice);
            this.gb_electricityPrice.Location = new System.Drawing.Point(22, 464);
            this.gb_electricityPrice.Name = "gb_electricityPrice";
            this.gb_electricityPrice.Size = new System.Drawing.Size(755, 130);
            this.gb_electricityPrice.TabIndex = 4;
            this.gb_electricityPrice.TabStop = false;
            this.gb_electricityPrice.Text = "Informace o ceně elektřiny:";
            // 
            // btn_exchange
            // 
            this.btn_exchange.Location = new System.Drawing.Point(607, 32);
            this.btn_exchange.Name = "btn_exchange";
            this.btn_exchange.Size = new System.Drawing.Size(124, 72);
            this.btn_exchange.TabIndex = 6;
            this.btn_exchange.Text = "Získat data z burzy";
            this.tt_exchangeInfo.SetToolTip(this.btn_exchange, "Stáhne aktuální cenu elektrické energie z portálu Kurzy.cz");
            this.btn_exchange.UseVisualStyleBackColor = true;
            this.btn_exchange.Click += new System.EventHandler(this.btn_exchange_Click);
            // 
            // lab_percent
            // 
            this.lab_percent.AutoSize = true;
            this.lab_percent.Location = new System.Drawing.Point(487, 77);
            this.lab_percent.Name = "lab_percent";
            this.lab_percent.Size = new System.Drawing.Size(76, 25);
            this.lab_percent.TabIndex = 5;
            this.lab_percent.Text = "% ročně";
            // 
            // lab_price
            // 
            this.lab_price.AutoSize = true;
            this.lab_price.Location = new System.Drawing.Point(370, 35);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(94, 25);
            this.lab_price.TabIndex = 4;
            this.lab_price.Text = "Kč za KWh";
            // 
            // txbExpectedElectricityPrice
            // 
            this.txbExpectedElectricityPrice.Location = new System.Drawing.Point(331, 74);
            this.txbExpectedElectricityPrice.Name = "txbExpectedElectricityPrice";
            this.txbExpectedElectricityPrice.Size = new System.Drawing.Size(150, 31);
            this.txbExpectedElectricityPrice.TabIndex = 3;
            this.txbExpectedElectricityPrice.Text = "4";
            this.txbExpectedElectricityPrice.TextChanged += new System.EventHandler(this.tBox_TextChanged2);
            // 
            // txbElectricityPrice
            // 
            this.txbElectricityPrice.Location = new System.Drawing.Point(214, 32);
            this.txbElectricityPrice.Name = "txbElectricityPrice";
            this.txbElectricityPrice.Size = new System.Drawing.Size(150, 31);
            this.txbElectricityPrice.TabIndex = 2;
            this.txbElectricityPrice.TextChanged += new System.EventHandler(this.tBox_TextChanged2);
            // 
            // lab_expectedElectricityPrice
            // 
            this.lab_expectedElectricityPrice.AutoSize = true;
            this.lab_expectedElectricityPrice.Location = new System.Drawing.Point(13, 77);
            this.lab_expectedElectricityPrice.Name = "lab_expectedElectricityPrice";
            this.lab_expectedElectricityPrice.Size = new System.Drawing.Size(312, 25);
            this.lab_expectedElectricityPrice.TabIndex = 1;
            this.lab_expectedElectricityPrice.Text = "Očekávaný roční nárůst ceny elektřiny:";
            // 
            // lab_currentElectricityPrice
            // 
            this.lab_currentElectricityPrice.AutoSize = true;
            this.lab_currentElectricityPrice.Location = new System.Drawing.Point(11, 32);
            this.lab_currentElectricityPrice.Name = "lab_currentElectricityPrice";
            this.lab_currentElectricityPrice.Size = new System.Drawing.Size(197, 25);
            this.lab_currentElectricityPrice.TabIndex = 0;
            this.lab_currentElectricityPrice.Text = "Aktuální cena elektřiny: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 743);
            this.Controls.Add(this.gb_electricityPrice);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.gb_Calculation);
            this.Controls.Add(this.gb_installationPrice);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Solar Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_installationPrice.ResumeLayout(false);
            this.gb_installationPrice.PerformLayout();
            this.gb_Calculation.ResumeLayout(false);
            this.gb_Calculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_sklon.ResumeLayout(false);
            this.panel_sklon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slope)).EndInit();
            this.gb_electricityPrice.ResumeLayout(false);
            this.gb_electricityPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox gb_installationPrice;
        private Label lab_TotalPrice;
        private TextBox txt_Grant;
        private TextBox txt_PriceWithoutGrant;
        private Label lab_withoutGrant;
        private Label lab_Grant;
        private Label lab_Kc3;
        private Label lab_Kc2;
        private GroupBox gb_Calculation;
        private TrackBar tb_Slope;
        private Label lab_mgw;
        private TextBox txt_installedPower;
        private Label lab_roofSlope;
        private Label lab_installedCapacity;
        private Label lab_roofOrientation;
        private RadioButton rb_V;
        private RadioButton rb_JV;
        private RadioButton rb_J;
        private RadioButton rb_JZ;
        private RadioButton rb_Z;
        private Panel panel_sklon;
        private ComboBox cb_cities;
        private Label lab_location;
        private Button btn_Next;
        private GroupBox gb_electricityPrice;
        private Button btn_exchange;
        private Label lab_percent;
        private Label lab_price;
        private TextBox txbExpectedElectricityPrice;
        private TextBox txbElectricityPrice;
        private Label lab_expectedElectricityPrice;
        private Label lab_currentElectricityPrice;
        private Label lab_total;
        private Label lab_roof;
        private PictureBox pictureBox2;
        private ToolTip tt_exchangeInfo;
    }
}
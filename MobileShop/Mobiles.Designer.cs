namespace MobileShop
{
    partial class Mobiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mobiles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saleRatetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.openingStocktxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.purchaseRatetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.imeitxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.investornameCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mobileidtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.mobilenametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1345, 346);
            this.dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1039, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search :";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Animated = true;
            this.Searchtxt.AutoRoundedCorners = true;
            this.Searchtxt.BorderRadius = 17;
            this.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.DefaultText = "";
            this.Searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.Location = new System.Drawing.Point(1099, 203);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.PlaceholderText = "";
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.Size = new System.Drawing.Size(200, 36);
            this.Searchtxt.TabIndex = 14;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.saleRatetxt);
            this.panel1.Controls.Add(this.openingStocktxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Searchtxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ModelTxt);
            this.panel1.Controls.Add(this.purchaseRatetxt);
            this.panel1.Controls.Add(this.imeitxt);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.investornameCmb);
            this.panel1.Controls.Add(this.mobileidtxt);
            this.panel1.Controls.Add(this.mobilenametxt);
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 242);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saleRatetxt
            // 
            this.saleRatetxt.Animated = true;
            this.saleRatetxt.AutoRoundedCorners = true;
            this.saleRatetxt.BorderColor = System.Drawing.Color.Black;
            this.saleRatetxt.BorderRadius = 19;
            this.saleRatetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleRatetxt.DefaultText = "";
            this.saleRatetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saleRatetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saleRatetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleRatetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleRatetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleRatetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleRatetxt.ForeColor = System.Drawing.Color.Black;
            this.saleRatetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleRatetxt.Location = new System.Drawing.Point(607, 67);
            this.saleRatetxt.Name = "saleRatetxt";
            this.saleRatetxt.PasswordChar = '\0';
            this.saleRatetxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.saleRatetxt.PlaceholderText = "Sale Rate";
            this.saleRatetxt.SelectedText = "";
            this.saleRatetxt.Size = new System.Drawing.Size(173, 41);
            this.saleRatetxt.TabIndex = 15;
            // 
            // openingStocktxt
            // 
            this.openingStocktxt.Animated = true;
            this.openingStocktxt.AutoRoundedCorners = true;
            this.openingStocktxt.BorderColor = System.Drawing.Color.Black;
            this.openingStocktxt.BorderRadius = 19;
            this.openingStocktxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.openingStocktxt.DefaultText = "";
            this.openingStocktxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.openingStocktxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.openingStocktxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.openingStocktxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.openingStocktxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openingStocktxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openingStocktxt.ForeColor = System.Drawing.Color.Black;
            this.openingStocktxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openingStocktxt.Location = new System.Drawing.Point(441, 124);
            this.openingStocktxt.Name = "openingStocktxt";
            this.openingStocktxt.PasswordChar = '\0';
            this.openingStocktxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.openingStocktxt.PlaceholderText = "Opening Stock";
            this.openingStocktxt.SelectedText = "";
            this.openingStocktxt.Size = new System.Drawing.Size(160, 41);
            this.openingStocktxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(616, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Investor Name";
            // 
            // ModelTxt
            // 
            this.ModelTxt.Animated = true;
            this.ModelTxt.AutoRoundedCorners = true;
            this.ModelTxt.BorderColor = System.Drawing.Color.Black;
            this.ModelTxt.BorderRadius = 19;
            this.ModelTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTxt.DefaultText = "";
            this.ModelTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModelTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModelTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ModelTxt.ForeColor = System.Drawing.Color.Black;
            this.ModelTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTxt.Location = new System.Drawing.Point(25, 124);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.PasswordChar = '\0';
            this.ModelTxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.ModelTxt.PlaceholderText = "Models";
            this.ModelTxt.SelectedText = "";
            this.ModelTxt.Size = new System.Drawing.Size(410, 41);
            this.ModelTxt.TabIndex = 8;
            // 
            // purchaseRatetxt
            // 
            this.purchaseRatetxt.Animated = true;
            this.purchaseRatetxt.AutoRoundedCorners = true;
            this.purchaseRatetxt.BorderColor = System.Drawing.Color.Black;
            this.purchaseRatetxt.BorderRadius = 19;
            this.purchaseRatetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchaseRatetxt.DefaultText = "";
            this.purchaseRatetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purchaseRatetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purchaseRatetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purchaseRatetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purchaseRatetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purchaseRatetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purchaseRatetxt.ForeColor = System.Drawing.Color.Black;
            this.purchaseRatetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purchaseRatetxt.Location = new System.Drawing.Point(441, 68);
            this.purchaseRatetxt.Name = "purchaseRatetxt";
            this.purchaseRatetxt.PasswordChar = '\0';
            this.purchaseRatetxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.purchaseRatetxt.PlaceholderText = "Purchase Rate";
            this.purchaseRatetxt.SelectedText = "";
            this.purchaseRatetxt.Size = new System.Drawing.Size(160, 41);
            this.purchaseRatetxt.TabIndex = 4;
            this.purchaseRatetxt.TextChanged += new System.EventHandler(this.mobpricetxt_TextChanged);
            // 
            // imeitxt
            // 
            this.imeitxt.Animated = true;
            this.imeitxt.AutoRoundedCorners = true;
            this.imeitxt.BorderColor = System.Drawing.Color.Black;
            this.imeitxt.BorderRadius = 16;
            this.imeitxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imeitxt.DefaultText = "";
            this.imeitxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.imeitxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.imeitxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imeitxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imeitxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imeitxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imeitxt.ForeColor = System.Drawing.Color.Black;
            this.imeitxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imeitxt.Location = new System.Drawing.Point(28, 185);
            this.imeitxt.MaxLength = 11;
            this.imeitxt.Name = "imeitxt";
            this.imeitxt.PasswordChar = '\0';
            this.imeitxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.imeitxt.PlaceholderText = "IMEI";
            this.imeitxt.SelectedText = "";
            this.imeitxt.Size = new System.Drawing.Size(172, 35);
            this.imeitxt.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(756, 171);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 30);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // investornameCmb
            // 
            this.investornameCmb.AutoRoundedCorners = true;
            this.investornameCmb.BackColor = System.Drawing.Color.Transparent;
            this.investornameCmb.BorderColor = System.Drawing.Color.Black;
            this.investornameCmb.BorderRadius = 17;
            this.investornameCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.investornameCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.investornameCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.investornameCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.investornameCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.investornameCmb.ForeColor = System.Drawing.Color.Black;
            this.investornameCmb.ItemHeight = 30;
            this.investornameCmb.Location = new System.Drawing.Point(607, 129);
            this.investornameCmb.Name = "investornameCmb";
            this.investornameCmb.Size = new System.Drawing.Size(160, 36);
            this.investornameCmb.TabIndex = 7;
            this.investornameCmb.SelectedIndexChanged += new System.EventHandler(this.investornameCmb_SelectedIndexChanged);
            // 
            // mobileidtxt
            // 
            this.mobileidtxt.Animated = true;
            this.mobileidtxt.AutoRoundedCorners = true;
            this.mobileidtxt.BorderColor = System.Drawing.Color.Black;
            this.mobileidtxt.BorderRadius = 19;
            this.mobileidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobileidtxt.DefaultText = "";
            this.mobileidtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobileidtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobileidtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileidtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileidtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileidtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mobileidtxt.ForeColor = System.Drawing.Color.Black;
            this.mobileidtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileidtxt.Location = new System.Drawing.Point(28, 20);
            this.mobileidtxt.Name = "mobileidtxt";
            this.mobileidtxt.PasswordChar = '\0';
            this.mobileidtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mobileidtxt.PlaceholderText = "Mobile ID";
            this.mobileidtxt.ReadOnly = true;
            this.mobileidtxt.SelectedText = "";
            this.mobileidtxt.Size = new System.Drawing.Size(160, 41);
            this.mobileidtxt.TabIndex = 1;
            // 
            // mobilenametxt
            // 
            this.mobilenametxt.Animated = true;
            this.mobilenametxt.AutoRoundedCorners = true;
            this.mobilenametxt.BorderColor = System.Drawing.Color.Black;
            this.mobilenametxt.BorderRadius = 19;
            this.mobilenametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobilenametxt.DefaultText = "";
            this.mobilenametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobilenametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobilenametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobilenametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobilenametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobilenametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mobilenametxt.ForeColor = System.Drawing.Color.Black;
            this.mobilenametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobilenametxt.Location = new System.Drawing.Point(25, 68);
            this.mobilenametxt.Name = "mobilenametxt";
            this.mobilenametxt.PasswordChar = '\0';
            this.mobilenametxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mobilenametxt.PlaceholderText = "Mobile Name";
            this.mobilenametxt.SelectedText = "";
            this.mobilenametxt.Size = new System.Drawing.Size(410, 41);
            this.mobilenametxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add mobiles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Mobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Mobiles";
            this.Text = "Mobiles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mobiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Searchtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox purchaseRatetxt;
        private Guna.UI2.WinForms.Guna2TextBox imeitxt;
        private Guna.UI2.WinForms.Guna2TextBox mobileidtxt;
        private Guna.UI2.WinForms.Guna2TextBox mobilenametxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox investornameCmb;
        private Guna.UI2.WinForms.Guna2TextBox ModelTxt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox openingStocktxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox saleRatetxt;
    }
}
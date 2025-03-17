namespace CanteenApp1
{
    partial class Userinputmenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label namaMenuLabel;
            System.Windows.Forms.Label hPPLabel;
            System.Windows.Forms.Label hargaLabel;
            System.Windows.Forms.Label setIdLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label namaSupplierLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userinputmenu));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CanteenDataSet = new CanteenApp1.DB_CanteenDataSet();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.txtHPP = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.setIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.menuTableAdapter = new CanteenApp1.DB_CanteenDataSetTableAdapters.MenuTableAdapter();
            this.tableAdapterManager = new CanteenApp1.DB_CanteenDataSetTableAdapters.TableAdapterManager();
            this.menuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            idLabel = new System.Windows.Forms.Label();
            namaMenuLabel = new System.Windows.Forms.Label();
            hPPLabel = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            setIdLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            namaSupplierLabel = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CanteenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIdNumericUpDown)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingNavigator)).BeginInit();
            this.menuBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(32, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // namaMenuLabel
            // 
            namaMenuLabel.AutoSize = true;
            namaMenuLabel.Location = new System.Drawing.Point(32, 60);
            namaMenuLabel.Name = "namaMenuLabel";
            namaMenuLabel.Size = new System.Drawing.Size(68, 13);
            namaMenuLabel.TabIndex = 2;
            namaMenuLabel.Text = "Nama Menu:";
            // 
            // hPPLabel
            // 
            hPPLabel.AutoSize = true;
            hPPLabel.Location = new System.Drawing.Point(32, 86);
            hPPLabel.Name = "hPPLabel";
            hPPLabel.Size = new System.Drawing.Size(32, 13);
            hPPLabel.TabIndex = 4;
            hPPLabel.Text = "HPP:";
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(32, 112);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(39, 13);
            hargaLabel.TabIndex = 6;
            hargaLabel.Text = "Harga:";
            // 
            // setIdLabel
            // 
            setIdLabel.AutoSize = true;
            setIdLabel.Location = new System.Drawing.Point(32, 135);
            setIdLabel.Name = "setIdLabel";
            setIdLabel.Size = new System.Drawing.Size(38, 13);
            setIdLabel.TabIndex = 8;
            setIdLabel.Text = "Set Id:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(32, 164);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 10;
            stockLabel.Text = "Stock:";
            // 
            // namaSupplierLabel
            // 
            namaSupplierLabel.AutoSize = true;
            namaSupplierLabel.Location = new System.Drawing.Point(32, 190);
            namaSupplierLabel.Name = "namaSupplierLabel";
            namaSupplierLabel.Size = new System.Drawing.Size(79, 13);
            namaSupplierLabel.TabIndex = 12;
            namaSupplierLabel.Text = "Nama Supplier:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.guna2Panel3.Controls.Add(this.guna2Button7);
            this.guna2Panel3.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel3.Location = new System.Drawing.Point(173, 107);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(618, 337);
            this.guna2Panel3.TabIndex = 5;
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Location = new System.Drawing.Point(510, 33);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(77, 36);
            this.guna2Button7.TabIndex = 3;
            this.guna2Button7.Text = "View";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.Controls.Add(this.guna2Button5);
            this.guna2GradientPanel1.Controls.Add(idLabel);
            this.guna2GradientPanel1.Controls.Add(this.idTextBox);
            this.guna2GradientPanel1.Controls.Add(namaMenuLabel);
            this.guna2GradientPanel1.Controls.Add(this.txtNamaMenu);
            this.guna2GradientPanel1.Controls.Add(hPPLabel);
            this.guna2GradientPanel1.Controls.Add(this.txtHPP);
            this.guna2GradientPanel1.Controls.Add(hargaLabel);
            this.guna2GradientPanel1.Controls.Add(this.txtHarga);
            this.guna2GradientPanel1.Controls.Add(setIdLabel);
            this.guna2GradientPanel1.Controls.Add(this.setIdNumericUpDown);
            this.guna2GradientPanel1.Controls.Add(stockLabel);
            this.guna2GradientPanel1.Controls.Add(this.txtStock);
            this.guna2GradientPanel1.Controls.Add(namaSupplierLabel);
            this.guna2GradientPanel1.Controls.Add(this.txtNamaSupplier);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(157, 33);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(300, 276);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Blue;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(204, 229);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(73, 33);
            this.guna2Button5.TabIndex = 14;
            this.guna2Button5.Text = "Add";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(117, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dB_CanteenDataSet;
            // 
            // dB_CanteenDataSet
            // 
            this.dB_CanteenDataSet.DataSetName = "DB_CanteenDataSet";
            this.dB_CanteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "NamaMenu", true));
            this.txtNamaMenu.Location = new System.Drawing.Point(117, 57);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(120, 20);
            this.txtNamaMenu.TabIndex = 3;
            // 
            // txtHPP
            // 
            this.txtHPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "HPP", true));
            this.txtHPP.Location = new System.Drawing.Point(117, 83);
            this.txtHPP.Name = "txtHPP";
            this.txtHPP.Size = new System.Drawing.Size(120, 20);
            this.txtHPP.TabIndex = 5;
            // 
            // txtHarga
            // 
            this.txtHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Harga", true));
            this.txtHarga.Location = new System.Drawing.Point(117, 109);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(120, 20);
            this.txtHarga.TabIndex = 7;
            // 
            // setIdNumericUpDown
            // 
            this.setIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.menuBindingSource, "SetId", true));
            this.setIdNumericUpDown.Location = new System.Drawing.Point(117, 135);
            this.setIdNumericUpDown.Name = "setIdNumericUpDown";
            this.setIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.setIdNumericUpDown.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "Stock", true));
            this.txtStock.Location = new System.Drawing.Point(117, 161);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 11;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "NamaSupplier", true));
            this.txtNamaSupplier.Location = new System.Drawing.Point(117, 187);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(120, 20);
            this.txtNamaSupplier.TabIndex = 13;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(164, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(636, 101);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(150, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(194, 35);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Date and Time";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button6);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(164, 450);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.guna2Button4.BorderRadius = 2;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(-3, 296);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(120, 36);
            this.guna2Button4.TabIndex = 9;
            this.guna2Button4.Text = "Laporan Penjualan";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.guna2Button3.BorderRadius = 2;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(-3, 249);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 36);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Absensi";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.guna2Button2.BorderRadius = 2;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(-3, 199);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 36);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Input Menu";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(176)))), ((int)(((byte)(121)))));
            this.guna2Button6.BorderRadius = 1;
            this.guna2Button6.BorderThickness = 2;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(66, 406);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(102, 31);
            this.guna2Button6.TabIndex = 6;
            this.guna2Button6.Text = "Logout";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(-3, 151);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 36);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(31, 25);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(90, 88);
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbsensiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KantinTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.PenjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CanteenApp1.DB_CanteenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // menuBindingNavigator
            // 
            this.menuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuBindingNavigator.BindingSource = this.menuBindingSource;
            this.menuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.menuBindingNavigatorSaveItem});
            this.menuBindingNavigator.Location = new System.Drawing.Point(164, 101);
            this.menuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuBindingNavigator.Name = "menuBindingNavigator";
            this.menuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuBindingNavigator.Size = new System.Drawing.Size(636, 25);
            this.menuBindingNavigator.TabIndex = 6;
            this.menuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuBindingNavigatorSaveItem
            // 
            this.menuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuBindingNavigatorSaveItem.Image")));
            this.menuBindingNavigatorSaveItem.Name = "menuBindingNavigatorSaveItem";
            this.menuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.menuBindingNavigatorSaveItem.Text = "Save Data";
            this.menuBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuBindingNavigatorSaveItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Userinputmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBindingNavigator);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Userinputmenu";
            this.Text = "userinputmenu";
            this.Load += new System.EventHandler(this.Userinputmenu_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CanteenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIdNumericUpDown)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingNavigator)).EndInit();
            this.menuBindingNavigator.ResumeLayout(false);
            this.menuBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private DB_CanteenDataSet dB_CanteenDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DB_CanteenDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private DB_CanteenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton menuBindingNavigatorSaveItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.TextBox txtHPP;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.NumericUpDown setIdNumericUpDown;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
    }
}
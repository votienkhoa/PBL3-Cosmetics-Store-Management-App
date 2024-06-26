﻿namespace PBL3___Cosmetics_Store_Management_App
{
    partial class frmMain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProvider = new Guna.UI2.WinForms.Guna2Button();
            this.btnReceipt = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUser = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnProvider);
            this.guna2Panel1.Controls.Add(this.btnReceipt);
            this.guna2Panel1.Controls.Add(this.btnCustomer);
            this.guna2Panel1.Controls.Add(this.btnReport);
            this.guna2Panel1.Controls.Add(this.btnStaff);
            this.guna2Panel1.Controls.Add(this.btnProduct);
            this.guna2Panel1.Controls.Add(this.btnCategory);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(289, 931);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.26957F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(55, 867);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProvider
            // 
            this.btnProvider.Animated = true;
            this.btnProvider.AutoRoundedCorners = true;
            this.btnProvider.BorderRadius = 32;
            this.btnProvider.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProvider.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnProvider.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnProvider.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.provider_white;
            this.btnProvider.CustomizableEdges.BottomRight = false;
            this.btnProvider.CustomizableEdges.TopRight = false;
            this.btnProvider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProvider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProvider.FillColor = System.Drawing.Color.Transparent;
            this.btnProvider.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnProvider.ForeColor = System.Drawing.Color.Black;
            this.btnProvider.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.provider_green;
            this.btnProvider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProvider.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProvider.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProvider.Location = new System.Drawing.Point(35, 728);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(254, 66);
            this.btnProvider.TabIndex = 9;
            this.btnProvider.Text = "Provider";
            this.btnProvider.TextOffset = new System.Drawing.Point(10, 0);
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Animated = true;
            this.btnReceipt.AutoRoundedCorners = true;
            this.btnReceipt.BorderRadius = 32;
            this.btnReceipt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReceipt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnReceipt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.receipt_white;
            this.btnReceipt.CustomizableEdges.BottomRight = false;
            this.btnReceipt.CustomizableEdges.TopRight = false;
            this.btnReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReceipt.FillColor = System.Drawing.Color.Transparent;
            this.btnReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnReceipt.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.receipt_green;
            this.btnReceipt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReceipt.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReceipt.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReceipt.Location = new System.Drawing.Point(35, 584);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(254, 66);
            this.btnReceipt.TabIndex = 8;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextOffset = new System.Drawing.Point(10, 0);
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Animated = true;
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BorderRadius = 32;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.customer_white;
            this.btnCustomer.CustomizableEdges.BottomRight = false;
            this.btnCustomer.CustomizableEdges.TopRight = false;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.customer_green1;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCustomer.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomer.Location = new System.Drawing.Point(32, 512);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(257, 66);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReport
            // 
            this.btnReport.Animated = true;
            this.btnReport.AutoRoundedCorners = true;
            this.btnReport.BorderRadius = 32;
            this.btnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReport.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnReport.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnReport.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.report_white;
            this.btnReport.CustomizableEdges.BottomRight = false;
            this.btnReport.CustomizableEdges.TopRight = false;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.FillColor = System.Drawing.Color.Transparent;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.report_green;
            this.btnReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReport.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReport.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReport.Location = new System.Drawing.Point(35, 656);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(254, 66);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.TextOffset = new System.Drawing.Point(10, 0);
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Animated = true;
            this.btnStaff.AutoRoundedCorners = true;
            this.btnStaff.BorderRadius = 32;
            this.btnStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnStaff.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnStaff.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.staff_white;
            this.btnStaff.CustomizableEdges.BottomRight = false;
            this.btnStaff.CustomizableEdges.TopRight = false;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.staff_green;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStaff.Location = new System.Drawing.Point(35, 440);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(254, 66);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Animated = true;
            this.btnProduct.AutoRoundedCorners = true;
            this.btnProduct.BorderRadius = 32;
            this.btnProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnProduct.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnProduct.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.product_white;
            this.btnProduct.CustomizableEdges.BottomRight = false;
            this.btnProduct.CustomizableEdges.TopRight = false;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.product_green;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProduct.Location = new System.Drawing.Point(35, 368);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(254, 66);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Animated = true;
            this.btnCategory.AutoRoundedCorners = true;
            this.btnCategory.BorderRadius = 32;
            this.btnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnCategory.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCategory.CheckedState.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.category_white;
            this.btnCategory.CustomizableEdges.BottomRight = false;
            this.btnCategory.CustomizableEdges.TopRight = false;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.Transparent;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.01739F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.category_green;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCategory.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCategory.Location = new System.Drawing.Point(35, 296);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(254, 66);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categories";
            this.btnCategory.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(0, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cosmetics Store Management App ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(32, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(219, 191);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.CenterPanel.Controls.Add(this.label3);
            this.CenterPanel.Controls.Add(this.guna2PictureBox2);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(289, 44);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(908, 887);
            this.CenterPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(908, 99);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cosmetics Store Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.Image = global::PBL3___Cosmetics_Store_Management_App.Properties.Resources.cosmetic;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(262, 149);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(379, 430);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(851, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(749, 8);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderRadius = 5;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(800, 8);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Controls.Add(this.txtUser);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(289, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(908, 44);
            this.guna2Panel2.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(31, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(86, 25);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "TestUser";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 931);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label txtUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnReceipt;
        private Guna.UI2.WinForms.Guna2Button btnProvider;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}
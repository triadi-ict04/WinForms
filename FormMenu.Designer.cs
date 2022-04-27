namespace WinForms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnListUser = new FontAwesome.Sharp.IconButton();
            this.btnListUnit = new FontAwesome.Sharp.IconButton();
            this.btnReferensi = new FontAwesome.Sharp.IconButton();
            this.btnListTransaksi = new FontAwesome.Sharp.IconButton();
            this.btnTransaksi = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblNamaJT = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_akses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnListUser);
            this.panelMenu.Controls.Add(this.btnListUnit);
            this.panelMenu.Controls.Add(this.btnReferensi);
            this.panelMenu.Controls.Add(this.btnListTransaksi);
            this.panelMenu.Controls.Add(this.btnTransaksi);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(215, 46);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "LOGOUT";
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnListUser
            // 
            this.btnListUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUser.FlatAppearance.BorderSize = 0;
            this.btnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUser.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUser.ForeColor = System.Drawing.Color.White;
            this.btnListUser.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.btnListUser.IconColor = System.Drawing.Color.White;
            this.btnListUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListUser.IconSize = 30;
            this.btnListUser.Location = new System.Drawing.Point(0, 330);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListUser.Size = new System.Drawing.Size(215, 46);
            this.btnListUser.TabIndex = 6;
            this.btnListUser.Tag = "LIST USER";
            this.btnListUser.Text = "LIST USER";
            this.btnListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnListUnit
            // 
            this.btnListUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUnit.FlatAppearance.BorderSize = 0;
            this.btnListUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUnit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUnit.ForeColor = System.Drawing.Color.White;
            this.btnListUnit.IconChar = FontAwesome.Sharp.IconChar.Caravan;
            this.btnListUnit.IconColor = System.Drawing.Color.White;
            this.btnListUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListUnit.IconSize = 30;
            this.btnListUnit.Location = new System.Drawing.Point(0, 284);
            this.btnListUnit.Name = "btnListUnit";
            this.btnListUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListUnit.Size = new System.Drawing.Size(215, 46);
            this.btnListUnit.TabIndex = 5;
            this.btnListUnit.Tag = "LIST UNIT";
            this.btnListUnit.Text = "LIST UNIT";
            this.btnListUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListUnit.UseVisualStyleBackColor = true;
            this.btnListUnit.Click += new System.EventHandler(this.btnListUnit_Click);
            // 
            // btnReferensi
            // 
            this.btnReferensi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferensi.FlatAppearance.BorderSize = 0;
            this.btnReferensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferensi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferensi.ForeColor = System.Drawing.Color.White;
            this.btnReferensi.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnReferensi.IconColor = System.Drawing.Color.White;
            this.btnReferensi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReferensi.IconSize = 30;
            this.btnReferensi.Location = new System.Drawing.Point(0, 238);
            this.btnReferensi.Name = "btnReferensi";
            this.btnReferensi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReferensi.Size = new System.Drawing.Size(215, 46);
            this.btnReferensi.TabIndex = 4;
            this.btnReferensi.Tag = "REFERENSI";
            this.btnReferensi.Text = "REFERENSI";
            this.btnReferensi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferensi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReferensi.UseVisualStyleBackColor = true;
            this.btnReferensi.Click += new System.EventHandler(this.btnReferensi_Click);
            // 
            // btnListTransaksi
            // 
            this.btnListTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTransaksi.FlatAppearance.BorderSize = 0;
            this.btnListTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTransaksi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnListTransaksi.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListTransaksi.IconColor = System.Drawing.Color.White;
            this.btnListTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListTransaksi.IconSize = 30;
            this.btnListTransaksi.Location = new System.Drawing.Point(0, 192);
            this.btnListTransaksi.Name = "btnListTransaksi";
            this.btnListTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListTransaksi.Size = new System.Drawing.Size(215, 46);
            this.btnListTransaksi.TabIndex = 3;
            this.btnListTransaksi.Tag = "LIST TRANSAKSI";
            this.btnListTransaksi.Text = "LIST TRANSAKSI";
            this.btnListTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListTransaksi.UseVisualStyleBackColor = true;
            this.btnListTransaksi.Click += new System.EventHandler(this.btnListTransaksi_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnTransaksi.IconColor = System.Drawing.Color.White;
            this.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksi.IconSize = 30;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 146);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransaksi.Size = new System.Drawing.Size(215, 46);
            this.btnTransaksi.TabIndex = 2;
            this.btnTransaksi.Tag = "TRANSAKSI";
            this.btnTransaksi.Text = "TRANSAKSI";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(215, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "DASHBOARD";
            this.btnHome.Text = "DASHBOARD";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_akses);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(155, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Tag = "";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblNamaJT);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(215, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(919, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblNamaJT
            // 
            this.lblNamaJT.AutoSize = true;
            this.lblNamaJT.Font = new System.Drawing.Font("Verdana", 19.75F, System.Drawing.FontStyle.Bold);
            this.lblNamaJT.Location = new System.Drawing.Point(6, 9);
            this.lblNamaJT.Name = "lblNamaJT";
            this.lblNamaJT.Size = new System.Drawing.Size(332, 32);
            this.lblNamaJT.TabIndex = 20;
            this.lblNamaJT.Text = "JEMBATAN TIMBANG";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(786, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(830, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 18;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(874, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(215, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(919, 461);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblDatetime);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(215, 521);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(919, 40);
            this.panelFooter.TabIndex = 2;
            // 
            // lblDatetime
            // 
            this.lblDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDatetime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDatetime.Location = new System.Drawing.Point(754, 10);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(155, 13);
            this.lblDatetime.TabIndex = 3;
            this.lblDatetime.Text = "dd-MM-yyyy HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_username.Location = new System.Drawing.Point(102, 51);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 16);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Operator 1";
            // 
            // lbl_akses
            // 
            this.lbl_akses.AutoSize = true;
            this.lbl_akses.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_akses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_akses.Location = new System.Drawing.Point(102, 80);
            this.lbl_akses.Name = "lbl_akses";
            this.lbl_akses.Size = new System.Drawing.Size(95, 16);
            this.lbl_akses.TabIndex = 18;
            this.lbl_akses.Text = "Administrator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(102, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "as";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnListUser;
        private FontAwesome.Sharp.IconButton btnListUnit;
        private FontAwesome.Sharp.IconButton btnReferensi;
        private FontAwesome.Sharp.IconButton btnListTransaksi;
        private FontAwesome.Sharp.IconButton btnTransaksi;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label lblNamaJT;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_akses;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_username;
    }
}


namespace WinForms
{
    partial class FormUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAktif = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKontraktor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEntity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtDefaultTare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEgi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cbJmlData = new System.Windows.Forms.ComboBox();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.UNIT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_ENTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_EGI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_KONTRAKTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_DEFAULT_TARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_AKTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblDatetime);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 43);
            this.panel1.TabIndex = 3;
            // 
            // lblDatetime
            // 
            this.lblDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDatetime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatetime.Location = new System.Drawing.Point(17, 27);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(155, 13);
            this.lblDatetime.TabIndex = 8;
            this.lblDatetime.Text = "dd-MM-yyyy HH:mm:ss";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(882, 6);
            this.btn_close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 27);
            this.btn_close.TabIndex = 7;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI TARE UNIT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbAktif);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbKontraktor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbEntity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.txtDefaultTare);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEgi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNoUnit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 472);
            this.panel2.TabIndex = 4;
            // 
            // cbAktif
            // 
            this.cbAktif.FormattingEnabled = true;
            this.cbAktif.Location = new System.Drawing.Point(15, 311);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(143, 21);
            this.cbAktif.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "AKTIF";
            // 
            // cbKontraktor
            // 
            this.cbKontraktor.FormattingEnabled = true;
            this.cbKontraktor.Location = new System.Drawing.Point(15, 190);
            this.cbKontraktor.Name = "cbKontraktor";
            this.cbKontraktor.Size = new System.Drawing.Size(143, 21);
            this.cbKontraktor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "KONTRAKTOR";
            // 
            // cbEntity
            // 
            this.cbEntity.FormattingEnabled = true;
            this.cbEntity.Location = new System.Drawing.Point(13, 88);
            this.cbEntity.Name = "cbEntity";
            this.cbEntity.Size = new System.Drawing.Size(143, 21);
            this.cbEntity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ENTITY";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(110, 407);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 31);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Reset";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Navy;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(14, 407);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 31);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtDefaultTare
            // 
            this.txtDefaultTare.Location = new System.Drawing.Point(15, 251);
            this.txtDefaultTare.Name = "txtDefaultTare";
            this.txtDefaultTare.Size = new System.Drawing.Size(141, 20);
            this.txtDefaultTare.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEFAULT TARE";
            // 
            // txtEgi
            // 
            this.txtEgi.Location = new System.Drawing.Point(15, 141);
            this.txtEgi.Name = "txtEgi";
            this.txtEgi.Size = new System.Drawing.Size(141, 20);
            this.txtEgi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EGI";
            // 
            // txtNoUnit
            // 
            this.txtNoUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNoUnit.Location = new System.Drawing.Point(13, 43);
            this.txtNoUnit.Name = "txtNoUnit";
            this.txtNoUnit.Size = new System.Drawing.Size(143, 20);
            this.txtNoUnit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NO UNIT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.txtPage);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrev);
            this.panel4.Controls.Add(this.cbJmlData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(206, 481);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(711, 34);
            this.panel4.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(460, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(522, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(146, 4);
            this.txtPage.Margin = new System.Windows.Forms.Padding(4);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(63, 24);
            this.txtPage.TabIndex = 2;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Lavender;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(217, 1);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Lavender;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(90, 1);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(48, 28);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cbJmlData
            // 
            this.cbJmlData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJmlData.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJmlData.FormattingEnabled = true;
            this.cbJmlData.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "1000"});
            this.cbJmlData.Location = new System.Drawing.Point(18, 3);
            this.cbJmlData.Margin = new System.Windows.Forms.Padding(4);
            this.cbJmlData.Name = "cbJmlData";
            this.cbJmlData.Size = new System.Drawing.Size(65, 25);
            this.cbJmlData.TabIndex = 2;
            this.cbJmlData.Text = "100";
            this.cbJmlData.Click += new System.EventHandler(this.cbJmlData_TextChanged);
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AllowUserToAddRows = false;
            this.dgv_transaksi.AllowUserToDeleteRows = false;
            this.dgv_transaksi.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UNIT_NO,
            this.UNIT_ENTITY,
            this.UNIT_EGI,
            this.UNIT_KONTRAKTOR,
            this.UNIT_DEFAULT_TARE,
            this.UNIT_AKTIF});
            this.dgv_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transaksi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_transaksi.Location = new System.Drawing.Point(206, 43);
            this.dgv_transaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.ReadOnly = true;
            this.dgv_transaksi.RowTemplate.Height = 31;
            this.dgv_transaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transaksi.Size = new System.Drawing.Size(711, 438);
            this.dgv_transaksi.TabIndex = 7;
            this.dgv_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellDoubleClick);
            this.dgv_transaksi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_transaksi_KeyDown);
            // 
            // UNIT_NO
            // 
            this.UNIT_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UNIT_NO.DataPropertyName = "UNIT_NO";
            this.UNIT_NO.HeaderText = "NO UNIT";
            this.UNIT_NO.Name = "UNIT_NO";
            this.UNIT_NO.ReadOnly = true;
            // 
            // UNIT_ENTITY
            // 
            this.UNIT_ENTITY.DataPropertyName = "UNIT_ENTITY";
            this.UNIT_ENTITY.HeaderText = "ENTITY";
            this.UNIT_ENTITY.Name = "UNIT_ENTITY";
            this.UNIT_ENTITY.ReadOnly = true;
            // 
            // UNIT_EGI
            // 
            this.UNIT_EGI.DataPropertyName = "UNIT_EGI";
            this.UNIT_EGI.HeaderText = "EGI UNIT";
            this.UNIT_EGI.Name = "UNIT_EGI";
            this.UNIT_EGI.ReadOnly = true;
            // 
            // UNIT_KONTRAKTOR
            // 
            this.UNIT_KONTRAKTOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UNIT_KONTRAKTOR.DataPropertyName = "UNIT_KONTRAKTOR";
            this.UNIT_KONTRAKTOR.HeaderText = "KONTRAKTOR";
            this.UNIT_KONTRAKTOR.Name = "UNIT_KONTRAKTOR";
            this.UNIT_KONTRAKTOR.ReadOnly = true;
            // 
            // UNIT_DEFAULT_TARE
            // 
            this.UNIT_DEFAULT_TARE.DataPropertyName = "UNIT_DEFAULT_TARE";
            this.UNIT_DEFAULT_TARE.HeaderText = "TARE";
            this.UNIT_DEFAULT_TARE.Name = "UNIT_DEFAULT_TARE";
            this.UNIT_DEFAULT_TARE.ReadOnly = true;
            // 
            // UNIT_AKTIF
            // 
            this.UNIT_AKTIF.DataPropertyName = "UNIT_AKTIF";
            this.UNIT_AKTIF.HeaderText = "STATUS";
            this.UNIT_AKTIF.Name = "UNIT_AKTIF";
            this.UNIT_AKTIF.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.dgv_transaksi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbAktif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKontraktor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEntity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtDefaultTare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cbJmlData;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_ENTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_EGI;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_KONTRAKTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_DEFAULT_TARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_AKTIF;
    }
}
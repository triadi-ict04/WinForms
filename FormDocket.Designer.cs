namespace WinForms
{
    partial class FormDocket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.DOCKET_RAW_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_UNIT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_LOADER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_CPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_STOCKPILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCKET_TANGGAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cbJmlData = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AllowUserToAddRows = false;
            this.dgv_transaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_transaksi.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCKET_RAW_ID,
            this.DOCKET_UNIT_NO,
            this.DOCKET_PRODUCT,
            this.DOCKET_LOADER,
            this.DOCKET_CPP,
            this.DOCKET_STOCKPILE,
            this.DOCKET_TANGGAL});
            this.dgv_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transaksi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_transaksi.Location = new System.Drawing.Point(0, 0);
            this.dgv_transaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.ReadOnly = true;
            this.dgv_transaksi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transaksi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_transaksi.RowTemplate.Height = 31;
            this.dgv_transaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transaksi.Size = new System.Drawing.Size(800, 466);
            this.dgv_transaksi.TabIndex = 9;
            this.dgv_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellDoubleClick);
            // 
            // DOCKET_RAW_ID
            // 
            this.DOCKET_RAW_ID.DataPropertyName = "DOCKET_RAW_ID";
            this.DOCKET_RAW_ID.HeaderText = "DOCKET_RAW_ID";
            this.DOCKET_RAW_ID.Name = "DOCKET_RAW_ID";
            this.DOCKET_RAW_ID.ReadOnly = true;
            this.DOCKET_RAW_ID.Visible = false;
            // 
            // DOCKET_UNIT_NO
            // 
            this.DOCKET_UNIT_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_UNIT_NO.DataPropertyName = "DOCKET_UNIT_NO";
            this.DOCKET_UNIT_NO.HeaderText = "NO UNIT";
            this.DOCKET_UNIT_NO.Name = "DOCKET_UNIT_NO";
            this.DOCKET_UNIT_NO.ReadOnly = true;
            // 
            // DOCKET_PRODUCT
            // 
            this.DOCKET_PRODUCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_PRODUCT.DataPropertyName = "DOCKET_PRODUCT";
            this.DOCKET_PRODUCT.HeaderText = "PRODUCT";
            this.DOCKET_PRODUCT.Name = "DOCKET_PRODUCT";
            this.DOCKET_PRODUCT.ReadOnly = true;
            // 
            // DOCKET_LOADER
            // 
            this.DOCKET_LOADER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_LOADER.DataPropertyName = "DOCKET_LOADER";
            this.DOCKET_LOADER.HeaderText = "LOADER";
            this.DOCKET_LOADER.Name = "DOCKET_LOADER";
            this.DOCKET_LOADER.ReadOnly = true;
            // 
            // DOCKET_CPP
            // 
            this.DOCKET_CPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_CPP.DataPropertyName = "DOCKET_CPP";
            this.DOCKET_CPP.HeaderText = "CPP";
            this.DOCKET_CPP.Name = "DOCKET_CPP";
            this.DOCKET_CPP.ReadOnly = true;
            // 
            // DOCKET_STOCKPILE
            // 
            this.DOCKET_STOCKPILE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_STOCKPILE.DataPropertyName = "DOCKET_STOCKPILE";
            this.DOCKET_STOCKPILE.HeaderText = "STOCKPILE";
            this.DOCKET_STOCKPILE.Name = "DOCKET_STOCKPILE";
            this.DOCKET_STOCKPILE.ReadOnly = true;
            // 
            // DOCKET_TANGGAL
            // 
            this.DOCKET_TANGGAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOCKET_TANGGAL.DataPropertyName = "DOCKET_TANGGAL";
            this.DOCKET_TANGGAL.HeaderText = "TANGGAL";
            this.DOCKET_TANGGAL.Name = "DOCKET_TANGGAL";
            this.DOCKET_TANGGAL.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.txtPage);
            this.panel6.Controls.Add(this.btnNext);
            this.panel6.Controls.Add(this.btnPrev);
            this.panel6.Controls.Add(this.cbJmlData);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 503);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 34);
            this.panel6.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(549, 6);
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
            this.txtSearch.Location = new System.Drawing.Point(611, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.cbJmlData.TextChanged += new System.EventHandler(this.cbJmlData_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 37);
            this.panel5.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "LIST DOCKET";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_transaksi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 466);
            this.panel1.TabIndex = 12;
            // 
            // FormDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDocket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cbJmlData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_RAW_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_UNIT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_LOADER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_CPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_STOCKPILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCKET_TANGGAL;
    }
}
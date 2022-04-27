namespace WinForms
{
    partial class FormListTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListTransaksi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.dt_trans = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.cmb_jmlData = new System.Windows.Forms.ComboBox();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.tBL_R_UNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSJT18 = new WinForms.DSJT18();
            this.tBL_R_ENTITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_R_CPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_R_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_R_STOCKPILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_R_CPPTableAdapter = new WinForms.DSJT18TableAdapters.TBL_R_CPPTableAdapter();
            this.tBL_R_ENTITYTableAdapter = new WinForms.DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();
            this.tBL_R_PRODUCTTableAdapter = new WinForms.DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();
            this.tBL_R_STOCKPILETableAdapter = new WinForms.DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();
            this.tBL_R_UNITTableAdapter = new WinForms.DSJT18TableAdapters.TBL_R_UNITTableAdapter();
            this.TRANS_RAW_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_TGL_PRODUKSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_UNIT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TRANS_ENTITY = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TRANS_CPP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TRANS_PRODUCT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TRANS_LOADER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_STOCKPILE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TRANS_GROSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_TARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_NETTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_START_TIMBANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_UPDATE_AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_DOCKET_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANS_OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_UNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSJT18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_ENTITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_CPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_STOCKPILEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.dt_trans);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 36);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(758, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.Location = new System.Drawing.Point(679, 6);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dt_trans
            // 
            this.dt_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_trans.Location = new System.Drawing.Point(473, 8);
            this.dt_trans.Name = "dt_trans";
            this.dt_trans.Size = new System.Drawing.Size(200, 20);
            this.dt_trans.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI TARE UNIT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.txt_page);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.cmb_jmlData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 44);
            this.panel1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(554, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(616, 12);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(177, 22);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_page
            // 
            this.txt_page.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_page.Location = new System.Drawing.Point(146, 13);
            this.txt_page.Margin = new System.Windows.Forms.Padding(4);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(63, 24);
            this.txt_page.TabIndex = 2;
            this.txt_page.Text = "1";
            this.txt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Lavender;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(217, 10);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(48, 28);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Lavender;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Location = new System.Drawing.Point(90, 10);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(48, 28);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // cmb_jmlData
            // 
            this.cmb_jmlData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_jmlData.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_jmlData.FormattingEnabled = true;
            this.cmb_jmlData.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "1000"});
            this.cmb_jmlData.Location = new System.Drawing.Point(18, 12);
            this.cmb_jmlData.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_jmlData.Name = "cmb_jmlData";
            this.cmb_jmlData.Size = new System.Drawing.Size(65, 25);
            this.cmb_jmlData.TabIndex = 2;
            this.cmb_jmlData.Text = "100";
            this.cmb_jmlData.TextChanged += new System.EventHandler(this.cmb_jmlData_TextChanged);
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AllowUserToAddRows = false;
            this.dgv_transaksi.AllowUserToDeleteRows = false;
            this.dgv_transaksi.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRANS_RAW_ID,
            this.TRANS_TGL_PRODUKSI,
            this.TRANS_UNIT,
            this.TRANS_ENTITY,
            this.TRANS_CPP,
            this.TRANS_PRODUCT,
            this.TRANS_LOADER,
            this.TRANS_STOCKPILE,
            this.TRANS_GROSS,
            this.TRANS_TARE,
            this.TRANS_NETTO,
            this.TRANS_START_TIMBANG,
            this.TRANS_DATETIME,
            this.TRANS_UPDATE_AT,
            this.TRANS_DOCKET_ID,
            this.TRANS_OPERATOR});
            this.dgv_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transaksi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_transaksi.Location = new System.Drawing.Point(0, 36);
            this.dgv_transaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.RowTemplate.Height = 31;
            this.dgv_transaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_transaksi.Size = new System.Drawing.Size(805, 613);
            this.dgv_transaksi.TabIndex = 8;
            this.dgv_transaksi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellValueChanged);
            this.dgv_transaksi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_transaksi_DataError);
            this.dgv_transaksi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_transaksi_EditingControlShowing);
            this.dgv_transaksi.RowHeightInfoPushed += new System.Windows.Forms.DataGridViewRowHeightInfoPushedEventHandler(this.dgv_transaksi_RowHeightInfoPushed);
            this.dgv_transaksi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_transaksi_KeyDown);
            // 
            // tBL_R_UNITBindingSource
            // 
            this.tBL_R_UNITBindingSource.DataMember = "TBL_R_UNIT";
            this.tBL_R_UNITBindingSource.DataSource = this.dSJT18;
            // 
            // dSJT18
            // 
            this.dSJT18.DataSetName = "DSJT18";
            this.dSJT18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_R_ENTITYBindingSource
            // 
            this.tBL_R_ENTITYBindingSource.DataMember = "TBL_R_ENTITY";
            this.tBL_R_ENTITYBindingSource.DataSource = this.dSJT18;
            // 
            // tBL_R_CPPBindingSource
            // 
            this.tBL_R_CPPBindingSource.DataMember = "TBL_R_CPP";
            this.tBL_R_CPPBindingSource.DataSource = this.dSJT18;
            // 
            // tBL_R_PRODUCTBindingSource
            // 
            this.tBL_R_PRODUCTBindingSource.DataMember = "TBL_R_PRODUCT";
            this.tBL_R_PRODUCTBindingSource.DataSource = this.dSJT18;
            // 
            // tBL_R_STOCKPILEBindingSource
            // 
            this.tBL_R_STOCKPILEBindingSource.DataMember = "TBL_R_STOCKPILE";
            this.tBL_R_STOCKPILEBindingSource.DataSource = this.dSJT18;
            // 
            // tBL_R_CPPTableAdapter
            // 
            this.tBL_R_CPPTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_R_ENTITYTableAdapter
            // 
            this.tBL_R_ENTITYTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_R_PRODUCTTableAdapter
            // 
            this.tBL_R_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_R_STOCKPILETableAdapter
            // 
            this.tBL_R_STOCKPILETableAdapter.ClearBeforeFill = true;
            // 
            // tBL_R_UNITTableAdapter
            // 
            this.tBL_R_UNITTableAdapter.ClearBeforeFill = true;
            // 
            // TRANS_RAW_ID
            // 
            this.TRANS_RAW_ID.DataPropertyName = "TRANS_RAW_ID";
            this.TRANS_RAW_ID.HeaderText = "RAW ID";
            this.TRANS_RAW_ID.Name = "TRANS_RAW_ID";
            this.TRANS_RAW_ID.Visible = false;
            // 
            // TRANS_TGL_PRODUKSI
            // 
            this.TRANS_TGL_PRODUKSI.DataPropertyName = "TRANS_TGL_PRODUKSI";
            this.TRANS_TGL_PRODUKSI.HeaderText = "TGL PRODUKSI";
            this.TRANS_TGL_PRODUKSI.Name = "TRANS_TGL_PRODUKSI";
            this.TRANS_TGL_PRODUKSI.Visible = false;
            // 
            // TRANS_UNIT
            // 
            this.TRANS_UNIT.DataPropertyName = "TRANS_UNIT";
            this.TRANS_UNIT.DataSource = this.tBL_R_UNITBindingSource;
            this.TRANS_UNIT.DisplayMember = "UNIT_NO";
            this.TRANS_UNIT.HeaderText = "NO UNIT";
            this.TRANS_UNIT.Name = "TRANS_UNIT";
            this.TRANS_UNIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TRANS_UNIT.ValueMember = "UNIT_NO";
            // 
            // TRANS_ENTITY
            // 
            this.TRANS_ENTITY.DataPropertyName = "TRANS_ENTITY";
            this.TRANS_ENTITY.DataSource = this.tBL_R_ENTITYBindingSource;
            this.TRANS_ENTITY.DisplayMember = "ENTITY_CODE";
            this.TRANS_ENTITY.HeaderText = "ENTITY";
            this.TRANS_ENTITY.Name = "TRANS_ENTITY";
            this.TRANS_ENTITY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TRANS_ENTITY.ValueMember = "ENTITY_CODE";
            // 
            // TRANS_CPP
            // 
            this.TRANS_CPP.DataPropertyName = "TRANS_CPP";
            this.TRANS_CPP.DataSource = this.tBL_R_CPPBindingSource;
            this.TRANS_CPP.DisplayMember = "CPP_CODE";
            this.TRANS_CPP.HeaderText = "SUMBER";
            this.TRANS_CPP.Name = "TRANS_CPP";
            this.TRANS_CPP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TRANS_CPP.ValueMember = "CPP_CODE";
            // 
            // TRANS_PRODUCT
            // 
            this.TRANS_PRODUCT.DataPropertyName = "TRANS_PRODUCT";
            this.TRANS_PRODUCT.DataSource = this.tBL_R_PRODUCTBindingSource;
            this.TRANS_PRODUCT.DisplayMember = "PRODUCT_NAME";
            this.TRANS_PRODUCT.HeaderText = "PRODUCT";
            this.TRANS_PRODUCT.Name = "TRANS_PRODUCT";
            this.TRANS_PRODUCT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TRANS_PRODUCT.ValueMember = "PRODUCT_CODE";
            // 
            // TRANS_LOADER
            // 
            this.TRANS_LOADER.DataPropertyName = "TRANS_LOADER";
            this.TRANS_LOADER.HeaderText = "LOADER";
            this.TRANS_LOADER.Name = "TRANS_LOADER";
            // 
            // TRANS_STOCKPILE
            // 
            this.TRANS_STOCKPILE.DataPropertyName = "TRANS_STOCKPILE";
            this.TRANS_STOCKPILE.DataSource = this.tBL_R_STOCKPILEBindingSource;
            this.TRANS_STOCKPILE.DisplayMember = "STOCKPILE_LOKASI";
            this.TRANS_STOCKPILE.HeaderText = "STOCKPILE";
            this.TRANS_STOCKPILE.Name = "TRANS_STOCKPILE";
            this.TRANS_STOCKPILE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TRANS_STOCKPILE.ValueMember = "STOCKPILE_CODE";
            // 
            // TRANS_GROSS
            // 
            this.TRANS_GROSS.DataPropertyName = "TRANS_GROSS";
            this.TRANS_GROSS.HeaderText = "GROSS";
            this.TRANS_GROSS.Name = "TRANS_GROSS";
            // 
            // TRANS_TARE
            // 
            this.TRANS_TARE.DataPropertyName = "TRANS_TARE";
            this.TRANS_TARE.HeaderText = "TARE";
            this.TRANS_TARE.Name = "TRANS_TARE";
            this.TRANS_TARE.ReadOnly = true;
            // 
            // TRANS_NETTO
            // 
            this.TRANS_NETTO.DataPropertyName = "TRANS_NETTO";
            this.TRANS_NETTO.HeaderText = "NETTO";
            this.TRANS_NETTO.Name = "TRANS_NETTO";
            this.TRANS_NETTO.Visible = false;
            // 
            // TRANS_START_TIMBANG
            // 
            this.TRANS_START_TIMBANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANS_START_TIMBANG.DataPropertyName = "TRANS_START_TIMBANG";
            this.TRANS_START_TIMBANG.HeaderText = "JAM TIMBANG";
            this.TRANS_START_TIMBANG.Name = "TRANS_START_TIMBANG";
            this.TRANS_START_TIMBANG.ReadOnly = true;
            // 
            // TRANS_DATETIME
            // 
            this.TRANS_DATETIME.DataPropertyName = "TRANS_DATETIME";
            this.TRANS_DATETIME.HeaderText = "DATETIME";
            this.TRANS_DATETIME.Name = "TRANS_DATETIME";
            this.TRANS_DATETIME.Visible = false;
            // 
            // TRANS_UPDATE_AT
            // 
            this.TRANS_UPDATE_AT.DataPropertyName = "TRANS_UPDATE_AT";
            this.TRANS_UPDATE_AT.HeaderText = "UPDATE AT";
            this.TRANS_UPDATE_AT.Name = "TRANS_UPDATE_AT";
            this.TRANS_UPDATE_AT.Visible = false;
            // 
            // TRANS_DOCKET_ID
            // 
            this.TRANS_DOCKET_ID.DataPropertyName = "TRANS_DOCKET_ID";
            this.TRANS_DOCKET_ID.HeaderText = "DOCKET ID";
            this.TRANS_DOCKET_ID.Name = "TRANS_DOCKET_ID";
            this.TRANS_DOCKET_ID.Visible = false;
            // 
            // TRANS_OPERATOR
            // 
            this.TRANS_OPERATOR.DataPropertyName = "TRANS_OPERATOR";
            this.TRANS_OPERATOR.HeaderText = "OPERATOR";
            this.TRANS_OPERATOR.Name = "TRANS_OPERATOR";
            this.TRANS_OPERATOR.Visible = false;
            // 
            // FormListTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 693);
            this.Controls.Add(this.dgv_transaksi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListTransaksi";
            this.Text = "FormListTransaksi";
            this.Load += new System.EventHandler(this.FormListTransaksi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_UNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSJT18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_ENTITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_CPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_R_STOCKPILEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker dt_trans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_page;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.ComboBox cmb_jmlData;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private DSJT18 dSJT18;
        private System.Windows.Forms.BindingSource tBL_R_CPPBindingSource;
        private DSJT18TableAdapters.TBL_R_CPPTableAdapter tBL_R_CPPTableAdapter;
        private System.Windows.Forms.BindingSource tBL_R_ENTITYBindingSource;
        private DSJT18TableAdapters.TBL_R_ENTITYTableAdapter tBL_R_ENTITYTableAdapter;
        private System.Windows.Forms.BindingSource tBL_R_PRODUCTBindingSource;
        private DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter tBL_R_PRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource tBL_R_STOCKPILEBindingSource;
        private DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter tBL_R_STOCKPILETableAdapter;
        private System.Windows.Forms.BindingSource tBL_R_UNITBindingSource;
        private DSJT18TableAdapters.TBL_R_UNITTableAdapter tBL_R_UNITTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_RAW_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_TGL_PRODUKSI;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANS_UNIT;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANS_ENTITY;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANS_CPP;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANS_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_LOADER;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANS_STOCKPILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_GROSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_TARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_NETTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_START_TIMBANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_DATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_UPDATE_AT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_DOCKET_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANS_OPERATOR;
    }
}
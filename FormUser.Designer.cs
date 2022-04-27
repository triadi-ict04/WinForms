namespace WinForms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_raw_id = new System.Windows.Forms.Label();
            this.cmb_akses = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.USER_RAW_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_COMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_AKSES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKSES_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.cmb_jmlData = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 38);
            this.panel1.TabIndex = 4;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(866, 6);
            this.button13.Margin = new System.Windows.Forms.Padding(6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(29, 27);
            this.button13.TabIndex = 9;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "LIST USER";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.2776F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 477F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 438);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_raw_id);
            this.panel2.Controls.Add(this.cmb_akses);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.txt_company);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 432);
            this.panel2.TabIndex = 0;
            // 
            // lbl_raw_id
            // 
            this.lbl_raw_id.AutoSize = true;
            this.lbl_raw_id.Location = new System.Drawing.Point(13, 406);
            this.lbl_raw_id.Name = "lbl_raw_id";
            this.lbl_raw_id.Size = new System.Drawing.Size(35, 13);
            this.lbl_raw_id.TabIndex = 11;
            this.lbl_raw_id.Text = "label7";
            // 
            // cmb_akses
            // 
            this.cmb_akses.FormattingEnabled = true;
            this.cmb_akses.Location = new System.Drawing.Point(15, 101);
            this.cmb_akses.Name = "cmb_akses";
            this.cmb_akses.Size = new System.Drawing.Size(138, 21);
            this.cmb_akses.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(15, 293);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.Size = new System.Drawing.Size(117, 20);
            this.txt_password.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(15, 229);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(117, 20);
            this.txt_username.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(111, 344);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 31);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Navy;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(15, 344);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(15, 165);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(171, 20);
            this.txt_company.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Akses";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_name.Location = new System.Drawing.Point(13, 43);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(117, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_transaksi);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 432);
            this.panel3.TabIndex = 1;
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AllowUserToAddRows = false;
            this.dgv_transaksi.AllowUserToDeleteRows = false;
            this.dgv_transaksi.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_RAW_ID,
            this.USER_NAME,
            this.USER_COMPANY,
            this.USER_AKSES,
            this.AKSES_NAME,
            this.USER_USERNAME,
            this.USER_PASSWORD});
            this.dgv_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transaksi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_transaksi.Location = new System.Drawing.Point(0, 0);
            this.dgv_transaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.ReadOnly = true;
            this.dgv_transaksi.RowTemplate.Height = 31;
            this.dgv_transaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transaksi.Size = new System.Drawing.Size(691, 398);
            this.dgv_transaksi.TabIndex = 4;
            this.dgv_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellDoubleClick);
            this.dgv_transaksi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_transaksi_KeyDown);
            // 
            // USER_RAW_ID
            // 
            this.USER_RAW_ID.DataPropertyName = "USER_RAW_ID";
            this.USER_RAW_ID.HeaderText = "USER_RAW_ID";
            this.USER_RAW_ID.Name = "USER_RAW_ID";
            this.USER_RAW_ID.ReadOnly = true;
            this.USER_RAW_ID.Visible = false;
            // 
            // USER_NAME
            // 
            this.USER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "NAMA USER";
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            // 
            // USER_COMPANY
            // 
            this.USER_COMPANY.DataPropertyName = "USER_COMPANY";
            this.USER_COMPANY.HeaderText = "COMPANY";
            this.USER_COMPANY.Name = "USER_COMPANY";
            this.USER_COMPANY.ReadOnly = true;
            // 
            // USER_AKSES
            // 
            this.USER_AKSES.DataPropertyName = "USER_AKSES";
            this.USER_AKSES.HeaderText = "USER_AKSES";
            this.USER_AKSES.Name = "USER_AKSES";
            this.USER_AKSES.ReadOnly = true;
            this.USER_AKSES.Visible = false;
            // 
            // AKSES_NAME
            // 
            this.AKSES_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKSES_NAME.DataPropertyName = "AKSES_NAME";
            this.AKSES_NAME.HeaderText = "AKSES";
            this.AKSES_NAME.Name = "AKSES_NAME";
            this.AKSES_NAME.ReadOnly = true;
            // 
            // USER_USERNAME
            // 
            this.USER_USERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_USERNAME.DataPropertyName = "USER_USERNAME";
            this.USER_USERNAME.HeaderText = "USERNAME";
            this.USER_USERNAME.Name = "USER_USERNAME";
            this.USER_USERNAME.ReadOnly = true;
            // 
            // USER_PASSWORD
            // 
            this.USER_PASSWORD.DataPropertyName = "USER_PASSWORD";
            this.USER_PASSWORD.HeaderText = "USER_PASSWORD";
            this.USER_PASSWORD.Name = "USER_PASSWORD";
            this.USER_PASSWORD.ReadOnly = true;
            this.USER_PASSWORD.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Controls.Add(this.txt_page);
            this.panel4.Controls.Add(this.btn_next);
            this.panel4.Controls.Add(this.btn_prev);
            this.panel4.Controls.Add(this.cmb_jmlData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 398);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 34);
            this.panel4.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(440, 6);
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
            this.txt_search.Location = new System.Drawing.Point(502, 3);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(177, 22);
            this.txt_search.TabIndex = 4;
            this.txt_search.Click += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_page
            // 
            this.txt_page.Font = new System.Drawing.Font("Century Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_page.Location = new System.Drawing.Point(146, 4);
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
            this.btn_next.Location = new System.Drawing.Point(217, 1);
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
            this.btn_prev.Location = new System.Drawing.Point(90, 1);
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
            this.cmb_jmlData.Location = new System.Drawing.Point(18, 3);
            this.cmb_jmlData.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_jmlData.Name = "cmb_jmlData";
            this.cmb_jmlData.Size = new System.Drawing.Size(65, 25);
            this.cmb_jmlData.TabIndex = 2;
            this.cmb_jmlData.Text = "100";
            this.cmb_jmlData.TextChanged += new System.EventHandler(this.cmb_jmlData_TextChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_raw_id;
        private System.Windows.Forms.ComboBox cmb_akses;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_RAW_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_COMPANY;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_AKSES;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKSES_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_PASSWORD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_page;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.ComboBox cmb_jmlData;
    }
}
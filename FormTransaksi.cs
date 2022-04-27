using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;

namespace WinForms
{
    public partial class FormTransaksi : Form
    {
        private LTSJT18DataContext p_ctxdb = new LTSJT18DataContext();

        public static SerialPort port;
        string comname = Properties.Settings.Default["ComName"].ToString();

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        public string soutput;
        StringBuilder builder = new StringBuilder(30);
        string statForm = "1";
        int stat_timbang = 0;
        public FormTransaksi()
        {
            this.myDelegate = new AddDataDelegate(setTextTimbangan);

            InitializeComponent();

            pv_sub_call_load_data();
            pv_cust_loadUnit();
            pv_cust_loadEntity();
            pv_cust_loadCPP();
            pv_cust_loadProduct();
            pv_cust_loadStockpile();

            timer1.Start();

            openCom();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_jamtimbang.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #region paging load data
        private void load_data_grid(string s_str_table_name, string s_str_filter,
                                    string s_str_sort, int s_int_page_size,
                                    int s_int_page_index)
        {


            DSJT18TableAdapters.VW_T_REVIEW_TARETableAdapter i_tadap_data = new DSJT18TableAdapters.VW_T_REVIEW_TARETableAdapter();
            DSJT18.VW_T_REVIEW_TAREDataTable i_dtab_data = new DSJT18.VW_T_REVIEW_TAREDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            string i_filter = "";
            if (s_str_filter.Trim().Length > 0)
            {
                i_filter = "UNIT_NO LIKE '%" + s_str_filter + "%' OR UNIT_ENTITY LIKE '%" + s_str_filter + "%' ";
            }

            i_drow_data = i_tadap_data.GetData().Select("" + i_filter + "", " UNIT_NO ASC ");


            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            dgv_transaksi.DataSource = i_dset_data.Tables[0];



            for (int i = 0; i < dgv_transaksi.ColumnCount; i++)
            {
                dgv_transaksi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void pv_sub_call_load_data()
        {
            //var i_str_filter = "";

            //if (txt_search.Text.Length > 0)
            //{
            //    i_str_filter = " TRANS_DOCKET_NO LIKE '%" + txt_search.Text + "%' OR TRANS_COAL_NUMBER LIKE '%" + txt_search.Text + "%' OR TRANS_PIT LIKE '%" + txt_search.Text + "%'" +
            //                 " OR TRANS_SEAM LIKE '%" + txt_search.Text + "%' OR TRANS_RAW LIKE '%" + txt_search.Text + "%' OR TRANS_EXCAVATOR LIKE '%" + txt_search.Text + "%'" +
            //                 " OR TRANS_DESTINATION LIKE '%" + txt_search.Text + "%' OR TRANS_CONDITION LIKE '%" + txt_search.Text + "%'";


            //}

            try
            {
                load_data_grid("TBL_T_TRANSAKSI_18", txtSearch.Text, "TRANS_DATETIME DESC", 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex.Message.ToString());
            }


        }

        #endregion

        #region implement

        private void pv_cust_loadStockpile()
        {
            DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();
            DSJT18.TBL_R_STOCKPILEDataTable i_dtab_data = new DSJT18.TBL_R_STOCKPILEDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "STOCKPILE_NAME ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["STOCKPILE_NAME"].ToString());
            }


            cbStockpile.DataSource = i_dset_data.Tables[0];
            cbStockpile.ValueMember = i_dset_data.Tables[0].Columns["STOCKPILE_CODE"].ColumnName.ToString();
            cbStockpile.DisplayMember = i_dset_data.Tables[0].Columns["STOCKPILE_NAME"].ColumnName.ToString();

            cbStockpile.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbStockpile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbStockpile.AutoCompleteCustomSource = auto;
           
        }

        private void pv_cust_loadProduct()
        {
            DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();
            DSJT18.TBL_R_PRODUCTDataTable i_dtab_data = new DSJT18.TBL_R_PRODUCTDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "PRODUCT_NAME ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["PRODUCT_NAME"].ToString());
            }


            cbProduct.DataSource = i_dset_data.Tables[0];
            cbProduct.ValueMember = i_dset_data.Tables[0].Columns["PRODUCT_CODE"].ColumnName.ToString();
            cbProduct.DisplayMember = i_dset_data.Tables[0].Columns["PRODUCT_NAME"].ColumnName.ToString();

            cbProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProduct.AutoCompleteCustomSource = auto;
            
        }

        private void pv_cust_loadCPP()
        {
            DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();
            DSJT18.TBL_R_CPPDataTable i_dtab_data = new DSJT18.TBL_R_CPPDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "CPP_ENTITY ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["CPP_ENTITY"].ToString());
            }


            cbSumber.DataSource = i_dset_data.Tables[0];
            cbSumber.ValueMember = i_dset_data.Tables[0].Columns["CPP_CODE"].ColumnName.ToString();
            cbSumber.DisplayMember = i_dset_data.Tables[0].Columns["CPP_ENTITY"].ColumnName.ToString();

            cbSumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbSumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSumber.AutoCompleteCustomSource = auto;

        }

        private void pv_cust_loadEntity()
        {
            DSJT18TableAdapters.TBL_R_ENTITYTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();
            DSJT18.TBL_R_ENTITYDataTable i_dtab_data = new DSJT18.TBL_R_ENTITYDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_NAME ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["ENTITY_NAME"].ToString());
            }

            cbEntity.DataSource = i_dset_data.Tables[0];
            cbEntity.ValueMember = i_dset_data.Tables[0].Columns["ENTITY_CODE"].ColumnName.ToString();
            cbEntity.DisplayMember = i_dset_data.Tables[0].Columns["ENTITY_NAME"].ColumnName.ToString();

            cbEntity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEntity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEntity.AutoCompleteCustomSource = auto;

        }

        private void pv_cust_loadUnit()
        {
            DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();
            DSJT18.TBL_R_UNITDataTable i_dtab_data = new DSJT18.TBL_R_UNITDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "UNIT_NO ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["UNIT_NO"].ToString());
            }

            cbUnit.DataSource = i_dset_data.Tables[0];
            cbUnit.ValueMember = i_dset_data.Tables[0].Columns["UNIT_NO"].ColumnName.ToString();
            cbUnit.DisplayMember = i_dset_data.Tables[0].Columns["UNIT_NO"].ColumnName.ToString();

            cbUnit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUnit.AutoCompleteCustomSource = auto;


            cbUnitTare.DataSource = i_dset_data.Tables[0];
            cbUnitTare.ValueMember = i_dset_data.Tables[0].Columns["UNIT_NO"].ColumnName.ToString();
            cbUnitTare.DisplayMember = i_dset_data.Tables[0].Columns["UNIT_NO"].ColumnName.ToString();

            cbUnitTare.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbUnitTare.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUnitTare.AutoCompleteCustomSource = auto;
        }

        private void openCom()
        {
            try
            {
                //txt_blok.Text = comname;

                port = new SerialPort("" + comname, 9600, Parity.None, 8, StopBits.One);

                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

                if (!port.IsOpen)
                {
                    port.Open();
                }
                else
                {
                    MessageBox.Show("Port Sedang digunakan !!!");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Opening Port (Restart Aplication): " + Ex.Message.ToString());
            }
        }
        private void closeCom()
        {
            try
            {

                port.Dispose();
                port.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Close Port : " + Ex.Message.ToString());
            }
        }
        private void cekStartTImabang(string s_nilai)
        {
            try
            {
                if (s_nilai.Length > 10)
                {
                    return;
                }
                int nilai = Convert.ToInt32(s_nilai);

                if (nilai > Convert.ToInt32(Properties.Settings.Default["nilai"].ToString()))
                {

                    if (stat_timbang == 0)
                    {
                        stat_timbang = 1;
                        lbl_starttimbang.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                else
                {
                    lbl_starttimbang.Text = "Belum mulai menimbang";
                    stat_timbang = 0;
                }
            }
            catch (Exception ex)
            {
                lbl_starttimbang.Text = s_nilai + "--" + ex.Message.ToString();
            }

        }

        private void ConsoleReadCOM()
        {
            //Console.WriteLine("Incoming Data:");
            // Attach a method to be called when there
            // is data waiting in the port's buffer 
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            // Begin communications 

            if (!port.IsOpen)
            {
                port.Open();

            }
            else
            {
                port.Close();
                port.Dispose();


                port.Open();
                //label1.Text = "Port Opened";
            }

            if (port.IsOpen)
            {
                btn_cekport.Enabled = false;
            }
            else
            {
                btn_cekport.Enabled = true;
            }

            // Enter an application loop to keep this thread alive 
            Console.ReadLine();


        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                // Show all the incoming data in the port's buffer
                //Console.WriteLine(port.ReadExisting());

                //lbl_tonange.Text = "" + port.ReadExisting();


                //SerialPort sp = (SerialPort)sender;
                string indata = port.ReadExisting();

                //lbl_tonange.Invoke(this.myDelegate, new Object[] { indata });

                txtGross.BeginInvoke(this.myDelegate, indata);
                // lbl_tare.BeginInvoke(this.myDelegate, indata);

            }
            catch (Exception ex)
            {

            }
        }
        public void setTextTimbangan(String myString)
        {

            //if (myString == " ")
            //{
            //    return;
            //}

            builder.Append(myString);

            string output = "";



            // if (builder.ToString().ToUpper().Contains(Environment.NewLine))
            if (builder.ToString().ToUpper().Contains("KG"))
            {
                output = builder.ToString().ToUpper().Replace("KG", "").Trim();
                txtGross.Text = "0";
                lbl_tare.Text = "0";

                //txt_trial.AppendText(output);


                if (output.Length >= 7)
                {
                    int n;
                    bool isNumeric = int.TryParse(output.ToString().Substring((output.Length - 7), 7), out n);



                    if (isNumeric)
                    {
                        txtGross.Text = n.ToString();
                        lbl_tare.Text = n.ToString();
                        cekStartTImabang(n.ToString());
                    }
                }


                builder.Clear();
            }

        }

        #endregion

        private void btn_cekport_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                openCom();
            }
            else
            {
                MessageBox.Show("Port open at " + port.PortName.ToString());
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbUnit.Text.ToString().Trim().Length == 0 ||
                cbEntity.Text.ToString().Trim().Length == 0 ||
                cbSumber.Text.ToString().Trim().Length == 0 ||
                cbProduct.Text.ToString().Trim().Length == 0 ||
                txtLoader.Text.ToString().Trim().Length == 0 ||
                cbStockpile.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Pastikan semua form isian telah diisi dengan benar");
            }
            else if (lbl_starttimbang.Text.Contains("Belum mulai menimbang"))
            {
                MessageBox.Show("Pastikan Penimbangan sudah dimulai");
            }
            else
            {
                try
                {
                    DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter i_tadap = new DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter();

                    string i_guid = Guid.NewGuid().ToString();
                    //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form2"];

                    i_tadap.Insert_trans(
                        //cbUnit.SelectedValue.ToString(),
                        cbUnit.Text.ToString().ToUpper(),
                        cbEntity.SelectedValue.ToString(),
                        cbSumber.SelectedValue.ToString(),
                        cbProduct.SelectedValue.ToString(),
                        cbStockpile.SelectedValue.ToString(),
                        txtLoader.Text.ToString().ToUpper(),
                        Convert.ToInt32(txtGross.Text),
                        Convert.ToInt32(txtTare.Text),
                        Convert.ToDateTime(lbl_jamtimbang.Text),
                        "TR",
                        i_guid,
                        Convert.ToDateTime(lbl_starttimbang.Text)

                        //Convert.ToInt32(txtGross.Text) - Convert.ToInt32(txtTare.Text),
                        //Properties.Settings.Default["Code"].ToString(),
                        );



                    //foreach (Form form in Application.OpenForms)
                    //{
                    //    if (form.GetType() == typeof(Frm_print))
                    //    {
                    //        form.Close();                            
                    //    }
                    //}


                    //System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["Frm_print"];

                    //if (pr != null)
                    //{
                    //    pr.Close();
                    //}



                    MessageBox.Show("Insert data berhasil");

                    //FormPrint print = new FormPrint(i_guid);

                    //print.Show();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Insert data : \n " + ex.Message.ToString());
                }
            }
        }

        private void btnSimpanTare_Click(object sender, EventArgs e)
        {
            try
            {
                DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter i_tadap = new DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter();

                i_tadap.Insert_tare(cbUnitTare.Text.ToString().ToUpper(), Convert.ToInt32(lbl_tare.Text));

                MessageBox.Show("Input tare berhasil");

                //pv_sub_call_load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error input tare : \n" + ex.Message.ToString());
            }
        }

        private void cbUnit_Leave(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter();

            var tare = i_tadap_data.GET_TARE_UNIT(cbUnit.Text);

            txtTare.Text = tare.ToString();
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_T_TARE_UNITTableAdapter();

            var tare = i_tadap_data.GET_TARE_UNIT(cbUnit.Text);
            int gross = Convert.ToInt32(txtGross.Text);

            txtTare.Text = tare.ToString();
            txtNetto.Text = (gross - tare).ToString();
        }

    }
}

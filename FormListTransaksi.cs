using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormListTransaksi : Form
    {
        private LTSJT18DataContext p_ctxdb = new LTSJT18DataContext();
        public FormListTransaksi()
        {
            InitializeComponent();
        }

        private void FormListTransaksi_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'dSJT18.TBL_R_UNIT' table. You can move, or remove it, as needed.
            this.tBL_R_UNITTableAdapter.Fill(this.dSJT18.TBL_R_UNIT);
            // TODO: This line of code loads data into the 'dSJT18.TBL_R_STOCKPILE' table. You can move, or remove it, as needed.
            this.tBL_R_STOCKPILETableAdapter.Fill(this.dSJT18.TBL_R_STOCKPILE);
            // TODO: This line of code loads data into the 'dSJT18.TBL_R_PRODUCT' table. You can move, or remove it, as needed.
            this.tBL_R_PRODUCTTableAdapter.Fill(this.dSJT18.TBL_R_PRODUCT);
            // TODO: This line of code loads data into the 'dSJT18.TBL_R_ENTITY' table. You can move, or remove it, as needed.
            this.tBL_R_ENTITYTableAdapter.Fill(this.dSJT18.TBL_R_ENTITY);
            // TODO: This line of code loads data into the 'dSJT18.TBL_R_CPP' table. You can move, or remove it, as needed.
            this.tBL_R_CPPTableAdapter.Fill(this.dSJT18.TBL_R_CPP);

            dt_trans.Format = DateTimePickerFormat.Custom;
            dt_trans.CustomFormat = "yyyy-MM-dd";
            //dt_trans.MinDate = DateTime.Now.AddDays(-2);
            //dt_trans.MaxDate = DateTime.Now;

        }
        #region paging

        #region paging load data


        private void load_data_grid(string s_str_table_name, string s_str_filter,
                                    string s_str_sort, int s_int_page_size,
                                    int s_int_page_index)
        {


            DSJT18TableAdapters.VW_T_TRANSAKSITableAdapter i_tadap_data = new DSJT18TableAdapters.VW_T_TRANSAKSITableAdapter();
            DSJT18.VW_T_TRANSAKSIDataTable i_dtab_data = new DSJT18.VW_T_TRANSAKSIDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.PagingData(s_str_table_name, s_str_filter, s_str_sort, s_int_page_size, s_int_page_index).Select();

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);


            var col = i_dset_data.Tables[0];


            ////col.Columns["TRANS_RAW_ID"].ColumnMapping = MappingType.Hidden;

            //for (int i=0; i<col.Columns.Count; i++ )
            //{
            //    col.Columns[i].ColumnMapping = MappingType.Hidden;
            //}


            dgv_transaksi.DataSource = col;


            foreach (DataGridViewColumn coll in dgv_transaksi.Columns)
                if (coll.ReadOnly)
                {
                    coll.DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    coll.DefaultCellStyle.BackColor = Color.White;
                }
        }

        private void pv_sub_call_load_data()
        {
            var i_str_filter = "TRANS_TGL_PRODUKSI = '" + dt_trans.Text.Replace("-", "") + "' ";
            //var i_str_filter = "";

            if (txt_search.Text.Length > 0)
            {
                i_str_filter = " AND (TRANS_ENTITY LIKE '%" + txt_search.Text + "%' OR TRANS_CPP LIKE '%" + txt_search.Text + "%' OR TRANS_PRODUCT LIKE '%" + txt_search.Text + "%'" +
                             " OR TRANS_STOCKPILE LIKE '%" + txt_search.Text + "%' OR TRANS_LOADER LIKE '%" + txt_search.Text + "%' )";
            }

            try
            {
                load_data_grid("VW_T_TRANSAKSI", i_str_filter, "TRANS_DATETIME DESC", int.Parse(cmb_jmlData.Text), int.Parse(txt_page.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex.Message.ToString() + " -- " + i_str_filter);
            }
        }
        #endregion

        #region paging event handler

        private void btn_next_Click(object sender, EventArgs e)
        {
            int i_int_page = int.Parse(txt_page.Text);

            txt_page.Text = "" + (i_int_page + 1);

            pv_sub_call_load_data();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int i_int_page = int.Parse(txt_page.Text);

            txt_page.Text = "" + (i_int_page - 1);

            pv_sub_call_load_data();
        }

        private void cmb_jmlData_TextChanged(object sender, EventArgs e)
        {
            pv_sub_call_load_data();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            pv_sub_call_load_data();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            pv_sub_call_load_data();
        }

        #endregion

        #endregion


        private void dgv_transaksi_RowHeightInfoPushed(object sender, DataGridViewRowHeightInfoPushedEventArgs e)
        {

        }

        private void dgv_transaksi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_transaksi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // PIT_NAME.se
        }

        private void dgv_transaksi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter i_tadap = new DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter();

            try
            {
                DataGridViewRow row = dgv_transaksi.CurrentRow;
                if (row != null)
                {
                    i_tadap.CUSP_UPDATE_TRANSAKSI(row.Cells["TRANS_RAW_ID"].Value.ToString(),
                                                  row.Cells["TRANS_UNIT"].Value.ToString(),
                                                  row.Cells["TRANS_ENTITY"].Value.ToString(),
                                                  row.Cells["TRANS_CPP"].Value.ToString(),
                                                  row.Cells["TRANS_PRODUCT"].Value.ToString(),
                                                  row.Cells["TRANS_STOCKPILE"].Value.ToString(),
                                                  row.Cells["TRANS_LOADER"].Value.ToString(),
                                                  Convert.ToInt32(row.Cells["TRANS_GROSS"].Value.ToString()),
                                                  //Convert.ToInt32(row.Cells["TRANS_TARE"].Value.ToString()),
                                                  Convert.ToDateTime(row.Cells["TRANS_UPDATE_AT"].Value.ToString()),
                                                  Convert.ToDateTime(row.Cells["TRANS_START_TIMBANG"].Value.ToString()),
                                                  Convert.ToDateTime(row.Cells["TRANS_DATETIME"].Value.ToString()),
                                                  row.Cells["TRANS_OPERATOR"].Value.ToString()
                                                  );
                    //pv_sub_call_load_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing data : \n" + ex.Message.ToString());
            }
        }

        private void dgv_transaksi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                //System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["Frm_print"];

                //if (pr != null)
                //{
                //    pr.Close();
                //}

                MessageBox.Show("Insert data berhasil");

                //Frm_print print = new Frm_print(dgv_transaksi.CurrentRow.Cells["TRANS_RAW_ID"].Value.ToString());

                //print.Show();
            }
            else if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Yakin Menghapus data ini", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter i_tadap = new DSJT18TableAdapters.TBL_T_TRANSAKSI_18TableAdapter();

                        i_tadap.DeleteTransaksi(dgv_transaksi.CurrentRow.Cells["TRANS_RAW_ID"].Value.ToString());

                        pv_sub_call_load_data();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormPrintListTransaksi"];

            if (pr != null)
            {
                pr.Close();
            }

            MessageBox.Show("Insert data berhasil");

            FormPrintListTransaksi print = new FormPrintListTransaksi(dt_trans.Text.Replace("-", ""));

            print.Show();
        }

    }
}

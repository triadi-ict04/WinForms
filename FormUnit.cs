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
    public partial class FormUnit : Form
    {
        public FormUnit()
        {
            InitializeComponent();
            pv_sub_call_load_data();
            pv_cust_loadEntity();
            pv_cust_loadKontraktor();
            pv_cust_loadAktif();

            timer1.Start();
        }

        private void pv_sub_call_load_data()
        {
            var i_str_filter = "";

            if (txtSearch.Text.Length > 0)
            {
                i_str_filter = " (UNIT_NO LIKE '%" + txtSearch.Text + "%' OR UNIT_EGI LIKE '%" + txtSearch.Text + "%' OR UNIT_KONTRAKTOR LIKE '%" + txtSearch.Text + "%')";


            }

            try
            {
                load_data_grid("TBL_R_UNIT", i_str_filter, "UNIT_NO DESC", int.Parse(cbJmlData.Text), int.Parse(txtPage.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex.Message.ToString() + " -- " + i_str_filter);
            }

        }

        private void load_data_grid(string s_str_table_name, string s_str_filter,
                                    string s_str_sort, int s_int_page_size,
                                    int s_int_page_index)
        {
            DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();
            DSJT18.TBL_R_UNITDataTable i_dtab_data = new DSJT18.TBL_R_UNITDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.PagingData(s_str_table_name, s_str_filter, s_str_sort, s_int_page_size, s_int_page_index).Select();


            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);



            var col = i_dset_data.Tables[0];

            dgv_transaksi.DataSource = col;
        }

        #region paging event handler

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i_int_page = int.Parse(txtPage.Text);

            txtPage.Text = "" + (i_int_page + 1);

            pv_sub_call_load_data();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int i_int_page = int.Parse(txtPage.Text);

            txtPage.Text = "" + (i_int_page - 1);

            pv_sub_call_load_data();
        }

        private void cbJmlData_TextChanged(object sender, EventArgs e)
        {
            pv_sub_call_load_data();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            pv_sub_call_load_data();
        }


        #endregion
        private void dgv_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNoUnit.Text = dgv_transaksi.CurrentRow.Cells["UNIT_NO"].Value.ToString();
            cbEntity.Text = dgv_transaksi.CurrentRow.Cells["UNIT_ENTITY"].Value.ToString();
            txtEgi.Text = dgv_transaksi.CurrentRow.Cells["UNIT_EGI"].Value.ToString();
            cbKontraktor.Text = dgv_transaksi.CurrentRow.Cells["UNIT_KONTRAKTOR"].Value.ToString();
            txtDefaultTare.Text = dgv_transaksi.CurrentRow.Cells["UNIT_DEFAULT_TARE"].Value.ToString();

            txtNoUnit.Enabled = false;
            btnSimpan.Text = "UPDATE";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtNoUnit.Text = "";
            txtEgi.Text = "";
            cbKontraktor.Text = "";
            txtNoUnit.Enabled = true;

            btnSimpan.Text = "SIMPAN";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();

            try
            {

                if (txtNoUnit.Text.ToString().Trim().Length == 0 || txtEgi.Text.ToString().Trim().Length == 0 || cbKontraktor.Text.ToString().Trim().Length == 0)
                {
                    MessageBox.Show("isikan semua kolom isian dengan benar");
                }
                else
                {
                    if (btnSimpan.Text == "SIMPAN")
                    {
                        i_tadap.InsertUnit(txtNoUnit.Text.ToString(), cbEntity.SelectedValue.ToString(), txtEgi.Text.ToString(), cbKontraktor.Text.ToString(), int.Parse(txtDefaultTare.Text), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateUnit(cbEntity.Text.ToString(), txtEgi.Text.ToString(), cbKontraktor.Text.ToString(), int.Parse(txtDefaultTare.Text), txtNoUnit.Text.ToString());

                        MessageBox.Show("Edit data berhasil");
                    }
                }

                pv_sub_call_load_data();


                txtNoUnit.Text = "";
                txtEgi.Text = "";
                cbKontraktor.Text = "";
                txtNoUnit.Enabled = true;

                btnSimpan.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error transaksi unit : \n " + ex.Message.ToString());
            }
        }

        private void dgv_transaksi_KeyDown(object sender, KeyEventArgs e)
        {
            Color icolor = dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor;

            dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;


            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Yakin Menghapus data ini", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    try
                    {
                        DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();

                        i_tadap.DeleteUnit(dgv_transaksi.CurrentRow.Cells["UNIT_NO"].Value.ToString());

                        pv_sub_call_load_data();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

            }

            if (dgv_transaksi.RowCount != 0)
            {
                dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }

        }

        #region combobox
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

            cbEntity.DataSource = i_dset_data.Tables[0];
            cbEntity.ValueMember = i_dset_data.Tables[0].Columns["ENTITY_CODE"].ColumnName.ToString();
            cbEntity.DisplayMember = i_dset_data.Tables[0].Columns["ENTITY_NAME"].ColumnName.ToString();

        }
        private void pv_cust_loadKontraktor()
        {
            DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();
            DSJT18.TBL_R_UNITDataTable i_dtab_data = new DSJT18.TBL_R_UNITDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "UNIT_KONTRAKTOR ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbKontraktor.DataSource = i_dset_data.Tables[0];
            cbKontraktor.ValueMember = i_dset_data.Tables[0].Columns["UNIT_KONTRAKTOR"].ColumnName.ToString();
            cbKontraktor.DisplayMember = i_dset_data.Tables[0].Columns["UNIT_KONTRAKTOR"].ColumnName.ToString();

        }
        private void pv_cust_loadAktif()
        {
            DSJT18TableAdapters.TBL_R_UNITTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_UNITTableAdapter();
            DSJT18.TBL_R_UNITDataTable i_dtab_data = new DSJT18.TBL_R_UNITDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "UNIT_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbAktif.DataSource = i_dset_data.Tables[0];
            cbAktif.ValueMember = i_dset_data.Tables[0].Columns["UNIT_AKTIF"].ColumnName.ToString();
            cbAktif.DisplayMember = i_dset_data.Tables[0].Columns["UNIT_AKTIF"].ColumnName.ToString();

        }

        #endregion
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtNoUnit.Text = "";
            txtEgi.Text = "";
            cbKontraktor.Text = "";
            txtNoUnit.Enabled = true;

            btnSimpan.Text = "Save";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}

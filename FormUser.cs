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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            pv_cust_loadAkses();
            pv_sub_call_load_data();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region paging

        #region paging load data


        private void load_data_grid(string s_str_table_name, string s_str_filter,
                                    string s_str_sort, int s_int_page_size,
                                    int s_int_page_index)
        {


            DSJT18TableAdapters.VW_R_USERTableAdapter i_tadap_data = new DSJT18TableAdapters.VW_R_USERTableAdapter();
            DSJT18.VW_R_USERDataTable i_dtab_data = new DSJT18.VW_R_USERDataTable();
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




            //foreach (DataGridViewColumn coll in dgv_transaksi.Columns)
            //    if (coll.ReadOnly)
            //    {
            //        coll.DefaultCellStyle.BackColor = Color.Gray;
            //    }
            //    else
            //    {
            //        coll.DefaultCellStyle.BackColor = Color.White;
            //    }


        }

        private void pv_sub_call_load_data()
        {
            var i_str_filter = "";

            if (txt_search.Text.Length > 0)
            {
                i_str_filter = " (USER_NAME LIKE '%" + txt_search.Text + "%' OR USER_COMPANY LIKE '%" + txt_search.Text + "%' OR AKSES_NAME LIKE '%" + txt_search.Text + "%' OR USER_USERNAME LIKE '%" + txt_search.Text + "%')";


            }

            try
            {
                load_data_grid("VW_R_USER", i_str_filter, "USER_NAME DESC", int.Parse(cmb_jmlData.Text), int.Parse(txt_page.Text));
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



        #endregion

        #endregion

        private void pv_cust_loadAkses()
        {
            DSJT18TableAdapters.TBL_M_AKSESTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_M_AKSESTableAdapter();
            DSJT18.TBL_M_AKSESDataTable i_dtab_data = new DSJT18.TBL_M_AKSESDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select("", "AKSES_NAME ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cmb_akses.ValueMember = "AKSES_RAW_ID";
            cmb_akses.DisplayMember = "AKSES_NAME";
            cmb_akses.DataSource = i_dset_data.Tables[0];

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DSJT18TableAdapters.TBL_R_USERTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_USERTableAdapter();


            if (txt_name.Text.ToString().Trim().Length == 0 ||
                txt_company.Text.ToString().Trim().Length == 0 ||
                cmb_akses.Text.ToString().Trim().Length == 0 ||
                txt_username.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Isikan semua kolom isian dengan benar !!!");
            }
            else
            {
                try
                {

                    if (btn_save.Text == "Save")
                    {
                        if (txt_password.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("Isikan semua kolom isian dengan benar !!!");

                            return;
                        }
                        i_tadap.InsertUser(txt_name.Text.ToString(), txt_company.Text.ToString(), cmb_akses.SelectedValue.ToString(), txt_username.Text, txt_password.Text);

                        MessageBox.Show("Insert user berhasil..");
                    }
                    else
                    {

                        if (txt_password.Text.ToString().Trim().Length == 0)
                        {
                            i_tadap.UpdateUserWithoutPass(txt_name.Text, txt_company.Text, cmb_akses.SelectedValue.ToString(), txt_username.Text, lbl_raw_id.Text);
                        }
                        else
                        {
                            i_tadap.UpdateUser(txt_name.Text, txt_company.Text, cmb_akses.SelectedValue.ToString(), txt_password.Text, txt_username.Text, lbl_raw_id.Text);
                        }


                        MessageBox.Show("Update data berhasil...");

                    }

                    pv_sub_call_load_data();
                    resetform();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error transaksi : \n" + ex.Message.ToString());
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            resetform();

        }

        private void resetform()
        {
            txt_name.Text = "";
            txt_company.Text = "";
            cmb_akses.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            lbl_raw_id.Text = "";

            btn_save.Text = "Save";
        }

        private void dgv_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_transaksi.CurrentRow.Cells["USER_NAME"].Value.ToString();
            txt_company.Text = dgv_transaksi.CurrentRow.Cells["USER_COMPANY"].Value.ToString();
            cmb_akses.SelectedValue = dgv_transaksi.CurrentRow.Cells["USER_AKSES"].Value;
            txt_username.Text = dgv_transaksi.CurrentRow.Cells["USER_USERNAME"].Value.ToString();
            txt_password.Text = "";
            lbl_raw_id.Text = dgv_transaksi.CurrentRow.Cells["USER_RAW_ID"].Value.ToString();
            // txt_password.Text = dgv_transaksi.CurrentRow.Cells["USER_PASSWORD"].Value.ToString();

            btn_save.Text = "Update";
        }

        private void dgv_transaksi_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            Color icolor = dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor;

            dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



            if (MessageBox.Show("Yakin Menghapus data ini", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DSJT18TableAdapters.TBL_R_USERTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_USERTableAdapter();

                    i_tadap.DeleteUser(dgv_transaksi.CurrentRow.Cells["USER_RAW_ID"].Value.ToString());

                    pv_sub_call_load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                }
            }


            resetform();
            if (dgv_transaksi.RowCount != 0)
            {
                dgv_transaksi.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }

        }
    }
}

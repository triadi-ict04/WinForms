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
    public partial class FormDocket : Form
    {
        private FormTransaksi frm;
        public FormDocket(FormTransaksi frm1)
        {
            InitializeComponent();
            pv_sub_call_load_data();

            frm = frm1;
        }

        private void pv_sub_call_load_data()
        {
            var i_str_filter = "";

            if (txtSearch.Text.Length > 0)
            {
                i_str_filter = " (DOCKET_UNIT_NO LIKE '%" + txtSearch.Text + "%' OR DOCKET_PRODUCT LIKE '%" + txtSearch.Text + "%' " +
                    "OR DOCKET_LOADER LIKE '%" + txtSearch.Text + "%' OR DOCKET_CPP LIKE '%" + txtSearch.Text + "%' OR DOCKET_STOCKPILE LIKE '%" + txtSearch.Text + "%')";
            }

            try
            {
                load_data_grid("VW_R_DOCKET", i_str_filter, "DOCKET_UNIT_NO DESC", int.Parse(cbJmlData.Text), int.Parse(txtPage.Text));
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
            DSJT18TableAdapters.VW_R_DOCKETTableAdapter i_tadap_data = new DSJT18TableAdapters.VW_R_DOCKETTableAdapter();
            DSJT18.VW_R_DOCKETDataTable i_dtab_data = new DSJT18.VW_R_DOCKETDataTable();
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
        private void dgv_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLogin log = new FormLogin();
            FormMenu frm_menu = new FormMenu(log);

            string code = dgv_transaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            string unit = dgv_transaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            string product = dgv_transaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            string loader = dgv_transaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            string cpp = dgv_transaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            string stockpile = dgv_transaksi.Rows[e.RowIndex].Cells[5].Value.ToString();

            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormTransaksi"];

            //FormTransaksi frm1 = new FormTransaksi(code, unit, product, loader, cpp, stockpile);
            frm.lbl_Docket.Text = dgv_transaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm.cbUnit.Text = dgv_transaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.cbProduct.Text = dgv_transaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.txtLoader.Text = dgv_transaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm.cbSumber.Text = dgv_transaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.cbStockpile.Text = dgv_transaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //frm_menu.panelDesktop.Controls.Add(frm);
            frm.Refresh();
            frm.BringToFront();
            this.Close();

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

    }
}

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.BackColor =  Color.FromArgb(98, 102, 244);//Border color
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DSJT18TableAdapters.TBL_R_USERTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_USERTableAdapter();

                if (txt_username.Text.ToString().Trim().Length == 0 || txt_password.Text.ToString().Trim().Length == 0)
                {
                    MessageBox.Show("Isikan Kolom isian dengan benar..!!!");

                    return;
                }


                var cekid = i_tadap_data.cufn_cekUser(txt_password.Text, txt_username.Text);

                if (cekid != null)
                {

                    txt_username.Text = "";
                    txt_password.Text = "";
                    this.Hide();

                    FormMenu frm = new FormMenu(this);
                    frm.lbl_username.Text = "";
                    pv_cust_loadakses(frm, cekid.ToString());

                    frm.Show();

                }
                else
                {
                    MessageBox.Show("akses tidak ditemukan");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error login : \n" + ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pv_cust_loadakses(FormMenu s_frm, String s_rawid)
        {
            DSJT18TableAdapters.VW_R_USERTableAdapter i_tadap_data = new DSJT18TableAdapters.VW_R_USERTableAdapter();
            DSJT18.VW_R_USERDataTable i_dtab_data = new DSJT18.VW_R_USERDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.getOneUser(s_rawid).Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);


            s_frm.lbl_username.Text = i_dset_data.Tables[0].Rows[0]["USER_NAME"].ToString();
            s_frm.lbl_akses.Text = i_dset_data.Tables[0].Rows[0]["AKSES_NAME"].ToString();

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

    }
}

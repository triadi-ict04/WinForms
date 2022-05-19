using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormMenu : Form
    {
        //Forms
        //FormTransaksi frm_trans = new FormTransaksi();
        FormListTransaksi frm_ListTrans = new FormListTransaksi();
        FormReferensi frm_ref = new FormReferensi();
        FormUnit frm_unit = new FormUnit();
        FormUser frm_user = new FormUser();
        //FormDocket frm_dock = new FormDocket();
        FormLogin frm_login;

        //Constructor
        public FormMenu(FormLogin frm)
        {
            InitializeComponent();
            CollapseMenu();
            timer1.Start();

            frm_login = frm;
            lblNamaJT.Text = Properties.Settings.Default["Name"].ToString();

            panelMenu.BackColor = Color.FromArgb(98, 102, 244);//Border color
            panelFooter.BackColor = Color.FromArgb(98, 102, 244);//Border color
            lblDatetime.BackColor = Color.FromArgb(98, 102, 244);//Border color
            panelDesktop.BackColor = Color.FromArgb(245, 245, 255);//Border color
            btnMenu.BackColor = Color.FromArgb(98, 102, 244);//Border color
            btnClose.BackColor = Color.FromArgb(255, 74, 130);//Border color
            btnMaximize.BackColor = Color.FromArgb(98, 102, 244);//Border color
            btnMinimize.BackColor = Color.FromArgb(255, 74, 130);//Border color

        }

        #region setMenu
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormMenu_Load(object sender, EventArgs e)
        {
            string i_string_user = lbl_username.Text;

            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormDashboard"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormDashboard frm = new FormDashboard();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region implement
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;

                }

                //MessageBox.Show(frm.Name);
            }
            return false;
        }

        private void OpenForm(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.Show();

                }
                else
                {
                    frm.Hide();
                }

                //MessageBox.Show(frm.Name);
            }
            //return false;
        }

        #endregion


        #region button

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login.Show();
            frm_login.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormDashboard"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormDashboard frm = new FormDashboard();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            string code = "";
            string unit = "";
            string product = "";
            string loader = "";
            string cpp = "";
            string stockpile = "";

            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormTransaksi"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormTransaksi frm = new FormTransaksi(code, unit, product, loader, cpp, stockpile);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnListTransaksi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormListTransaksi"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormListTransaksi frm = new FormListTransaksi();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnReferensi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormReferensi"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormReferensi frm = new FormReferensi();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnListUnit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormUnit"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormUnit frm = new FormUnit();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormUser"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormUser frm = new FormUser();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void btnListDocket_Click(object sender, EventArgs e)
        {
            string code = "";
            string unit = "";
            string product = "";
            string loader = "";
            string cpp = "";
            string stockpile = "";
            FormTransaksi frm1 = new FormTransaksi(code, unit, product, loader, cpp, stockpile);

            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormDocket"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormDocket frm = new FormDocket(frm1);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        #endregion


    }
}

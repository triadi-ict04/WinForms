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
        FormTransaksi frm_trans = new FormTransaksi();
        FormListTransaksi frm_ListTrans = new FormListTransaksi();
        FormReferensi frm_ref = new FormReferensi();
        FormUnit frm_unit = new FormUnit();
        FormUser frm_user = new FormUser();
        FormLogin frm_login;

        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        //Constructor
        public FormMenu(FormLogin frm)
        {
            InitializeComponent();
            CollapseMenu();
            timer1.Start();

            frm_login = frm;
            lblNamaJT.Text = Properties.Settings.Default["Name"].ToString();

            panelMenu.Padding = new Padding(borderSize);//Border size
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
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion



            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);

        }

        //Event methods
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            AdjustFormScrollbars();
        }

        //Private methods
        private void AdjustFormScrollbars()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

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

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form pr = System.Windows.Forms.Application.OpenForms["FormTransaksi"];

            if (pr != null)
            {
                panelDesktop.Controls.Add(pr);
                pr.BringToFront();
                pr.Focus();
                return;
            }

            FormTransaksi frm = new FormTransaksi();
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

        #endregion


    }
}

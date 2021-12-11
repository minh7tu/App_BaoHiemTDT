using BaoHiemTDT.Feature;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BaoHiemTDT.Master
{
    public partial class frmMaster : Form
    {
        //Field
        private Form activeForm;
        private Thread th;

        public frmMaster(string username)
        {
            InitializeComponent();
            lblName.Text +="," + username;
        }

        public frmMaster()
        {
            // TODO: Complete member initialization
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            //Loại bỏ đường viền của Form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.notify.ContextMenuStrip = this.contextMenuStrip;
        }

        [DllImport("user32.DLL",EntryPoint="ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr h, int w, int wParam, int lParam);

        //Kéo thả form
        private void frmMaster_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Đóng form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Restore form
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "☐";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "❐";
            }
        }
        //Minize form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Đóng form
        private void tSMItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Mở 1 form
        public void openChildForm(Form childForm , object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneChild.Controls.Add(childForm);
            this.paneChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
         
        }
        //Kích đúp đăng xuất
        private void tSMItemLogin_Click(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }
        //Xem thông tin khách , đóng form hiện tại
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer(), sender);
        }
        //Chọn product , đóng form hiện tại
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduct(), sender);
        }
        //Đăng xuất , đóng form hiện tại
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewFrom);
            th.Start();
        }

        private void openNewFrom()
        {
            Application.Run(new frmLogin());
        }
    }
}

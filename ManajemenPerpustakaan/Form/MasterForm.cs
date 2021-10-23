using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManajemenPerpustakaan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Dashboard());
        }

        void hideSubMenu()
        {
            
            panelSideMini.Visible = false;
        }

        private void showSubMenu(Panel subMenu, Button btn)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                btn.BackColor = Color.WhiteSmoke;
                subMenu.Visible = true;
                subMenu.BackColor = Color.WhiteSmoke;
            }
            else
            {

                subMenu.Visible = false;
            btn.BackColor = Color.White;
            }

        }

        private void showTooltip(string labels, Button buttons)
        {
            int xPoint = panelSideMini.Left;
            int yPoint = buttons.Top;
            int xWidth = labels.Length * 11;
            Console.WriteLine(yPoint);
            if (panelTooltip.Visible == false)
            {

            panelTooltip.BringToFront();
            panelTooltip.Visible = true;
            panelTooltip.Location = new Point(xPoint, yPoint);
            panelTooltip.Size = new Size(xWidth,45);
            labelTooltip.Text = labels;

            }
            else
            {
                panelTooltip.Visible = false;
                labelTooltip.Text = "";
            }
        }

        private void showMoarTooltip(string labels, Button buttons)
        {
            int xPoint = panelSideMini.Left + 115;
            int yPoint = buttons.Top;
            int xWidth = labels.Length * 11;
            if (panelMoarTooltip.Visible == false)
            {
                panelMoarTooltip.Visible = true;
                panelMoarTooltip.Location = new Point(xPoint, yPoint);
                panelMoarTooltip.Size = new Size(xWidth, 100);
                labelMoarTooltip.Text = labels.ToUpper();
            }
            else
            {
                panelMoarTooltip.Visible = false;
                labelMoarTooltip.Text = "";
            }
        }

        private void btnManajemenBuku_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenBuku());
        }

        private void btnManajemenAnggota_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenPegawai());
        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            if (panelSide.Visible == true)
            {
                panelSide.Visible = false;
                panelSideMini.Visible = true;
            }
            else
            {
                panelSide.Visible = true;
                panelSideMini.Visible = false;
            }
        }

        #region ButtonMiniDashboard

        private void btnMiniDashboard_MouseHover(object sender, EventArgs e)
        {
            showTooltip("Dashboard", btnMiniDashboard);
        }

        private void btnMiniDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (panelTooltip.Visible == true)
            {
                panelTooltip.Visible = false;
            }
        }

        #endregion

        #region ButtonMiniPinjamBuku

        private void btnMiniPinjamBuku_MouseHover(object sender, EventArgs e)
        {
            showTooltip("Peminjaman Buku", btnMiniPinjamBuku);
        }

        private void btnMiniPinjamBuku_MouseLeave(object sender, EventArgs e)
        {
            if (panelTooltip.Visible == true)
            {
                panelTooltip.Visible = false;
            }
        }

        #endregion

        #region ButtonMiniPengembalianBuku

        private void btnMiniPengembalianBuku_MouseHover(object sender, EventArgs e)
        {
            showTooltip("Pengembalian Buku", btnMiniPengembalianBuku);
        }

        private void btnMiniPengembalianBuku_MouseLeave(object sender, EventArgs e)
        {
            if (panelTooltip.Visible == true)
            {
                panelTooltip.Visible = false;
            }
        }

        #endregion

        private void panelMoarTooltip_MouseLeave(object sender, EventArgs e)
        {
            if (panelMoarTooltip.Visible == true)
            {
                panelMoarTooltip.Visible = false;
            }
        }

     

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            int xWidth = panelMaster.Right;
            int yHeight = panelMaster.Top;
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.AutoSize = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            panelMaster.Controls.Add(childForm);
            panelMaster.Tag = childForm;
            childForm.Dock = DockStyle.Top;
            childForm.Size = new Size(xWidth, yHeight);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void btnMiniDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());

        }

        private void btnMiniManajemenBuku_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenBuku());
        }

        private void btnMiniKeanggotaan_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenPegawai());
        }

        private void btnSideMenu_Click_1(object sender, EventArgs e)
        {
            if (panelSide.Visible == true)
            {
                panelSide.Visible = false;
                panelSideMini.Visible = true;
            }
            else
            {
                panelSide.Visible = true;
                panelSideMini.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelSide.Visible == true)
            {
                panelSide.Visible = false;
                panelSideMini.Visible = true;
            }
            else
            {
                panelSide.Visible = true;
                panelSideMini.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}

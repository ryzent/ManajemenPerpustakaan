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
            panelManajemenBuku.Visible = false;
            panelManajemenAnggota.Visible = false;
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
            showSubMenu(panelManajemenBuku, btnManajemenBuku);
        }

        private void btnManajemenAnggota_Click(object sender, EventArgs e)
        {
            showSubMenu(panelManajemenAnggota, btnManajemenAnggota);
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

        #region ButtonMiniBuku

        private void btnMiniManajemenBuku_MouseHover(object sender, EventArgs e)
        {
            showMoarTooltip("Manajemen Perpustakaan",btnMiniManajemenBuku);
        }

        private void btnMiniManajemenBuku_MouseLeave(object sender, EventArgs e)
        {
            
        }

        #endregion


        #region ButtonMiniKeanggotaan

        private void btnMiniKeanggotaan_MouseHover(object sender, EventArgs e)
        {
            showMoarTooltip("Manajemen Keanggotaan", btnMiniKeanggotaan);
        }

        private void btnMiniKeanggotaan_MouseLeave(object sender, EventArgs e)
        {

        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.AutoSize = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMaster.Controls.Add(childForm);
            panelMaster.Tag = childForm;
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

        private void btnBukuPel_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenBukuPel());
        }

        private void btnBukuNonPel_Click(object sender, EventArgs e)
        {
            openChildForm(new ManajemenBukuNonPel());
        }
    }
}

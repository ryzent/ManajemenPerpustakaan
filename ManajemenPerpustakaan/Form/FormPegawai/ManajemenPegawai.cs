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
    public partial class ManajemenPegawai : Form
    {
        Utils utils = new Utils(Var.url);
        public ManajemenPegawai()
        {
            InitializeComponent();
        }

        private void ManajemenBuku_Load(object sender, EventArgs e)
        {
            //utils.setCombobox("SELECT * FROM tb_jenisBuku ORDER BY jenis_buku ASC", comboBox1, "id", "jenis_buku");
            utils.readToDataGrid("SELECT tb_pegawai.id Id, nama Nama, alamat Alamat, email Email, nomor_telepon NomorTelepon, tb_role.role Role FROM tb_pegawai INNER JOIN tb_role ON tb_pegawai.id_role = tb_role.id", dgv_pegawai);
            dgv_pegawai.Columns[0].Visible = false;
           //comboBox1.Text = "Filter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahPegawai tambahPegawai = new TambahPegawai();
            tambahPegawai.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenis_buku=tb_jenisBuku.id WHERE tb_jenisBuku.jenis_buku='"+comboBox1.Text+"' ", dgv_pegawai);

            }
            catch (Exception ex)
            {

                utils.MsgWarn(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    utils.readToDataGrid("SELECT nama Nama, alamat Alamat, email Email, nomor_telepon NomorTelepon, tb_role.role Role FROM tb_pegawai INNER JOIN tb_role ON tb_pegawai.id_role = tb_role.id WHERE nama='"+textBox1.Text+"' OR email='"+textBox1.Text+"'", dgv_pegawai);
                }
                else
                {
                    utils.MsgInfo("Harap isi kolom pencarian");
                }
            }
            catch (Exception ex)
            {
                utils.MsgWarn(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                utils.readToDataGrid("SELECT nama Nama, alamat Alamat, email Email, nomor_telepon NomorTelepon, tb_role.role Role FROM tb_pegawai INNER JOIN tb_role ON tb_pegawai.id_role = tb_role.id", dgv_pegawai);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    utils.readToDataGrid("SELECT nama Nama, alamat Alamat, email Email, nomor_telepon NomorTelepon, tb_role.role Role FROM tb_pegawai INNER JOIN tb_role ON tb_pegawai.id_role = tb_role.id WHERE nama='" + textBox1.Text + "' OR email='" + textBox1.Text + "'", dgv_pegawai);
                }
                else
                {
                    utils.MsgInfo("Harap isi kolom pencarian");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenis_buku=tb_jenisBuku.id", dgv_pegawai);
            //comboBox1.Text = "Filter";
        }

        private void dgv_pegawai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_pegawai.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                DetailPegawai detail = new DetailPegawai(id);
                detail.Show();
            }
        }
    }
}

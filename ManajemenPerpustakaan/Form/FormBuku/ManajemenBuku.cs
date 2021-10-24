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
    public partial class ManajemenBuku : Form
    {
        Utils utils = new Utils(Var.url);
        public ManajemenBuku()
        {
            InitializeComponent();
        }

        private void ManajemenBuku_Load(object sender, EventArgs e)
        {
            utils.setCombobox("SELECT * FROM tb_jenisBuku ORDER BY jenis_buku ASC", comboBox1, "id", "jenis_buku");
            utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            comboBox1.Text = "Filter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahBuku tambahBuku = new TambahBuku();
            tambahBuku.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_jenisBuku.jenis_buku='"+comboBox1.Text+"' ", dgv_buku);

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
                    utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_buku.kode_buku='" + textBox1.Text + "' OR tb_buku.judul_buku='"+textBox1.Text+"' OR tb_buku.penerbit='"+textBox1.Text+"'", dgv_buku);
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
                utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_buku.kode_buku='" + textBox1.Text + "' OR tb_buku.judul_buku='" + textBox1.Text + "' OR tb_buku.penerbit='" + textBox1.Text + "'", dgv_buku);
                }
                else
                {
                    utils.MsgInfo("Harap isi kolom pencarian");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            comboBox1.Text = "Filter";
        }

        private void dgv_buku_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_buku.Rows[e.RowIndex];
                string kode_buku = row.Cells[0].Value.ToString();
                DetailBuku detail = new DetailBuku(kode_buku);
                detail.Show();
            }
        }
    }
}

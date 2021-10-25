using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManajemenPerpustakaan
{
    public partial class TransaksiPeminjaman : Form
    {
        Utils utils = new Utils(Var.url);
        public TransaksiPeminjaman()
        {
            InitializeComponent();
        }

        private void TransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            utils.setCombobox("SELECT * FROM tb_jenisBuku ORDER BY jenis_buku ASC", comboBox1, "id", "jenis_buku");
            utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            CreateColumn();
            GenerateKodePinjaman();
        }

        private void GenerateKodePinjaman()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            int a = 000;
            string kode = "KP";

            DataTable dt = utils.readToDataTable("SELECT * FROM tb_peminjaman");
            foreach (DataRow dr in dt.Rows)
            {
                a = Convert.ToInt32(dr["kode_peminjaman"].ToString().Trim(kode.ToCharArray()));
            }
            if (a == a) a++;
            
            txb_kode.Text = $"{kode}00{a}";

        }

        private void CreateColumn()
        {
            dgv_list_buku.ColumnCount = 2;
            dgv_list_buku.Columns[0].Name = "KodeBuku";
            dgv_list_buku.Columns[1].Name = "JudulBuku";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            comboBox1.Text = "Filter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_buku.kode_buku='" + textBox1.Text + "' OR tb_buku.judul_buku='" + textBox1.Text + "' OR tb_buku.penerbit='" + textBox1.Text + "'", dgv_buku);
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id", dgv_buku);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text != "")
                {
                    utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_buku.kode_buku='" + textBox1.Text + "' OR tb_buku.judul_buku='" + textBox1.Text + "' OR tb_buku.penerbit='" + textBox1.Text + "'", dgv_buku);
                }
                else
                {
                    utils.MsgInfo("Harap isi kolom pencarian");
                }
            }
        }

        private void dgv_buku_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgv_buku.Rows[e.RowIndex];

                string kode_buku = row.Cells[0].Value.ToString();
                string judul_buku = row.Cells[1].Value.ToString();

                string[] new_row = { kode_buku, judul_buku };
                dgv_list_buku.Rows.Add(new_row);

                /*DataGridViewRow add_row = (DataGridViewRow)dgv_list_buku.Rows[0].Clone();
                add_row.Cells[0].Value = "Test";
                dgv_list_buku.Rows.Add(add_row);*/
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_jenisBuku.jenis_buku='" + comboBox1.Text + "' ", dgv_buku);

            }
            catch (Exception ex)
            {

                utils.MsgWarn(ex.Message);
            }
        }

        private void dgv_list_buku_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            string count = dgv_list_buku.Rows.Count.ToString();
            label7.Text = $"Total buku: {count}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Var.url);
            SqlCommand command;
            try
            {
                if (txb_nis.Text != "" && txb_nama.Text != "" && txb_kelas.Text != "")
                {
                    string query = @"INSERT INTO tb_peminjaman([kode_peminjaman], [nis], [nama], [kelas], [borrow_date], [due_date], [status], [id_pegawai]) VALUES('" + txb_kode.Text + "', '" + txb_nis.Text + "', '" + txb_nama.Text + "', '" + txb_kelas.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', 'pinjam', '" + Var.user + "' )";
                    utils.create(query);

                    query = @"INSERT INTO tb_detail_peminjaman([kode_peminjaman], [kode_buku]) VALUES('" + txb_kode.Text + "', @kode_buku)";
                    foreach (DataGridViewRow row in dgv_list_buku.Rows)
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@kode_buku", row.Cells[0].Value);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    utils.MsgInfo("Harap isi semua data!");
                }
                
                
            }
            catch (Exception ex)
            {
                utils.MsgWarn(ex.Message);
            }
        }
    }
}

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
    public partial class DetailBuku : Form
    {
        Utils utils = new Utils(Var.url);
        public DetailBuku(string kode_buku)
        {
            InitializeComponent();
            utils.setCombobox("SELECT * FROM tb_jenisBuku ORDER BY jenis_buku ASC", cmb_jenis, "id", "jenis_buku");
            DataTable dt = utils.readToDataTable("SELECT tb_buku.kode_buku KodeBuku, judul_buku JudulBuku, penulis_buku PenulisBuku, penerbit Penerbit, tahun_terbit TahunTerbit, isbn ISBN, tb_jenisBuku.jenis_buku JenisBuku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_buku.kode_buku='" + kode_buku + "'");
            if (dt.Rows.Count >= 0)
            {
                cmb_jenis.Text = dt.Rows[0]["JenisBuku"].ToString();
                txt_kode_buku.Text = dt.Rows[0]["KodeBuku"].ToString();
                txt_judul_buku.Text = dt.Rows[0]["JudulBuku"].ToString();
                txt_penulis_buku.Text = dt.Rows[0]["PenulisBuku"].ToString();
                txt_penerbit_buku.Text = dt.Rows[0]["Penerbit"].ToString();
                txb_tahun_terbit.Text = dt.Rows[0]["TahunTerbit"].ToString();
                txb_isbn.Text = dt.Rows[0]["ISBN"].ToString();
            }
            
            
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_kode_buku.Text != "" || txt_judul_buku.Text != "" || txt_penulis_buku.Text != "" || txt_penerbit_buku.Text != "" || txb_tahun_terbit.Text != "")
            {
                if (MessageBox.Show("Perbarui data buku ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    utils.update("UPDATE tb_buku SET judul_buku='" + txt_judul_buku.Text + "', penulis_buku='" + txt_penulis_buku.Text + "', penerbit='" + txt_penerbit_buku.Text + "', tahun_terbit='" + txb_tahun_terbit.Text + "', isbn='"+txb_isbn.Text+"' WHERE kode_buku='" + txt_kode_buku.Text + "' ");
                    this.Close();
                }
                
            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_kode_buku.Text != "" )
            {
                if (MessageBox.Show("Hapus buku ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    utils.delete("DELETE tb_buku WHERE kode_buku='"+txt_kode_buku.Text+"'");
                    this.Close();
                }
            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
        }

        private void DetailBuku_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class TambahBuku : Form
    {
        Utils utils = new Utils(Var.url);
        public TambahBuku()
        {
            InitializeComponent();
        }

        private void TambahBuku_Load(object sender, EventArgs e)
        {
            utils.setCombobox("SELECT * FROM tb_jenisBuku ORDER BY jenis_buku ASC", cmb_jenis, "id", "jenis_buku");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_kode_buku.Text != "" && txt_judul_buku.Text != "" && txt_penulis_buku.Text != "" && txt_penerbit_buku.Text != "" && txb_tahun_terbit.Text != "" )
            {
                string query = "INSERT INTO tb_buku([kode_buku],[judul_buku],[penulis_buku],[penerbit],[tahun_terbit],[isbn],[id_jenisBuku]) VALUES('" + txt_kode_buku.Text+"', '"+txt_judul_buku.Text+"', '"+txt_penulis_buku.Text+"', '"+txt_penerbit_buku.Text+"', '"+txb_tahun_terbit.Text+"', '"+txb_isbn.Text+"', '"+cmb_jenis.SelectedValue.ToString()+"')";
                utils.create(query);
                this.Close();

            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            try
            {
                string kode = "";
                int a = 0;
                int i = 0;
                
                dt = utils.readToDataTable("SELECT * FROM tb_jenisBuku WHERE jenis_buku='" + cmb_jenis.Text + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    kode = dr["kode_buku"].ToString();
                }
                dt = utils.readToDataTable("SELECT tb_buku.kode_buku FROM tb_buku INNER JOIN tb_jenisBuku ON tb_buku.id_jenisBuku=tb_jenisBuku.id WHERE tb_jenisBuku.jenis_buku='" + cmb_jenis.Text+"'");
                foreach (DataRow dr in dt.Rows)
                {
                    a = Convert.ToInt32(dr["kode_buku"].ToString().Trim(kode.ToCharArray()));
                }
                if (a == a)
                {
                    a++;
                }
                txt_kode_buku.Text = $"{kode}00{a}";
                
            }
            catch (Exception ex)
            {
                utils.MsgWarn(ex.Message);
            }
        }

        private void btn_add_jenis_Click(object sender, EventArgs e)
        {
            TambahJenis jenis = new TambahJenis();
            jenis.Show();
            
        }

        
    }
}

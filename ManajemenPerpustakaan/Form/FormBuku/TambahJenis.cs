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
    public partial class TambahJenis : Form
    {
        Utils utils = new Utils(Var.url);
        public TambahJenis()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_nama_jenis.Text != "" && txt_inisial_kode.Text != "")
            {
                utils.create("INSERT INTO tb_jenisBuku([jenis_buku], [kode_buku]) VALUES('"+txt_nama_jenis.Text+"', '"+txt_inisial_kode.Text+"')");
                this.Close();
                TambahBuku buku = new TambahBuku();
                buku.Update();
            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
        }

        private void TambahJenis_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}

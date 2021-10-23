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
    public partial class TambahPegawai : Form
    {
        Utils utils = new Utils(Var.url);
        public TambahPegawai()
        {
            InitializeComponent();

        }

        private void TambahPegawai_Load(object sender, EventArgs e)
        {
            utils.setCombobox("SELECT * FROM tb_role", cmb_role, "id", "role");
            cmb_role.Items.Remove(0);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txb_nama.Text != "" || txb_email.Text != "")
            {
                if (txb_password.Text == txb_cPassword.Text)
                {
                    string query = "INSERT INTO tb_pegawai([nama],[alamat],[email],[password],[nomor_telepon],[id_role]) VALUES('"+txb_nama.Text+"','"+txb_alamat.Text + "','"+txb_email.Text + "', '"+txb_password.Text+"', '"+txb_nohp.Text+"', '"+cmb_role.SelectedValue.ToString()+"')";
                    utils.create(query);
                    this.Close();
                }
                else
                {
                    utils.MsgInfo("Sandi tidak sama!");
                }
            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

            {
                if (checkBox1.Checked == true)
                {
                    txb_password.PasswordChar = '\0';
                    txb_cPassword.PasswordChar = '\0';
                }
                else
                {
                    txb_password.PasswordChar = '*';
                    txb_cPassword.PasswordChar = '*';
                }
            }
        }

        private void txb_nohp_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

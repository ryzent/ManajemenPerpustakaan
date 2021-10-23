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
    public partial class DetailPegawai : Form
    {
        Utils utils = new Utils(Var.url);
        string id_pegawai = "";
        public DetailPegawai(string id)
        {
            id_pegawai = id;
            InitializeComponent();
            utils.setCombobox("SELECT * FROM tb_role", cmb_role, "id", "role");
            DataTable dt = utils.readToDataTable("SELECT nama Nama, alamat Alamat, email Email, nomor_telepon NomorTelepon, tb_role.role Role FROM tb_pegawai INNER JOIN tb_role ON tb_pegawai.id_role = tb_role.id WHERE tb_pegawai.id='"+id+"'");
            if (dt.Rows.Count >= 0)
            {
                txb_nama.Text = dt.Rows[0]["Nama"].ToString();
                txb_alamat.Text = dt.Rows[0]["Alamat"].ToString();
                txb_nohp.Text = dt.Rows[0]["NomorTelepon"].ToString();
                txb_email.Text = dt.Rows[0]["Email"].ToString();
                cmb_role.Text = dt.Rows[0]["Role"].ToString();
            }
        }

        private void DetailPegawai_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txb_nama.Text != "" || txb_email.Text != "")
            {
                if (txb_password.Text == "")
                {
                    utils.update("UPDATE tb_pegawai SET nama='"+txb_nama.Text+"', alamat='"+txb_alamat.Text+"', email='"+txb_email.Text+"', nomor_telepon='"+txb_nohp.Text+ "', id_role='" + cmb_role.SelectedValue.ToString()+"' WHERE id='"+id_pegawai+"'");

                } else if (txb_password.Text != "")
                {
                    if (txb_password.Text == txb_cPassword.Text)
                    {
                        utils.update("UPDATE tb_pegawai SET nama='" + txb_nama.Text + "', alamat='" + txb_alamat.Text + "', email='" + txb_email.Text + "', password='"+txb_password.Text+"', nomor_telepon='" + txb_nohp.Text + "', id_role='" + cmb_role.SelectedValue.ToString() + "' WHERE id='" + id_pegawai + "'");
                    }
                    else
                    {
                        utils.MsgInfo("Sandi tidak sama!");
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txb_nama.Text != "")
            {
                if (MessageBox.Show("Hapus data pegawai ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    utils.delete("DELETE tb_pegawai WHERE id='" + id_pegawai + "'");
                    this.Close();
                }
            }
            else
            {
                utils.MsgInfo("Harap isi semua kolom!");
            }
        }
    }
}

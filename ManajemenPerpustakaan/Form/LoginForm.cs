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
    public partial class LoginForm : Form
    {
        Utils utils = new Utils(Var.url);
        
        public LoginForm()
        {
            
            InitializeComponent();
            greetingsLabel();
            pictureSize();
        }

        void greetingsLabel()
        {
           int dt = DateTime.Now.Hour;
            
            if (dt >= 0 && dt < 11)
            {
                labelGreetings.Text = "Selamat Pagi!";
            } else if (dt >= 11 && dt < 15)
            {
                labelGreetings.Text = "Selamat Siang!";
            } else if (dt >= 15 && dt < 18)
            {
                labelGreetings.Text = "Selamat Sore!";
            } else if (dt >= 18 && dt < 24)
            {
                labelGreetings.Text = "Selamat Malam!";
            }
            
        }

        void pictureSize()
        {
            int xWidth = this.Right;
            int yHeight = this.Bottom;
            pictureBox1.Size = new Size(xWidth, yHeight);
        }

        private void LoginForm_SizeChanged(object sender, EventArgs e)
        {
            int xWidth = this.Right;
            int yHeight = this.Bottom;
            pictureSize();
            panel2.Size = new Size(xWidth, yHeight);
            
            
        }

        private void cbSeePassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbSeePassword.Checked == true)
            {
                txb_password.PasswordChar = '\0';
            } else
            {
                txb_password.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void login()
        {
            if (txb_email.Text != "")
            {
                if (txb_password.Text != "")
                {
                    try
                    {

                        DataTable dt = utils.readToDataTable("SELECT COUNT(*) email FROM tb_pegawai WHERE email='" + txb_email.Text + "'");
                        if (dt.Rows[0]["email"].ToString() == "1")
                        {
                            dt = utils.readToDataTable("SELECT COUNT(*) password FROM tb_pegawai WHERE password='" + txb_password.Text + "'");
                            if (dt.Rows[0]["password"].ToString() == "1")
                            {
                                dt = utils.readToDataTable("SELECT * FROM tb_pegawai WHERE email='" + txb_email.Text + "' AND password='" + txb_password.Text + "'");
                                if (dt.Rows.Count >= 1)
                                {
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        Var.user = dr["id"].ToString();
                                    }
                                    Console.WriteLine(Var.user);
                                    this.Hide();
                                    MainForm form = new MainForm();
                                    form.FormClosed += (s, args) => this.Close();
                                    form.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password Salah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Harap Isi Password!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Harap Isi Email!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

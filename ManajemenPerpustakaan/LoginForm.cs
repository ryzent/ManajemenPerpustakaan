﻿using System;
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
                textBox2.PasswordChar = '\0';
            } else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace ManajemenPerpustakaan
{
    partial class DetailBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add_jenis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_jenis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_isbn = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_tahun_terbit = new System.Windows.Forms.TextBox();
            this.txt_penerbit_buku = new System.Windows.Forms.TextBox();
            this.txt_penulis_buku = new System.Windows.Forms.TextBox();
            this.txt_judul_buku = new System.Windows.Forms.TextBox();
            this.txt_kode_buku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(119)))), ((int)(((byte)(239)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(157, 367);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 32);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Hapus data";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_jenis
            // 
            this.btn_add_jenis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_jenis.AutoSize = true;
            this.btn_add_jenis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_jenis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_jenis.Location = new System.Drawing.Point(396, 49);
            this.btn_add_jenis.MinimumSize = new System.Drawing.Size(29, 32);
            this.btn_add_jenis.Name = "btn_add_jenis";
            this.btn_add_jenis.Size = new System.Drawing.Size(29, 32);
            this.btn_add_jenis.TabIndex = 48;
            this.btn_add_jenis.Text = "+";
            this.btn_add_jenis.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Jenis Buku";
            // 
            // cmb_jenis
            // 
            this.cmb_jenis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_jenis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_jenis.FormattingEnabled = true;
            this.cmb_jenis.Items.AddRange(new object[] {
            "Buku Cerita",
            "Buku Novel",
            "Buku Pelajaran"});
            this.cmb_jenis.Location = new System.Drawing.Point(52, 51);
            this.cmb_jenis.MinimumSize = new System.Drawing.Size(338, 0);
            this.cmb_jenis.Name = "cmb_jenis";
            this.cmb_jenis.Size = new System.Drawing.Size(338, 30);
            this.cmb_jenis.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "ISBN";
            // 
            // txb_isbn
            // 
            this.txb_isbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_isbn.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_isbn.Location = new System.Drawing.Point(52, 336);
            this.txb_isbn.MinimumSize = new System.Drawing.Size(180, 25);
            this.txb_isbn.Name = "txb_isbn";
            this.txb_isbn.Size = new System.Drawing.Size(373, 25);
            this.txb_isbn.TabIndex = 44;
            // 
            // btn_simpan
            // 
            this.btn_simpan.AutoSize = true;
            this.btn_simpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(119)))), ((int)(((byte)(239)))));
            this.btn_simpan.FlatAppearance.BorderSize = 0;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(52, 367);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(97, 32);
            this.btn_simpan.TabIndex = 43;
            this.btn_simpan.Text = "Simpan data";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tahun Terbit";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Penerbit Buku";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Penulis Buku";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Judul Buku";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kode Buku";
            // 
            // txb_tahun_terbit
            // 
            this.txb_tahun_terbit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tahun_terbit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tahun_terbit.Location = new System.Drawing.Point(245, 280);
            this.txb_tahun_terbit.MinimumSize = new System.Drawing.Size(180, 25);
            this.txb_tahun_terbit.Name = "txb_tahun_terbit";
            this.txb_tahun_terbit.Size = new System.Drawing.Size(180, 25);
            this.txb_tahun_terbit.TabIndex = 37;
            // 
            // txt_penerbit_buku
            // 
            this.txt_penerbit_buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_penerbit_buku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penerbit_buku.Location = new System.Drawing.Point(52, 280);
            this.txt_penerbit_buku.MinimumSize = new System.Drawing.Size(180, 25);
            this.txt_penerbit_buku.Name = "txt_penerbit_buku";
            this.txt_penerbit_buku.Size = new System.Drawing.Size(180, 25);
            this.txt_penerbit_buku.TabIndex = 36;
            // 
            // txt_penulis_buku
            // 
            this.txt_penulis_buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_penulis_buku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penulis_buku.Location = new System.Drawing.Point(54, 224);
            this.txt_penulis_buku.MinimumSize = new System.Drawing.Size(373, 25);
            this.txt_penulis_buku.Name = "txt_penulis_buku";
            this.txt_penulis_buku.Size = new System.Drawing.Size(373, 25);
            this.txt_penulis_buku.TabIndex = 35;
            // 
            // txt_judul_buku
            // 
            this.txt_judul_buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_judul_buku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_judul_buku.Location = new System.Drawing.Point(54, 168);
            this.txt_judul_buku.MinimumSize = new System.Drawing.Size(373, 25);
            this.txt_judul_buku.Name = "txt_judul_buku";
            this.txt_judul_buku.Size = new System.Drawing.Size(373, 25);
            this.txt_judul_buku.TabIndex = 34;
            // 
            // txt_kode_buku
            // 
            this.txt_kode_buku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kode_buku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kode_buku.Location = new System.Drawing.Point(52, 112);
            this.txt_kode_buku.MinimumSize = new System.Drawing.Size(373, 25);
            this.txt_kode_buku.Name = "txt_kode_buku";
            this.txt_kode_buku.ReadOnly = true;
            this.txt_kode_buku.Size = new System.Drawing.Size(373, 25);
            this.txt_kode_buku.TabIndex = 33;
            // 
            // DetailBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.btn_add_jenis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_jenis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_isbn);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_tahun_terbit);
            this.Controls.Add(this.txt_penerbit_buku);
            this.Controls.Add(this.txt_penulis_buku);
            this.Controls.Add(this.txt_judul_buku);
            this.Controls.Add(this.txt_kode_buku);
            this.Controls.Add(this.btn_delete);
            this.MinimumSize = new System.Drawing.Size(500, 478);
            this.Name = "DetailBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Buku";
            this.Load += new System.EventHandler(this.DetailBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add_jenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_jenis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_isbn;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_tahun_terbit;
        private System.Windows.Forms.TextBox txt_penerbit_buku;
        private System.Windows.Forms.TextBox txt_penulis_buku;
        private System.Windows.Forms.TextBox txt_judul_buku;
        private System.Windows.Forms.TextBox txt_kode_buku;
    }
}
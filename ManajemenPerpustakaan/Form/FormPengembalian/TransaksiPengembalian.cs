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
    public partial class TransaksiPengembalian : Form
    {
        Utils utils = new Utils(Var.url);
        public TransaksiPengembalian()
        {
            InitializeComponent();
        }

        private void TransaksiPengembalian_Load(object sender, EventArgs e)
        {
            utils.readToDataGrid("SELECT kode_peminjaman KodePeminjaman, nis NIS, nama Nama, kelas Kelas, borrow_date, due_date FROM tb_peminjaman WHERE status='pinjam'", dgv_peminjaman);
            string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
            txb_date_kembali.Text = date;

            dgv_peminjaman.Columns["borrow_date"].Visible = false;
            dgv_peminjaman.Columns["due_date"].Visible = false;
        }

        private void dgv_peminjaman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_peminjaman.Rows[e.RowIndex];

                string date_pinjam = DateTime.Parse(row.Cells["borrow_date"].Value.ToString()).ToString("dd/MM/yyyy");
                string due_date = DateTime.Parse(row.Cells["due_date"].Value.ToString()).ToString("dd/MM/yyyy");
                DateTime firstDate = DateTime.Parse(row.Cells["due_date"].Value.ToString());
                DateTime dateNow = DateTime.Now.Date;
                TimeSpan count_date = dateNow - firstDate;
                int totalDate = Convert.ToInt32(count_date.TotalDays);

                txb_kode.Text = row.Cells[0].Value.ToString();
                txb_date_pinjam.Text = date_pinjam;
                txb_due_date.Text = due_date;

            }
        }

        private void txb_kode_TextChanged(object sender, EventArgs e)
        {
            if (txb_kode.Text != "")
            {
                utils.readToDataGrid("SELECT tb_buku.kode_buku KodeBuku, tb_buku.judul_buku JudulBuku FROM tb_detail_peminjaman INNER JOIN tb_buku ON tb_detail_peminjaman.kode_buku=tb_buku.kode_buku WHERE kode_peminjaman='"+txb_kode.Text+"'", dgv_list_buku);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE tb_peminjaman SET pengembalian_date=getDate(), status='selesai'";
            utils.update(query);
        }
    }
}

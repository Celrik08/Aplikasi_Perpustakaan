using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class DataPegawai : Form
    {
        private int roleId;
        private int selectedRowIndex = -1;
        private bool isTambahMode = true;
        public DataPegawai(int roleId)
        {
            InitializeComponent();
            //this.FormClosing += DataPegawai_FormClosing;
            this.roleId = roleId;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                RadioLaki.Focus();
            }
        }

        private void RadioLaki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                RadioPerempuan.Focus();
            }
        }

        private void RadioPerempuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextAlamat.Focus();
            }
        }

        private void TextAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextNo.Focus();
            }
        }

        private void TextNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextTempat.Focus();
            }
        }

        private void TextTempat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                Date.Focus();
            }
        }

        private void Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromPegawai();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerfromPegawai();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(TextNama.Text) ||
                (RadioLaki.Checked == false && RadioPerempuan.Checked == false) ||
                string.IsNullOrWhiteSpace(TextAlamat.Text) ||
                string.IsNullOrWhiteSpace(TextNo.Text) ||
                string.IsNullOrWhiteSpace(TextTempat.Text) ||
                Date.Value == DateTime.Today) // Cek apakah tanggal lahir sama dengan hari ini
            {
                MessageBox.Show("Semua kolom harus diisi dan tanggal lahir harus valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerfromPegawai()
        {
            if (!IsFormValid())
            {
                return;
            }

            string nama = TextNama.Text;
            string jenis = RadioLaki.Checked ? "Laki-Laki" : "Perempuan";
            string alamat = TextAlamat.Text;
            string nomor = TextNo.Text;
            string tempat = TextTempat.Text;
            DateTime tanggal = Date.Value; // Ambil nilai dari DateTimePicker

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_pegawai (nama_pegawai, jenis_kelamin, alamat, no_hp, tempat_lahir, tanggal_lahir) VALUES (@nama_pegawai, @jenis_kelamin, @alamat, @no_hp, @tempat_lahir, @tanggal_lahir)";
                cmd.Parameters.AddWithValue("@nama_pegawai", nama);
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@no_hp", nomor);
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat);
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Set nilai kontrol kembali ke nilai default
            TextNama.Clear();
            RadioLaki.Checked = false;
            RadioPerempuan.Checked = false;
            TextAlamat.Clear();
            TextNo.Clear();
            TextTempat.Clear();
            Date.Value = DateTime.Today;

            BtnSimpan.Enabled = false;

            //LoadDataToDataGridView();
        }
    }
}

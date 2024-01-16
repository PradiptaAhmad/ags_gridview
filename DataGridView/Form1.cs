namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbKelas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKelas.SelectedIndex = -1;
            cbAgama.DropDownStyle = ComboBoxStyle.DropDownList; 
            cbAgama.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = txtId.Text;
            string alamat = txtAlamat.Text;
            string jk = "";
            if (rbLaki.Checked == true)
            {
                jk = "Laki-laki";
            }
            else if (rbPerempuan.Checked == true)
            {
                jk = "Perempuan";
            }

            MessageBox.Show("Nama anda adalah : " + txtId.Text + "\nAlamat anda :" + txtAlamat.Text + "\nJenis Kelamin : " + jk, "Biodata");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(txtId.Text);
            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string kelas = cbKelas.SelectedItem.ToString();
            string agama = cbAgama.SelectedItem.ToString();
            string hobi = "";
            string jk = "";
            if (cboxMakan.Checked == true)
            {
                hobi = "Makan";
            }
            else if (cboxRebahan.Checked == true)
            {
                hobi = "Rebahan";
            }
            else if (cboxTidur.Checked == true)
            {
                hobi = "Tidur";
            }
            else if (cboxTidurV2.Checked == true)
            {
                hobi = "Tidur tapi lebih lama";
            }
            if (rbLaki.Checked == true)
            {
                jk = "Laki-laki";
            }
            else if (rbPerempuan.Checked == true)
            {
                jk = "Perempuan";
            }

            dataGridView1.Rows.Add(id, nama, kelas, agama, hobi, alamat, jk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNama.Text = "";
            cbKelas.SelectedIndex = -1;
            cbAgama.SelectedIndex = -1;
            cboxMakan.Checked = false;
            cboxRebahan.Checked = false;
            cboxTidur.Checked = false;
            cboxTidurV2.Checked = false;
            txtAlamat.Text = "";
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the key is not a number and not a control key, ignore it
                e.Handled = true;
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If the key is not an alphabet character and not a control key, ignore it
                e.Handled = true;
            }
        }
    }
}
namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtAlamat = new RichTextBox();
            rbLaki = new RadioButton();
            rbPerempuan = new RadioButton();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Kelas = new DataGridViewTextBoxColumn();
            Agama = new DataGridViewTextBoxColumn();
            Hobi = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            JenisKelamin = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtNama = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cbKelas = new ComboBox();
            cbAgama = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            cboxMakan = new CheckBox();
            cboxTidur = new CheckBox();
            cboxRebahan = new CheckBox();
            cboxTidurV2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 75);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "No. ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 280);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Alamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 197);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 197);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 280);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 4;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 75);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 75);
            txtId.Name = "txtId";
            txtId.Size = new Size(230, 23);
            txtId.TabIndex = 6;
            txtId.TextChanged += txtId_TextChanged;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(141, 277);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(230, 53);
            txtAlamat.TabIndex = 7;
            txtAlamat.Text = "";
            // 
            // rbLaki
            // 
            rbLaki.AutoSize = true;
            rbLaki.Location = new Point(142, 197);
            rbLaki.Name = "rbLaki";
            rbLaki.Size = new Size(70, 19);
            rbLaki.TabIndex = 8;
            rbLaki.TabStop = true;
            rbLaki.Text = "Laki Laki";
            rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Location = new Point(218, 197);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(86, 19);
            rbPerempuan.TabIndex = 9;
            rbPerempuan.TabStop = true;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            rbPerempuan.CheckedChanged += rbPerempuan_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(137, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Tampilkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(354, 35);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 11;
            label7.Text = "BIODATA";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(713, 542);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nama, Kelas, Agama, Hobi, Alamat, JenisKelamin });
            dataGridView1.Location = new Point(41, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(747, 171);
            dataGridView1.TabIndex = 13;
            // 
            // id
            // 
            id.HeaderText = "No. ID";
            id.Name = "id";
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            // 
            // Kelas
            // 
            Kelas.HeaderText = "Kelas";
            Kelas.Name = "Kelas";
            // 
            // Agama
            // 
            Agama.HeaderText = "Agama";
            Agama.Name = "Agama";
            // 
            // Hobi
            // 
            Hobi.HeaderText = "Hobi";
            Hobi.Name = "Hobi";
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.Name = "Alamat";
            // 
            // JenisKelamin
            // 
            JenisKelamin.HeaderText = "Jenis Kelamin";
            JenisKelamin.Name = "JenisKelamin";
            // 
            // button3
            // 
            button3.Location = new Point(388, 75);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Tambah";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(388, 104);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(388, 133);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "Clear";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(141, 104);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(230, 23);
            txtNama.TabIndex = 19;
            txtNama.KeyPress += txtNama_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 104);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 18;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 104);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 17;
            label9.Text = "Nama Lengkap";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 138);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 20;
            label10.Text = "Kelas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 171);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 21;
            label11.Text = "Agama";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(125, 171);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 22;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(125, 138);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 23;
            label13.Text = ":";
            // 
            // cbKelas
            // 
            cbKelas.FormattingEnabled = true;
            cbKelas.Items.AddRange(new object[] { "XI PPLG 2", "XI PPLG 1" });
            cbKelas.Location = new Point(141, 134);
            cbKelas.Name = "cbKelas";
            cbKelas.Size = new Size(121, 23);
            cbKelas.TabIndex = 24;
            // 
            // cbAgama
            // 
            cbAgama.FormattingEnabled = true;
            cbAgama.Items.AddRange(new object[] { "Islam", "Kristen", "Katolik", "Budha", "Hindu", "Konghucu" });
            cbAgama.Location = new Point(141, 168);
            cbAgama.Name = "cbAgama";
            cbAgama.Size = new Size(121, 23);
            cbAgama.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 227);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 26;
            label14.Text = "Hobi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(125, 227);
            label15.Name = "label15";
            label15.Size = new Size(10, 15);
            label15.TabIndex = 27;
            label15.Text = ":";
            // 
            // cboxMakan
            // 
            cboxMakan.AutoSize = true;
            cboxMakan.Location = new Point(142, 227);
            cboxMakan.Name = "cboxMakan";
            cboxMakan.Size = new Size(62, 19);
            cboxMakan.TabIndex = 28;
            cboxMakan.Text = "Makan";
            cboxMakan.UseVisualStyleBackColor = true;
            // 
            // cboxTidur
            // 
            cboxTidur.AutoSize = true;
            cboxTidur.Location = new Point(218, 227);
            cboxTidur.Name = "cboxTidur";
            cboxTidur.Size = new Size(53, 19);
            cboxTidur.TabIndex = 29;
            cboxTidur.Text = "Tidur";
            cboxTidur.UseVisualStyleBackColor = true;
            // 
            // cboxRebahan
            // 
            cboxRebahan.AutoSize = true;
            cboxRebahan.Location = new Point(141, 252);
            cboxRebahan.Name = "cboxRebahan";
            cboxRebahan.Size = new Size(72, 19);
            cboxRebahan.TabIndex = 30;
            cboxRebahan.Text = "Rebahan";
            cboxRebahan.UseVisualStyleBackColor = true;
            // 
            // cboxTidurV2
            // 
            cboxTidurV2.AutoSize = true;
            cboxTidurV2.Location = new Point(219, 252);
            cboxTidurV2.Name = "cboxTidurV2";
            cboxTidurV2.Size = new Size(134, 19);
            cboxTidurV2.TabIndex = 31;
            cboxTidurV2.Text = "Tidur tapi lebih lama";
            cboxTidurV2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(cboxTidurV2);
            Controls.Add(cboxRebahan);
            Controls.Add(cboxTidur);
            Controls.Add(cboxMakan);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(cbAgama);
            Controls.Add(cbKelas);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(rbPerempuan);
            Controls.Add(rbLaki);
            Controls.Add(txtAlamat);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private RichTextBox txtAlamat;
        private RadioButton rbLaki;
        private RadioButton rbPerempuan;
        private Button button1;
        private Label label7;
        private Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtNama;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cbKelas;
        private ComboBox cbAgama;
        private Label label14;
        private Label label15;
        private CheckBox cboxMakan;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Kelas;
        private DataGridViewTextBoxColumn Agama;
        private DataGridViewTextBoxColumn Hobi;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn JenisKelamin;
        private CheckBox cboxTidur;
        private CheckBox cboxRebahan;
        private CheckBox cboxTidurV2;
    }
}
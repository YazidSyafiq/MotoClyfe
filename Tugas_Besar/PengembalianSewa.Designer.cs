namespace Tugas_Besar
{
    partial class PengembalianSewa
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
            this.btnBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewSewa = new System.Windows.Forms.DataGridView();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.tbPabrikan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPlat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.tbTahunMotor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJenisMotor = new System.Windows.Forms.TextBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbNamaMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSewa)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1046, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1149, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(42, 39);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "X";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.label12);
            this.groupBoxData.Controls.Add(this.label13);
            this.groupBoxData.Controls.Add(this.label14);
            this.groupBoxData.Controls.Add(this.dataGridViewSewa);
            this.groupBoxData.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.Location = new System.Drawing.Point(12, 77);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(711, 533);
            this.groupBoxData.TabIndex = 19;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data Sewa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(594, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Klik pada data tersebut untuk memasukkan datanya kebagian pengajuan pengembalian";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(533, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Untuk mengajukan pengembalian, pilih data motor yang sesuai terlebih dahulu. ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Note :";
            // 
            // dataGridViewSewa
            // 
            this.dataGridViewSewa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSewa.Location = new System.Drawing.Point(11, 32);
            this.dataGridViewSewa.Name = "dataGridViewSewa";
            this.dataGridViewSewa.RowHeadersWidth = 51;
            this.dataGridViewSewa.RowTemplate.Height = 24;
            this.dataGridViewSewa.Size = new System.Drawing.Size(694, 426);
            this.dataGridViewSewa.TabIndex = 0;
            this.dataGridViewSewa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSewa_CellContentClick);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.tbPabrikan);
            this.groupBoxInput.Controls.Add(this.label11);
            this.groupBoxInput.Controls.Add(this.label10);
            this.groupBoxInput.Controls.Add(this.label9);
            this.groupBoxInput.Controls.Add(this.tbPlat);
            this.groupBoxInput.Controls.Add(this.label7);
            this.groupBoxInput.Controls.Add(this.btnPengembalian);
            this.groupBoxInput.Controls.Add(this.tbTahunMotor);
            this.groupBoxInput.Controls.Add(this.label6);
            this.groupBoxInput.Controls.Add(this.tbJenisMotor);
            this.groupBoxInput.Controls.Add(this.tbCC);
            this.groupBoxInput.Controls.Add(this.tbNamaMotor);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.tbUsername);
            this.groupBoxInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInput.Location = new System.Drawing.Point(743, 77);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(448, 533);
            this.groupBoxInput.TabIndex = 20;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Pengembalian Motor";
            // 
            // tbPabrikan
            // 
            this.tbPabrikan.Location = new System.Drawing.Point(202, 199);
            this.tbPabrikan.Name = "tbPabrikan";
            this.tbPabrikan.Size = new System.Drawing.Size(228, 33);
            this.tbPabrikan.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "cek kelengkapan motor terlebih dahulu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Sebelum melakukan pengajuan pengembalian,";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Note :";
            // 
            // tbPlat
            // 
            this.tbPlat.Location = new System.Drawing.Point(202, 349);
            this.tbPlat.Name = "tbPlat";
            this.tbPlat.Size = new System.Drawing.Size(228, 33);
            this.tbPlat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Plat Nomor";
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.Blue;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPengembalian.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.ForeColor = System.Drawing.Color.White;
            this.btnPengembalian.Location = new System.Drawing.Point(11, 408);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(419, 50);
            this.btnPengembalian.TabIndex = 12;
            this.btnPengembalian.Text = "Ajukan Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // tbTahunMotor
            // 
            this.tbTahunMotor.Location = new System.Drawing.Point(202, 299);
            this.tbTahunMotor.Name = "tbTahunMotor";
            this.tbTahunMotor.Size = new System.Drawing.Size(228, 33);
            this.tbTahunMotor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tahun Pembuatan";
            // 
            // tbJenisMotor
            // 
            this.tbJenisMotor.Location = new System.Drawing.Point(202, 149);
            this.tbJenisMotor.Name = "tbJenisMotor";
            this.tbJenisMotor.Size = new System.Drawing.Size(228, 33);
            this.tbJenisMotor.TabIndex = 8;
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(202, 249);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(228, 33);
            this.tbCC.TabIndex = 7;
            // 
            // tbNamaMotor
            // 
            this.tbNamaMotor.Location = new System.Drawing.Point(202, 99);
            this.tbNamaMotor.Name = "tbNamaMotor";
            this.tbNamaMotor.Size = new System.Drawing.Size(228, 33);
            this.tbNamaMotor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ukuran Mesin (cc)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pabrikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Motor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Motor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(202, 49);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(228, 33);
            this.tbUsername.TabIndex = 0;
            // 
            // PengembalianSewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 622);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PengembalianSewa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PengembalianSewaUser";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSewa)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewSewa;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPlat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.TextBox tbTahunMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJenisMotor;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbNamaMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPabrikan;
    }
}
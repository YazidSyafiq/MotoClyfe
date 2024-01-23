namespace Tugas_Besar
{
    partial class PersediaanMotorAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.cbJenisMotor = new System.Windows.Forms.ComboBox();
            this.cbStatusMotor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbPlat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPabrikan = new System.Windows.Forms.ComboBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbTahunMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaMotor = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewPersediaanMotor = new System.Windows.Forms.DataGridView();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersediaanMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1370, 12);
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
            this.buttonExit.Location = new System.Drawing.Point(1473, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(42, 39);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "X";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.cbJenisMotor);
            this.groupBoxInput.Controls.Add(this.cbStatusMotor);
            this.groupBoxInput.Controls.Add(this.label7);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Controls.Add(this.btnUpdate);
            this.groupBoxInput.Controls.Add(this.btnInput);
            this.groupBoxInput.Controls.Add(this.tbPlat);
            this.groupBoxInput.Controls.Add(this.label6);
            this.groupBoxInput.Controls.Add(this.cbPabrikan);
            this.groupBoxInput.Controls.Add(this.tbCC);
            this.groupBoxInput.Controls.Add(this.tbTahunMotor);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.tbNamaMotor);
            this.groupBoxInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInput.Location = new System.Drawing.Point(12, 63);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(444, 515);
            this.groupBoxInput.TabIndex = 13;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input Data";
            // 
            // cbJenisMotor
            // 
            this.cbJenisMotor.FormattingEnabled = true;
            this.cbJenisMotor.Items.AddRange(new object[] {
            "Matic",
            "Bebek (Cub)",
            "Kopling"});
            this.cbJenisMotor.Location = new System.Drawing.Point(202, 99);
            this.cbJenisMotor.Name = "cbJenisMotor";
            this.cbJenisMotor.Size = new System.Drawing.Size(228, 38);
            this.cbJenisMotor.TabIndex = 18;
            // 
            // cbStatusMotor
            // 
            this.cbStatusMotor.FormattingEnabled = true;
            this.cbStatusMotor.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak Tersedia"});
            this.cbStatusMotor.Location = new System.Drawing.Point(202, 349);
            this.cbStatusMotor.Name = "cbStatusMotor";
            this.cbStatusMotor.Size = new System.Drawing.Size(228, 38);
            this.cbStatusMotor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(120, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Hapus Data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(233, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.Blue;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(16, 418);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(191, 34);
            this.btnInput.TabIndex = 12;
            this.btnInput.Text = "Tambah Data";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbPlat
            // 
            this.tbPlat.Location = new System.Drawing.Point(202, 299);
            this.tbPlat.Name = "tbPlat";
            this.tbPlat.Size = new System.Drawing.Size(228, 33);
            this.tbPlat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plat Nomor";
            // 
            // cbPabrikan
            // 
            this.cbPabrikan.FormattingEnabled = true;
            this.cbPabrikan.Items.AddRange(new object[] {
            "Honda",
            "Yamaha",
            "Suzuki",
            "Kawasaki",
            "Vespa",
            "Gesits"});
            this.cbPabrikan.Location = new System.Drawing.Point(202, 149);
            this.cbPabrikan.Name = "cbPabrikan";
            this.cbPabrikan.Size = new System.Drawing.Size(228, 38);
            this.cbPabrikan.TabIndex = 9;
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(202, 199);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(228, 33);
            this.tbCC.TabIndex = 8;
            // 
            // tbTahunMotor
            // 
            this.tbTahunMotor.Location = new System.Drawing.Point(202, 249);
            this.tbTahunMotor.Name = "tbTahunMotor";
            this.tbTahunMotor.Size = new System.Drawing.Size(228, 33);
            this.tbTahunMotor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tahun Pembuatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ukuran Mesin (cc)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pabrikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Motor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Motor";
            // 
            // tbNamaMotor
            // 
            this.tbNamaMotor.Location = new System.Drawing.Point(202, 49);
            this.tbNamaMotor.Name = "tbNamaMotor";
            this.tbNamaMotor.Size = new System.Drawing.Size(228, 33);
            this.tbNamaMotor.TabIndex = 0;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.label13);
            this.groupBoxData.Controls.Add(this.label14);
            this.groupBoxData.Controls.Add(this.dataGridViewPersediaanMotor);
            this.groupBoxData.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.Location = new System.Drawing.Point(476, 63);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(1039, 515);
            this.groupBoxData.TabIndex = 14;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data Motor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(405, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "Untuk update dan delete data, pilih datanya terlebih dahulu.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Note :";
            // 
            // dataGridViewPersediaanMotor
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPersediaanMotor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPersediaanMotor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersediaanMotor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewPersediaanMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersediaanMotor.Location = new System.Drawing.Point(7, 33);
            this.dataGridViewPersediaanMotor.Name = "dataGridViewPersediaanMotor";
            this.dataGridViewPersediaanMotor.RowHeadersWidth = 51;
            this.dataGridViewPersediaanMotor.RowTemplate.Height = 24;
            this.dataGridViewPersediaanMotor.Size = new System.Drawing.Size(1026, 437);
            this.dataGridViewPersediaanMotor.TabIndex = 0;
            this.dataGridViewPersediaanMotor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersediaanMotor_CellContentClick);
            // 
            // PersediaanMotorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 584);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersediaanMotorAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersediaanMotorForAdmin";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersediaanMotor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbTahunMotor;
        private System.Windows.Forms.ComboBox cbPabrikan;
        private System.Windows.Forms.TextBox tbPlat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewPersediaanMotor;
        private System.Windows.Forms.ComboBox cbStatusMotor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJenisMotor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
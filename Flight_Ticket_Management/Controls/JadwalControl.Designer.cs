namespace Flight_Ticket_Management.Controls
{
    partial class JadwalControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvwJadwal = new System.Windows.Forms.ListView();
            this.columnMaskapai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJenisPesawat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWaktuKeberangkatan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWaktuSampai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAsal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTujuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnNo
            // 
            this.columnNo.Text = "No";
            this.columnNo.Width = 54;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Controls.Add(this.btnDetails);
            this.mainPanel.Controls.Add(this.btnTest);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.lvwJadwal);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1480, 802);
            this.mainPanel.TabIndex = 2;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Bankai Demo Version", 14F);
            this.btnDetails.Location = new System.Drawing.Point(1254, 738);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDetails.Size = new System.Drawing.Size(200, 50);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Bankai Demo Version", 14F);
            this.btnTest.Location = new System.Drawing.Point(1022, 738);
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTest.Size = new System.Drawing.Size(200, 50);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(158, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1320, 1);
            this.label12.TabIndex = 2;
            this.label12.Text = "sadf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bankai Demo Version", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 45);
            this.label10.TabIndex = 0;
            this.label10.Text = "Jadwal";
            // 
            // lvwJadwal
            // 
            this.lvwJadwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwJadwal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columnMaskapai,
            this.columnJenisPesawat,
            this.columnWaktuKeberangkatan,
            this.columnWaktuSampai,
            this.columnHarga,
            this.columnAsal,
            this.columnTujuan});
            this.lvwJadwal.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwJadwal.FullRowSelect = true;
            this.lvwJadwal.GridLines = true;
            this.lvwJadwal.HideSelection = false;
            this.lvwJadwal.Location = new System.Drawing.Point(19, 112);
            this.lvwJadwal.Name = "lvwJadwal";
            this.lvwJadwal.Size = new System.Drawing.Size(1435, 605);
            this.lvwJadwal.TabIndex = 1;
            this.lvwJadwal.UseCompatibleStateImageBehavior = false;
            this.lvwJadwal.View = System.Windows.Forms.View.Details;
            // 
            // columnMaskapai
            // 
            this.columnMaskapai.Text = "Maskapai";
            this.columnMaskapai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMaskapai.Width = 251;
            // 
            // columnJenisPesawat
            // 
            this.columnJenisPesawat.Text = "Jenis Pesawat";
            this.columnJenisPesawat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJenisPesawat.Width = 177;
            // 
            // columnWaktuKeberangkatan
            // 
            this.columnWaktuKeberangkatan.Text = "Keberangkatan";
            this.columnWaktuKeberangkatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWaktuKeberangkatan.Width = 183;
            // 
            // columnWaktuSampai
            // 
            this.columnWaktuSampai.Text = "Sampai";
            this.columnWaktuSampai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWaktuSampai.Width = 158;
            // 
            // columnHarga
            // 
            this.columnHarga.Text = "Harga";
            this.columnHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHarga.Width = 184;
            // 
            // columnAsal
            // 
            this.columnAsal.Text = "Asal";
            this.columnAsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAsal.Width = 207;
            // 
            // columnTujuan
            // 
            this.columnTujuan.Text = "Tujuan";
            this.columnTujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTujuan.Width = 215;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 1781);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 0;
            // 
            // JadwalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Bankai Demo Version", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JadwalControl";
            this.Size = new System.Drawing.Size(1480, 802);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnMaskapai;
        private System.Windows.Forms.ColumnHeader columnJenisPesawat;
        private System.Windows.Forms.ColumnHeader columnWaktuKeberangkatan;
        private System.Windows.Forms.ColumnHeader columnWaktuSampai;
        private System.Windows.Forms.ColumnHeader columnHarga;
        private System.Windows.Forms.ColumnHeader columnAsal;
        private System.Windows.Forms.ColumnHeader columnTujuan;
        private System.Windows.Forms.ListView lvwJadwal;
        private System.Windows.Forms.ColumnHeader columnNo;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnTest;
    }
}

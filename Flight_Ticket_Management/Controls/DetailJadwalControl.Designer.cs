namespace Flight_Ticket_Management.Controls
{
    partial class DetailJadwalControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNextToKeterangan = new System.Windows.Forms.Button();
            this.btnBackToJadwal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnBackToJadwal);
            this.panel1.Controls.Add(this.btnNextToKeterangan);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pnlDetail);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 802);
            this.panel1.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.Gray;
            this.pnlDetail.Location = new System.Drawing.Point(39, 138);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1395, 630);
            this.pnlDetail.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(375, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1098, 1);
            this.label12.TabIndex = 4;
            this.label12.Text = "sadf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bankai Demo Version", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 45);
            this.label10.TabIndex = 3;
            this.label10.Text = "Detail Penerbangan";
            // 
            // btnNextToKeterangan
            // 
            this.btnNextToKeterangan.BackColor = System.Drawing.Color.DarkGray;
            this.btnNextToKeterangan.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnNextToKeterangan.FlatAppearance.BorderSize = 0;
            this.btnNextToKeterangan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextToKeterangan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextToKeterangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextToKeterangan.Font = new System.Drawing.Font("Bankai Demo Version", 14F);
            this.btnNextToKeterangan.Location = new System.Drawing.Point(1413, 14);
            this.btnNextToKeterangan.Name = "btnNextToKeterangan";
            this.btnNextToKeterangan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNextToKeterangan.Size = new System.Drawing.Size(60, 40);
            this.btnNextToKeterangan.TabIndex = 7;
            this.btnNextToKeterangan.Text = "-->";
            this.btnNextToKeterangan.UseVisualStyleBackColor = false;
            this.btnNextToKeterangan.MouseEnter += new System.EventHandler(this.btnNextToKeterangan_MouseEnter);
            this.btnNextToKeterangan.MouseLeave += new System.EventHandler(this.btnNextToKeterangan_MouseLeave);
            // 
            // btnBackToJadwal
            // 
            this.btnBackToJadwal.BackColor = System.Drawing.Color.DarkGray;
            this.btnBackToJadwal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnBackToJadwal.FlatAppearance.BorderSize = 0;
            this.btnBackToJadwal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackToJadwal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackToJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToJadwal.Font = new System.Drawing.Font("Bankai Demo Version", 14F);
            this.btnBackToJadwal.Location = new System.Drawing.Point(3, 14);
            this.btnBackToJadwal.Name = "btnBackToJadwal";
            this.btnBackToJadwal.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBackToJadwal.Size = new System.Drawing.Size(60, 40);
            this.btnBackToJadwal.TabIndex = 8;
            this.btnBackToJadwal.Text = "<--";
            this.btnBackToJadwal.UseVisualStyleBackColor = false;
            this.btnBackToJadwal.Click += new System.EventHandler(this.btnBackToJadwal_Click);
            this.btnBackToJadwal.MouseEnter += new System.EventHandler(this.btnBackToJadwal_MouseEnter);
            this.btnBackToJadwal.MouseLeave += new System.EventHandler(this.btnBackToJadwal_MouseLeave);
            // 
            // DetailJadwalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bankai Demo Version", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetailJadwalControl";
            this.Size = new System.Drawing.Size(1476, 802);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBackToJadwal;
        private System.Windows.Forms.Button btnNextToKeterangan;
    }
}

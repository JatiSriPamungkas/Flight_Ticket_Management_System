namespace Flight_Ticket_Management.Controls
{
    partial class PengaturanControl
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cmbKeberangkatan = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Controls.Add(this.btnSignOut);
            this.mainPanel.Controls.Add(this.panel12);
            this.mainPanel.Controls.Add(this.label21);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1476, 802);
            this.mainPanel.TabIndex = 3;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Bankai Demo Version", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.btnSignOut.Location = new System.Drawing.Point(483, 645);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(522, 48);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.cmbKeberangkatan);
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panel12.Location = new System.Drawing.Point(700, 405);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 50);
            this.panel12.TabIndex = 48;
            // 
            // cmbKeberangkatan
            // 
            this.cmbKeberangkatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKeberangkatan.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKeberangkatan.FormattingEnabled = true;
            this.cmbKeberangkatan.ItemHeight = 42;
            this.cmbKeberangkatan.Location = new System.Drawing.Point(0, -1);
            this.cmbKeberangkatan.Name = "cmbKeberangkatan";
            this.cmbKeberangkatan.Size = new System.Drawing.Size(199, 50);
            this.cmbKeberangkatan.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Aclonica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(559, 415);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 26);
            this.label21.TabIndex = 47;
            this.label21.Text = "Tema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flight_Ticket_Management.Properties.Resources.Demon_Girl_Flipped;
            this.pictureBox1.Location = new System.Drawing.Point(629, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 1781);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 0;
            // 
            // PengaturanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Bankai Demo Version", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PengaturanControl";
            this.Size = new System.Drawing.Size(1476, 802);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cmbKeberangkatan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSignOut;
    }
}

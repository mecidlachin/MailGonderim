namespace MailGonderim
{
    partial class AnaForm
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblGonderimDurumu = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(203, 47);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(302, 31);
            this.txtMail.TabIndex = 0;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(203, 84);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(302, 31);
            this.txtMesaj.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(131, 47);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 23);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(12, 87);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(171, 23);
            this.lblMesaj.TabIndex = 3;
            this.lblMesaj.Text = "Gönderilecek Mesaj :";
            // 
            // lblGonderimDurumu
            // 
            this.lblGonderimDurumu.AutoSize = true;
            this.lblGonderimDurumu.Location = new System.Drawing.Point(20, 277);
            this.lblGonderimDurumu.Name = "lblGonderimDurumu";
            this.lblGonderimDurumu.Size = new System.Drawing.Size(157, 23);
            this.lblGonderimDurumu.TabIndex = 4;
            this.lblGonderimDurumu.Text = "Gönderim Durumu";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(324, 170);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(181, 38);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(324, 121);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(181, 38);
            this.btnDosyaSec.TabIndex = 6;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(20, 238);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(0, 23);
            this.lblDosyaAdi.TabIndex = 7;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(526, 320);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.lblGonderimDurumu);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtMail);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblGonderimDurumu;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Label lblDosyaAdi;
    }
}


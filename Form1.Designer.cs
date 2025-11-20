namespace KareAlanHesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Gerekli tasarım değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
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
        ///  Tasarımcı desteği için gerekli metot - bu metodun 
        ///  içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKenar = new System.Windows.Forms.Label();
            this.txtKenar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Location = new System.Drawing.Point(24, 29);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(111, 20);
            this.lblKenar.TabIndex = 0;
            this.lblKenar.Text = "Kenar Uzunluğu:";
            // 
            // txtKenar
            // 
            this.txtKenar.Location = new System.Drawing.Point(140, 26);
            this.txtKenar.Name = "txtKenar";
            this.txtKenar.Size = new System.Drawing.Size(125, 27);
            this.txtKenar.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(24, 75);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 29);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(171, 75);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 29);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(24, 123);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 20);
            this.lblSonuc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 168);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKenar);
            this.Controls.Add(this.lblKenar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kare Alan Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.TextBox txtKenar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblSonuc;
    }
}
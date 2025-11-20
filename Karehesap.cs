using System;
using System.Windows.Forms;

namespace KareAlanHesapla
{
    public partial class Form1 : Form
    {
        private Label lblKenar;
        private TextBox txtKenar;
        private Button btnHesapla;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblKenar = new Label();
            this.txtKenar = new TextBox();
            this.btnHesapla = new Button();

            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Location = new System.Drawing.Point(20, 20);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(180, 13);
            this.lblKenar.TabIndex = 0;
            this.lblKenar.Text = "Karenin bir kenar uzunluğunu giriniz:";

            // 
            // txtKenar
            // 
            this.txtKenar.Location = new System.Drawing.Point(210, 17);
            this.txtKenar.Name = "txtKenar";
            this.txtKenar.Size = new System.Drawing.Size(100, 20);
            this.txtKenar.TabIndex = 1;

            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(110, 60);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 30);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(340, 110);
            this.Controls.Add(this.lblKenar);
            this.Controls.Add(this.txtKenar);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Kare Alan Hesaplama";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Bu aşamada sadece 1, 2 ve 3. maddeler uygulanıyor.
            // Alan hesaplanmasının ve sonucu ekrana yazdırmanın kodu ileriki adımlarda eklenecek.
        }
    }
}
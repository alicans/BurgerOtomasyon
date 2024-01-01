namespace HamburgerciForm
{
    partial class EkstraMalzemeEkleForm
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
            groupBox1 = new GroupBox();
            btnEMKaydet = new Button();
            nudEMFiyat = new NumericUpDown();
            label2 = new Label();
            txtEMAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEMFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEMKaydet);
            groupBox1.Controls.Add(nudEMFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEMAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Bilgileri";
            // 
            // btnEMKaydet
            // 
            btnEMKaydet.Location = new Point(125, 99);
            btnEMKaydet.Name = "btnEMKaydet";
            btnEMKaydet.Size = new Size(221, 63);
            btnEMKaydet.TabIndex = 4;
            btnEMKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnEMKaydet.UseVisualStyleBackColor = true;
            btnEMKaydet.Click += btnEMKaydet_Click;
            // 
            // nudEMFiyat
            // 
            nudEMFiyat.DecimalPlaces = 2;
            nudEMFiyat.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudEMFiyat.Location = new Point(125, 58);
            nudEMFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudEMFiyat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEMFiyat.Name = "nudEMFiyat";
            nudEMFiyat.Size = new Size(221, 23);
            nudEMFiyat.TabIndex = 3;
            nudEMFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtEMAdi
            // 
            txtEMAdi.Location = new Point(125, 22);
            txtEMAdi.Name = "txtEMAdi";
            txtEMAdi.Size = new Size(221, 23);
            txtEMAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // EkstraMalzemeEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "EkstraMalzemeEkleForm";
            ShowIcon = false;
            Text = "Ekstra Malzeme Ekle";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEMFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEMKaydet;
        private NumericUpDown nudEMFiyat;
        private Label label2;
        private TextBox txtEMAdi;
        private Label label1;
    }
}
namespace HamburgerciForm
{
    partial class MenuEkleForm
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
            btnKaydet = new Button();
            nudMenuFiyat = new NumericUpDown();
            label2 = new Label();
            txtMenuAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(nudMenuFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü Bilgileri";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(74, 102);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(221, 63);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "MENÜYÜ KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // nudMenuFiyat
            // 
            nudMenuFiyat.DecimalPlaces = 2;
            nudMenuFiyat.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudMenuFiyat.Location = new Point(74, 58);
            nudMenuFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMenuFiyat.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMenuFiyat.Name = "nudMenuFiyat";
            nudMenuFiyat.Size = new Size(221, 23);
            nudMenuFiyat.TabIndex = 3;
            nudMenuFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(74, 22);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(221, 23);
            txtMenuAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // MenuEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MenuEkleForm";
            ShowIcon = false;
            Text = "Menü Ekle";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudMenuFiyat;
        private Label label2;
        private TextBox txtMenuAdi;
        private Label label1;
        private Button btnKaydet;
    }
}
namespace HamburgerciForm
{
    partial class SiparisEklemeForm
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
            pbHamburger = new PictureBox();
            label1 = new Label();
            cmbMenuSec = new ComboBox();
            lstSiparis = new ListBox();
            groupBox1 = new GroupBox();
            pnlBoyut = new Panel();
            rbBuyuk = new RadioButton();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            grbMalzeme = new GroupBox();
            pnlMalzeme = new Panel();
            label2 = new Label();
            nudMenuAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            label3 = new Label();
            lblTopTutar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            groupBox1.SuspendLayout();
            pnlBoyut.SuspendLayout();
            grbMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuAdet).BeginInit();
            SuspendLayout();
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(11, 12);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(279, 120);
            pbHamburger.TabIndex = 0;
            pbHamburger.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ:";
            // 
            // cmbMenuSec
            // 
            cmbMenuSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuSec.FormattingEnabled = true;
            cmbMenuSec.Location = new Point(12, 165);
            cmbMenuSec.Name = "cmbMenuSec";
            cmbMenuSec.Size = new Size(278, 23);
            cmbMenuSec.TabIndex = 2;
            // 
            // lstSiparis
            // 
            lstSiparis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstSiparis.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstSiparis.FormattingEnabled = true;
            lstSiparis.ItemHeight = 22;
            lstSiparis.Location = new Point(296, 12);
            lstSiparis.Name = "lstSiparis";
            lstSiparis.Size = new Size(462, 576);
            lstSiparis.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlBoyut);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 57);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOYUT SEÇİNİZ";
            // 
            // pnlBoyut
            // 
            pnlBoyut.Controls.Add(rbBuyuk);
            pnlBoyut.Controls.Add(rbKucuk);
            pnlBoyut.Controls.Add(rbOrta);
            pnlBoyut.Location = new Point(6, 22);
            pnlBoyut.Name = "pnlBoyut";
            pnlBoyut.Size = new Size(266, 27);
            pnlBoyut.TabIndex = 0;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(205, 3);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(64, 21);
            rbBuyuk.TabIndex = 2;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(3, 3);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(63, 21);
            rbKucuk.TabIndex = 0;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(107, 3);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(53, 21);
            rbOrta.TabIndex = 1;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // grbMalzeme
            // 
            grbMalzeme.Controls.Add(pnlMalzeme);
            grbMalzeme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grbMalzeme.Location = new Point(12, 257);
            grbMalzeme.Name = "grbMalzeme";
            grbMalzeme.Size = new Size(278, 183);
            grbMalzeme.TabIndex = 5;
            grbMalzeme.TabStop = false;
            grbMalzeme.Text = "MALZEME SEÇİN";
            // 
            // pnlMalzeme
            // 
            pnlMalzeme.AutoScroll = true;
            pnlMalzeme.Location = new Point(6, 24);
            pnlMalzeme.Name = "pnlMalzeme";
            pnlMalzeme.Size = new Size(266, 153);
            pnlMalzeme.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 457);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 6;
            label2.Text = "ADET";
            // 
            // nudMenuAdet
            // 
            nudMenuAdet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nudMenuAdet.Location = new Point(65, 455);
            nudMenuAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMenuAdet.Name = "nudMenuAdet";
            nudMenuAdet.Size = new Size(225, 27);
            nudMenuAdet.TabIndex = 7;
            nudMenuAdet.TextAlign = HorizontalAlignment.Center;
            nudMenuAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(11, 530);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(278, 58);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(13, 492);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 9;
            label3.Text = "TOPLAM TUTAR:";
            // 
            // lblTopTutar
            // 
            lblTopTutar.AutoSize = true;
            lblTopTutar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopTutar.ForeColor = Color.Red;
            lblTopTutar.Location = new Point(186, 492);
            lblTopTutar.Name = "lblTopTutar";
            lblTopTutar.Size = new Size(67, 30);
            lblTopTutar.TabIndex = 10;
            lblTopTutar.Text = "₺0.00";
            // 
            // SiparisEklemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 595);
            Controls.Add(lblTopTutar);
            Controls.Add(label3);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudMenuAdet);
            Controls.Add(label2);
            Controls.Add(grbMalzeme);
            Controls.Add(groupBox1);
            Controls.Add(lstSiparis);
            Controls.Add(cmbMenuSec);
            Controls.Add(label1);
            Controls.Add(pbHamburger);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "SiparisEklemeForm";
            ShowIcon = false;
            Text = "Sipariş Ekle";
            WindowState = FormWindowState.Maximized;
            Load += SiparisEklemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            groupBox1.ResumeLayout(false);
            pnlBoyut.ResumeLayout(false);
            pnlBoyut.PerformLayout();
            grbMalzeme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMenuAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHamburger;
        private Label label1;
        private ComboBox cmbMenuSec;
        private ListBox lstSiparis;
        private GroupBox groupBox1;
        private RadioButton rbKucuk;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private GroupBox grbMalzeme;
        private Label label2;
        private NumericUpDown nudMenuAdet;
        private Button btnSiparisEkle;
        private Label label3;
        private Label lblTopTutar;
        private Panel pnlMalzeme;
        private Panel pnlBoyut;
    }
}
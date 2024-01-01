namespace HamburgerciForm
{
    partial class SiparisBilgileriForm
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
            label1 = new Label();
            lstTumSiparisler = new ListBox();
            gbCiro = new GroupBox();
            lblCiro = new Label();
            gbTopSiparis = new GroupBox();
            lblToplamSiparis = new Label();
            gbEkstraMalzeme = new GroupBox();
            lblEMGeliri = new Label();
            gbCiro.SuspendLayout();
            gbTopSiparis.SuspendLayout();
            gbEkstraMalzeme.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTumSiparisler.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 22;
            lstTumSiparisler.Location = new Point(12, 39);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(429, 532);
            lstTumSiparisler.TabIndex = 1;
            // 
            // gbCiro
            // 
            gbCiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbCiro.Controls.Add(lblCiro);
            gbCiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbCiro.Location = new Point(447, 39);
            gbCiro.Name = "gbCiro";
            gbCiro.Size = new Size(312, 94);
            gbCiro.TabIndex = 2;
            gbCiro.TabStop = false;
            gbCiro.Text = "CİRO";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(17, 35);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(77, 32);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "₺0.00";
            // 
            // gbTopSiparis
            // 
            gbTopSiparis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbTopSiparis.Controls.Add(lblToplamSiparis);
            gbTopSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbTopSiparis.Location = new Point(447, 139);
            gbTopSiparis.Name = "gbTopSiparis";
            gbTopSiparis.Size = new Size(312, 94);
            gbTopSiparis.TabIndex = 3;
            gbTopSiparis.TabStop = false;
            gbTopSiparis.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(17, 35);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(28, 32);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "0";
            // 
            // gbEkstraMalzeme
            // 
            gbEkstraMalzeme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbEkstraMalzeme.Controls.Add(lblEMGeliri);
            gbEkstraMalzeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbEkstraMalzeme.Location = new Point(447, 239);
            gbEkstraMalzeme.Name = "gbEkstraMalzeme";
            gbEkstraMalzeme.Size = new Size(312, 94);
            gbEkstraMalzeme.TabIndex = 3;
            gbEkstraMalzeme.TabStop = false;
            gbEkstraMalzeme.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEMGeliri
            // 
            lblEMGeliri.AutoSize = true;
            lblEMGeliri.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEMGeliri.ForeColor = Color.Red;
            lblEMGeliri.Location = new Point(17, 35);
            lblEMGeliri.Name = "lblEMGeliri";
            lblEMGeliri.Size = new Size(77, 32);
            lblEMGeliri.TabIndex = 0;
            lblEMGeliri.Text = "₺0.00";
            // 
            // SiparisBilgileriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 595);
            Controls.Add(gbEkstraMalzeme);
            Controls.Add(gbTopSiparis);
            Controls.Add(gbCiro);
            Controls.Add(lstTumSiparisler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "SiparisBilgileriForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Sipariş Bilgileri";
            WindowState = FormWindowState.Maximized;
            Load += SiparisBilgileriForm_Load;
            gbCiro.ResumeLayout(false);
            gbCiro.PerformLayout();
            gbTopSiparis.ResumeLayout(false);
            gbTopSiparis.PerformLayout();
            gbEkstraMalzeme.ResumeLayout(false);
            gbEkstraMalzeme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTumSiparisler;
        private GroupBox gbCiro;
        private Label lblCiro;
        private GroupBox gbTopSiparis;
        private Label lblToplamSiparis;
        private GroupBox gbEkstraMalzeme;
        private Label lblEMGeliri;
    }
}
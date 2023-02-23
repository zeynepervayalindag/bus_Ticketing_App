namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kADINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRKEKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "SEFER SORGULA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gidiş Tarihi";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "VARIŞ NOKTASI SEÇİNİZ",
            "İSTANBUL - AVRUPA ( ESENLER )",
            "İSTANBUL - AVRUPA ( ALİBEYKÖY )",
            "İSTANBUL - ANADOLU ( DUDULLU )",
            "İSTANBUL - ANADOLU ( HAREM )",
            "BURSA ",
            "ANKARA",
            "İZMİR ",
            "DENİZLİ",
            "ÇANAKKALE OTOGAR",
            "ÇANAKKALE İSKELE",
            "AFYON",
            "AKÇAKOCA",
            "AKÇAY",
            "AKHİSAR",
            "AKYAKA ( YOL AYRIMI )",
            "ALANYA",
            "ALAPLI",
            "ALAŞEHİR",
            "ALAŞEHİR OTOGAR",
            "ALİAĞA",
            "ALTINOLUK ",
            "ALTINOVA",
            "ANTALYA",
            "ATÇA",
            "AYDIN ",
            "AYVALIK",
            "BALIKESİR",
            "BANAZ",
            "BANDIRMA",
            "BAYIR",
            "BEKİLLİ",
            "BERGAMA",
            "BİGA",
            "BİLECİK ",
            "BODRUM",
            "BOZÜYÜK ",
            "BUCAK",
            "BUHARKENT",
            "BULDAN",
            "BURDUR",
            "BURHANİYE",
            "ÇANDARLI",
            "ÇİNE ",
            "ÇİVRİL",
            "ÇORLU",
            "ÇUBUCAK",
            "DALAMAN",
            "DARICA",
            "DATÇA",
            "DAZKIRI",
            "DEĞİRMENDERE",
            "DEVREK",
            "DİDİM",
            "DİKİLİ",
            "DİNAR ",
            "DÜZCE",
            "ECEABAT",
            "EDREMİT",
            "ERDEK",
            "ERİKLİ ( KEŞAN )",
            "EŞEN ",
            "ESKİŞEHİR",
            "EZİNE",
            "FETHİYE",
            "GEBZE",
            "GELİBOLU",
            "GEMLİK",
            "GEYİKLİ",
            "GÖCEK",
            "GÖLCÜK",
            "GÖMEÇ",
            "GÜLLÜK KAVŞAĞI",
            "GÜVERCİNLİK",
            "HOCALAR",
            "HORSUNLU",
            "İNEGÖL",
            "ISPARTA",
            "İZMİT ( KOCAELİ )",
            "KALE",
            "KALKAN",
            "KAPAKLI",
            "KARAAĞAÇ",
            "KARACABEY",
            "KARACABEY ÇATRAK",
            "KARAHALLI",
            "KARAMÜRSEL",
            "KAŞ",
            "KDZ.EREĞLİ",
            "KECIBORLU ( YOL AYRIMI )",
            "KEMER",
            "KEMER - MUĞLA",
            "KEŞAN",
            "KINIK",
            "KIRKLARELİ",
            "KÖŞK",
            "KÖYCEĞİZ",
            "KOZLU",
            "KÜÇÜKKUYU",
            "KUMLA",
            "KUŞADASI",
            "KÜTAHYA",
            "KUYUCAK",
            "LAPSEKİ",
            "LÜLEBURGAZ",
            "M.KEMALPAŞA",
            "MANAVGAT",
            "MANİSA",
            "MARMARİS",
            "MENGEN",
            "MİLAS",
            "MİLAS ÜÇYOL",
            "MUĞLA",
            "NAZİLLİ",
            "ORHANGAZİ",
            "ORTACA",
            "PAMUKKALE",
            "PAMUKÖREN",
            "PINARBAŞI ",
            "POLATLI",
            "SAKARYA ( ADAPAZARI )",
            "SALİHLERALTI DÖRTYOL",
            "SALİHLİ",
            "SANDIKLI",
            "SARAY",
            "SARAYKÖY",
            "SARIMSAKLI",
            "SELÇUK",
            "SELİMİYE",
            "SERİK",
            "SİVASLI",
            "SÖĞÜT ",
            "SÖKE",
            "SULTANHİSAR",
            "TAVAS",
            "TEKİRDAĞ",
            "TEKİRDAĞ ( M.EREĞLİSİ )",
            "TEKİRDAĞ ( Y.ÇİFTLİK )",
            "TEKİRDAĞ ( YENİCE )",
            "TURGUTLU",
            "TURGUT REİS",
            "ULA YOL AYRIMI",
            "UMURLU",
            "UŞAK ",
            "UZUNKÖPRÜ",
            "VİZE",
            "YALOVA",
            "YATAĞAN",
            "YENİPAZAR ( YOL AYRIMI )",
            "ZONGULDAK",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(450, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Varış Noktası";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KALKIŞ NOKTASI SEÇİNİZ",
            "İSTANBUL - AVRUPA ( ESENLER )",
            "İSTANBUL - AVRUPA ( ALİBEYKÖY )",
            "İSTANBUL - ANADOLU ( DUDULLU )",
            "İSTANBUL - ANADOLU ( HAREM )",
            "BURSA ",
            "ANKARA",
            "İZMİR ",
            "DENİZLİ",
            "ÇANAKKALE OTOGAR",
            "ÇANAKKALE İSKELE",
            "AFYON",
            "AKÇAKOCA",
            "AKÇAY",
            "AKHİSAR",
            "AKYAKA ( YOL AYRIMI )",
            "ALANYA",
            "ALAPLI",
            "ALAŞEHİR",
            "ALAŞEHİR OTOGAR",
            "ALİAĞA",
            "ALTINOLUK ",
            "ALTINOVA",
            "ANTALYA",
            "ATÇA",
            "AYDIN ",
            "AYVALIK",
            "BALIKESİR",
            "BANAZ",
            "BANDIRMA",
            "BAYIR",
            "BEKİLLİ",
            "BERGAMA",
            "BİGA",
            "BİLECİK ",
            "BODRUM",
            "BOZÜYÜK ",
            "BUCAK",
            "BUHARKENT",
            "BULDAN",
            "BURDUR",
            "BURHANİYE",
            "ÇANDARLI",
            "ÇİNE ",
            "ÇİVRİL",
            "ÇORLU",
            "ÇUBUCAK",
            "DALAMAN",
            "DARICA",
            "DATÇA",
            "DAZKIRI",
            "DEĞİRMENDERE",
            "DEVREK",
            "DİDİM",
            "DİKİLİ",
            "DİNAR ",
            "DÜZCE",
            "ECEABAT",
            "EDREMİT",
            "ERDEK",
            "ERİKLİ ( KEŞAN )",
            "EŞEN ",
            "ESKİŞEHİR",
            "EZİNE",
            "FETHİYE",
            "GEBZE",
            "GELİBOLU",
            "GEMLİK",
            "GEYİKLİ",
            "GÖCEK",
            "GÖLCÜK",
            "GÖMEÇ",
            "GÜLLÜK KAVŞAĞI",
            "GÜVERCİNLİK",
            "HOCALAR",
            "HORSUNLU",
            "İNEGÖL",
            "ISPARTA",
            "İZMİT ( KOCAELİ )",
            "KALE",
            "KALKAN",
            "KAPAKLI",
            "KARAAĞAÇ",
            "KARACABEY",
            "KARACABEY ÇATRAK",
            "KARAHALLI",
            "KARAMÜRSEL",
            "KAŞ",
            "KDZ.EREĞLİ",
            "KECIBORLU ( YOL AYRIMI )",
            "KEMER",
            "KEMER - MUĞLA",
            "KEŞAN",
            "KINIK",
            "KIRKLARELİ",
            "KÖŞK",
            "KÖYCEĞİZ",
            "KOZLU",
            "KÜÇÜKKUYU",
            "KUMLA",
            "KUŞADASI",
            "KÜTAHYA",
            "KUYUCAK",
            "LAPSEKİ",
            "LÜLEBURGAZ",
            "M.KEMALPAŞA",
            "MANAVGAT",
            "MANİSA",
            "MARMARİS",
            "MENGEN",
            "MİLAS",
            "MİLAS ÜÇYOL",
            "MUĞLA",
            "NAZİLLİ",
            "ORHANGAZİ",
            "ORTACA",
            "PAMUKKALE",
            "PAMUKÖREN",
            "PINARBAŞI ",
            "POLATLI",
            "SAKARYA ( ADAPAZARI )",
            "SALİHLERALTI DÖRTYOL",
            "SALİHLİ",
            "SANDIKLI",
            "SARAY",
            "SARAYKÖY",
            "SARIMSAKLI",
            "SELÇUK",
            "SELİMİYE",
            "SERİK",
            "SİVASLI",
            "SÖĞÜT ",
            "SÖKE",
            "SULTANHİSAR",
            "TAVAS",
            "TEKİRDAĞ",
            "TEKİRDAĞ ( M.EREĞLİSİ )",
            "TEKİRDAĞ ( Y.ÇİFTLİK )",
            "TEKİRDAĞ ( YENİCE )",
            "TURGUTLU",
            "TURGUT REİS",
            "ULA YOL AYRIMI",
            "UMURLU",
            "UŞAK ",
            "UZUNKÖPRÜ",
            "VİZE",
            "YALOVA",
            "YATAĞAN",
            "YENİPAZAR ( YOL AYRIMI )",
            "ZONGULDAK",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(170, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kalkış Noktası";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kADINToolStripMenuItem,
            this.eRKEKToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 101);
            // 
            // kADINToolStripMenuItem
            // 
            this.kADINToolStripMenuItem.Name = "kADINToolStripMenuItem";
            this.kADINToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.kADINToolStripMenuItem.Text = "KADIN";
            this.kADINToolStripMenuItem.Click += new System.EventHandler(this.kADINToolStripMenuItem_Click);
            // 
            // eRKEKToolStripMenuItem
            // 
            this.eRKEKToolStripMenuItem.Name = "eRKEKToolStripMenuItem";
            this.eRKEKToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.eRKEKToolStripMenuItem.Text = "ERKEK";
            this.eRKEKToolStripMenuItem.Click += new System.EventHandler(this.eRKEKToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kADINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRKEKToolStripMenuItem;
    }
}


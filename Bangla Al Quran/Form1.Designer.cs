namespace Bangla_Al_Quran
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.surahList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TableLayoutPanel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.sidebarHideBtn = new System.Windows.Forms.Button();
            this.suraName = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(148)))));
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.surahList);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.content);
            this.splitContainer1.Panel2.Controls.Add(this.sidebar);
            this.splitContainer1.Size = new System.Drawing.Size(967, 603);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(89)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 575);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DEVELOPED BY ANTOR AHMED";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(117)))), ((int)(((byte)(69)))));
            // 
            // surahList
            // 
            this.surahList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surahList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(116)))));
            this.surahList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surahList.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surahList.ForeColor = System.Drawing.Color.White;
            this.surahList.FormattingEnabled = true;
            this.surahList.ItemHeight = 24;
            this.surahList.Items.AddRange(new object[] {
            "১. আল ফাতিহা",
            "২. আল বাকারা",
            "৩. আল ইমরান",
            "৪. আন নিসা",
            "৫. আল মায়িদাহ",
            "৬. আল আনআম",
            "৭. আল আরাফ",
            "৮. আল আনফাল",
            "৯. আত তাওবাহ্",
            "১০. ইউনুস",
            "১১. হুদ",
            "১২. ইউসুফ",
            "১৩. আর রা\'দ",
            "১৪. ইব্রাহীম",
            "১৫. আল হিজর",
            "১৬. আন নাহল",
            "১৭. বনী-ইসরাঈল",
            "১৮. আল কাহফ",
            "১৯. মারইয়াম (মারইয়াম",
            "২০. ত্বোয়া-হা",
            "২১. আল আম্বিয়া",
            "২২. আল হাজ্জ্ব",
            "২৩. আল মু\'মিনূন",
            "২৪. আন নূর",
            "২৫. আল ফুরকান ",
            "২৬. আশ শুআরা",
            "২৭. আন নম্ল",
            "২৮. আল কাসাস",
            "২৯. আল আনকাবূত",
            "৩০. আর রুম",
            "৩১. লোক্মান",
            "৩২. আস সেজদাহ্",
            "৩৩. আল আহ্যাব",
            "৩৪. সাবা",
            "৩৫. ফাতির",
            "৩৬. ইয়াসীন",
            "৩৭. আস ছাফ্ফাত",
            "৩৮. ছোয়াদ",
            "৩৯. আয্-যুমার",
            "৪০. আল মু\'মিন",
            "৪১. হা-মীম সেজদাহ্",
            "৪২. আশ্-শূরা",
            "৪৩. আয্-যুখরুফ",
            "৪৪. আদ-দোখান",
            "৪৫. আল জাসিয়াহ",
            "৪৬. আল আহ্ক্বাফ",
            "৪৭. মুহাম্মদ",
            "৪৮. আল ফাত্হ",
            "৪৯. আল হুজুরাত",
            "৫০. ক্বাফ",
            "৫১. আয-যারিয়াত",
            "৫২. আত্ব তূর",
            "৫৩. আন-নাজম",
            "৫৪. আল ক্বামার",
            "৫৫. আর রাহমান",
            "৫৬. আল ওয়াক্বিয়াহ্",
            "৫৭. আল হাদীদ",
            "৫৮. আল মুজাদালাহ্",
            "৫৯. আল হাশ্র",
            "৬০. আল মুম্তাহিনাহ্",
            "৬১. আস সাফ",
            "৬২. আল জুমুআহ",
            "৬৩. আল মুনাফিকূন",
            "৬৪. আত তাগাবুন",
            "৬৫. আত ত্বালাক",
            "৬৬. আত তাহ্রীম",
            "৬৭. আল মুল্ক",
            "৬৮. আল ক্বলম",
            "৬৯. আল হাক্কাহ",
            "৭০. আল মাআরিজ",
            "৭১. নূহ",
            "৭২. আল জ্বিন",
            "৭৩. আল মুয্যাম্মিল",
            "৭৪. আল মুদ্দাস্সির",
            "৭৫. আল ক্বিয়ামাহ্",
            "৭৬. আদ দাহ্র",
            "৭৭. আল মুরসালাত",
            "৭৮. আন্ নাবা",
            "৭৯. আন নাযিয়াত",
            "৮০. আবাসা",
            "৮১. আত তাক্ভীর",
            "৮২. আল ইন্ফিতার",
            "৮৩. আত মুত্বাফ্ফিফীন",
            "৮৪. আল ইন্শিকাক",
            "৮৫. আল বুরুজ",
            "৮৬. আত তারিক্ব",
            "৮৭. আল আ\'লা",
            "৮৮. আল গাশিয়াহ্",
            "৮৯. আল ফাজ্র",
            "৯০. আল বালাদ",
            "৯১. আশ শামস",
            "৯২. আল লাইল",
            "৯৩. আদ দুহা",
            "৯৪. আল ইনশিরাহ",
            "৯৫. আত ত্বীন",
            "৯৬. আল আলাক",
            "৯৭. আল ক্বাদর",
            "৯৮. আল বাইয়্যিনাহ",
            "৯৯. আল যিল্যাল",
            "১০০. আল আদিয়াত",
            "১০১. আল ক্বারিয়াহ",
            "১০২. আত তাকাসুর",
            "১০৩. আল আছর",
            "১০৪. আল হুমাযাহ",
            "১০৫. আল ফীল",
            "১০৬. কুরাইশ",
            "১০৭. আল মাউন",
            "১০৮. আল কাওসার",
            "১০৯. আল কাফিরুন",
            "১১০. আন নাসর",
            "১১১. আল লাহাব",
            "১১২. আল ইখলাস",
            "১১৩. আল ফালাক",
            "১১৪. আল-নাস"});
            this.surahList.Location = new System.Drawing.Point(8, 111);
            this.surahList.Name = "surahList";
            this.surahList.Size = new System.Drawing.Size(233, 434);
            this.surahList.TabIndex = 2;
            this.surahList.SelectedIndexChanged += new System.EventHandler(this.surahList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "বাংলা\r\nআল-কুরআন";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.AutoScroll = true;
            this.content.AutoSize = true;
            this.content.BackColor = System.Drawing.Color.FloralWhite;
            this.content.ColumnCount = 1;
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 63);
            this.content.Name = "content";
            this.content.Padding = new System.Windows.Forms.Padding(10);
            this.content.RowCount = 1;
            this.content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.content.Size = new System.Drawing.Size(716, 540);
            this.content.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.sidebar.Controls.Add(this.sidebarHideBtn);
            this.sidebar.Controls.Add(this.suraName);
            this.sidebar.Controls.Add(this.playBtn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(716, 63);
            this.sidebar.TabIndex = 0;
            // 
            // sidebarHideBtn
            // 
            this.sidebarHideBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebarHideBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sidebarHideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sidebarHideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebarHideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarHideBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarHideBtn.ForeColor = System.Drawing.Color.White;
            this.sidebarHideBtn.Location = new System.Drawing.Point(4, 10);
            this.sidebarHideBtn.Name = "sidebarHideBtn";
            this.sidebarHideBtn.Size = new System.Drawing.Size(33, 43);
            this.sidebarHideBtn.TabIndex = 5;
            this.sidebarHideBtn.Text = "<";
            this.sidebarHideBtn.UseVisualStyleBackColor = false;
            this.sidebarHideBtn.Click += new System.EventHandler(this.sidebarHideBtn_Click);
            // 
            // suraName
            // 
            this.suraName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suraName.ForeColor = System.Drawing.Color.White;
            this.suraName.Location = new System.Drawing.Point(43, 10);
            this.suraName.Name = "suraName";
            this.suraName.Size = new System.Drawing.Size(307, 43);
            this.suraName.TabIndex = 4;
            this.suraName.Text = "একটি সূরা নির্বাচন করুন...";
            this.suraName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.playBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(631, 10);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(73, 43);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(967, 603);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bangla Al Quran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label suraName;
        private System.Windows.Forms.Button sidebarHideBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox surahList;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TableLayoutPanel content;
    }
}


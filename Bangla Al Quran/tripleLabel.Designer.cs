namespace Bangla_Al_Quran
{
    partial class tripleLabel
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
            this.components = new System.ComponentModel.Container();
            this.arabic = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyArabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBanglaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFullAyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meaning = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arabic
            // 
            this.arabic.AutoSize = true;
            this.arabic.ContextMenuStrip = this.menu;
            this.arabic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arabic.Font = new System.Drawing.Font("Book Antiqua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arabic.ForeColor = System.Drawing.Color.Black;
            this.arabic.Location = new System.Drawing.Point(13, 10);
            this.arabic.Name = "arabic";
            this.arabic.Padding = new System.Windows.Forms.Padding(8);
            this.arabic.Size = new System.Drawing.Size(697, 57);
            this.arabic.TabIndex = 0;
            this.arabic.Text = "بِسْمِ اللّٰهِ الرَّحْمٰنِ الرَّحِيْمِ";
            this.arabic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.copyArabicToolStripMenuItem,
            this.copyBanglaToolStripMenuItem,
            this.copyFullAyatToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(158, 92);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // copyArabicToolStripMenuItem
            // 
            this.copyArabicToolStripMenuItem.Name = "copyArabicToolStripMenuItem";
            this.copyArabicToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyArabicToolStripMenuItem.Text = "Copy Arabic";
            // 
            // copyBanglaToolStripMenuItem
            // 
            this.copyBanglaToolStripMenuItem.Name = "copyBanglaToolStripMenuItem";
            this.copyBanglaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyBanglaToolStripMenuItem.Text = "Copy Bangla";
            // 
            // copyFullAyatToolStripMenuItem
            // 
            this.copyFullAyatToolStripMenuItem.Name = "copyFullAyatToolStripMenuItem";
            this.copyFullAyatToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyFullAyatToolStripMenuItem.Text = "Copy Full ayat";
            // 
            // meaning
            // 
            this.meaning.AutoSize = true;
            this.meaning.ContextMenuStrip = this.menu;
            this.meaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning.ForeColor = System.Drawing.Color.DarkMagenta;
            this.meaning.Location = new System.Drawing.Point(13, 106);
            this.meaning.Name = "meaning";
            this.meaning.Padding = new System.Windows.Forms.Padding(5);
            this.meaning.Size = new System.Drawing.Size(697, 39);
            this.meaning.TabIndex = 1;
            this.meaning.Text = "শুরু করছি আল্লাহর নামে যিনি পরম করুণাময়, অতি দয়ালু।";
            this.meaning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // translate
            // 
            this.translate.AutoSize = true;
            this.translate.ContextMenuStrip = this.menu;
            this.translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translate.ForeColor = System.Drawing.Color.Blue;
            this.translate.Location = new System.Drawing.Point(13, 67);
            this.translate.Name = "translate";
            this.translate.Padding = new System.Windows.Forms.Padding(5);
            this.translate.Size = new System.Drawing.Size(697, 39);
            this.translate.TabIndex = 2;
            this.translate.Text = "বিছমিল্লাহির রাহমানির রাহিম।";
            this.translate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ContextMenuStrip = this.menu;
            this.tableLayoutPanel1.Controls.Add(this.translate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.meaning, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.arabic, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 155);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Resize += new System.EventHandler(this.tableLayoutPanel1_Resize);
            // 
            // tripleLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tripleLabel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(733, 165);
            this.menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arabic;
        private System.Windows.Forms.Label meaning;
        private System.Windows.Forms.Label translate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyArabicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBanglaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFullAyatToolStripMenuItem;
    }
}

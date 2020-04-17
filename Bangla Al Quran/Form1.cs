using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangla_Al_Quran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void sidebarHideBtn_Click(object sender, EventArgs e)
        {
            if(sidebarHideBtn.Text == "<")
            {
                sidebarHideBtn.Text = ">";
                splitContainer1.Panel1Collapsed = true;
            }
            else
            {
                sidebarHideBtn.Text = "<";
                splitContainer1.Panel1Collapsed = false;
            }
        }

        private void updateSurah()
        {
            suraName.Text = surahList.Text;
            int sura = surahList.SelectedIndex + 1;
            var lineCount = File.ReadLines("data\\arabic\\" + sura + ".txt").Count();
            var w = Width - 20;

            string[] arabicFile = File.ReadAllLines("data//arabic//" + sura + ".txt");
            string[] translateFlie = File.ReadAllLines("data//translate//" + sura + ".txt");
            string[] banglaFile= File.ReadAllLines("data//bangla//" + sura + ".txt");

            content.Controls.Clear();
            content.VerticalScroll.Value = 0;
            for (int i = 0; i < lineCount; i++)
            {
                var ayat = new tripleLabel(sura);
                ayat.setAyat(i, arabicFile[i], translateFlie[i], banglaFile[i]);
                ayat.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                content.Controls.Add(ayat);
            }
        }

        private void surahList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSurah();
        }
    }
}

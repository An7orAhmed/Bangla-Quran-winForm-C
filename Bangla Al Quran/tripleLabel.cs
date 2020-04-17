using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bangla_Al_Quran
{
    public partial class tripleLabel : UserControl
    {
        int sura, ayat;

        public tripleLabel(int sura)
        {
            this.sura = sura;
            InitializeComponent();

            var width = tableLayoutPanel1.Size;

            arabic.MaximumSize = width;
            translate.MaximumSize = width;
            meaning.MaximumSize = width;
        }

        public void setAyat(int aya, string a, string t, string b)
        {
            ayat = aya + 1;
            arabic.Text = a.Remove(0, a.IndexOf('|') + 1);
            translate.Text = ayat + ". " + t.Remove(0, t.IndexOf('|') + 1);
            meaning.Text = ayat + ". " + b.Remove(0, b.IndexOf('|') + 1);
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            var width = tableLayoutPanel1.Size;

            arabic.MaximumSize = width;
            translate.MaximumSize = width;
            meaning.MaximumSize = width;
        }
    }
}

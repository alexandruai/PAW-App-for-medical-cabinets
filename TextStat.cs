using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_Alexandru_Andra_1052
{
    public partial class TextStat : Form
    {
        bool imagineOnSource = true;
        public TextStat()
        {
            InitializeComponent();

            Sursa.ImageLocation = "\\Cabinet_Medical_Alexandru_Andra_1052\\" +
                "Cabinet_Medical_Alexandru_Andra_1052\\Photo\\blackcat.png";
        }

        private void btSwitch_Click(object sender, EventArgs e)
        {
            if (imagineOnSource)
            {
                imagineOnSource = false;

                Clipboard.SetImage(Sursa.Image);

                Destinatie.Image = Clipboard.GetImage();
                Sursa.Image = null;
            }
            else
            {
                imagineOnSource = true;

                Clipboard.SetImage(Destinatie.Image);

                Sursa.Image = Clipboard.GetImage();
                Destinatie.Image = null;
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbsursa.Text);
        }

        private void btPaste_Click(object sender, EventArgs e)
        {
            tbDestinatie.Text = Clipboard.GetText();
        }
    }
}

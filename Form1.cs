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
    public partial class MeniuPrincipal : Form
    {
        Medici medicfrm;
        Pacienti pacient;
        Retete reteta;
        public MeniuPrincipal(Medici medic)
        {
            InitializeComponent();
            medicfrm = medic;
        }

        public MeniuPrincipal(Pacienti p)
        {
            InitializeComponent();
            pacient = p;
        }

        public MeniuPrincipal(Retete r)
        {
            InitializeComponent();
            reteta = r;
        }

        public MeniuPrincipal()
        {
            InitializeComponent();

        }


        private void btPacienti_MouseClick(object sender, MouseEventArgs e)
        {
            Pacienti pacientP = new Pacienti();
            
            pacientP.ShowDialog();
            this.Hide();
        }

        private void btRetete_MouseClick(object sender, MouseEventArgs e)
        {
            Retete retetaR = new Retete();
            
            retetaR.ShowDialog();
            this.Hide();
        }

        private void btMedici_MouseClick(object sender, MouseEventArgs e)
        {
            Medici medicM = new Medici();
            medicM.ShowDialog();
            this.Hide();

        }
    }
}

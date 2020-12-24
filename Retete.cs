using Cabinet_Medical_Alexandru_Andra_1052.Models;
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
    public partial class Retete : Form
    {
        ReteteContext ctx;

        MeniuPrincipal meniufrm;
        public Retete()
        {
            InitializeComponent();
            meniufrm = new MeniuPrincipal(this);
            ctx = new ReteteContext();
        }

        #region BackButton
        private void btInapoiRetete_Click(object sender, EventArgs e)
        {
            this.Hide();
            meniufrm.Show();
        }
        #endregion

        #region toolStripButtons

        private void tsbRM_Click(object sender, EventArgs e)
        {
            Medici m = new Medici();
            this.Hide();
            m.Show();
        }

        private void tsbRP_Click(object sender, EventArgs e)
        {
            Pacienti p = new Pacienti();
            this.Hide();
            p.Show();
        }

        #endregion
        #region CRUD
        private void btAdaugaR_Click(object sender, EventArgs e)
        {
            if (dgvRetete.SelectedRows.Count != 0 && retetaBindingSource.Current as Reteta != null)
            {
                Reteta r = retetaBindingSource.Current as Reteta;

                r.DenumireMedicament = tbDenumireMed.Text;
                r.unitateDeMasura = tbUnitate.Text;
                r.Cantitate = tbCantitate.Text;
                r.IdR = tbRIdR.Text;

                ctx.Retetele.Update(r);
            }
            else
            {
                ctx.Retetele.Add(new Reteta()
                {
                 DenumireMedicament = tbDenumireMed.Text,
                 unitateDeMasura = tbUnitate.Text,
                 Cantitate = tbCantitate.Text,
                     IdR = tbRIdR.Text
                });
            }

            ctx.SaveChanges();
            retetaBindingSource.DataSource = ctx.Retetele.ToList();

        }

        private void btStergeR_Click(object sender, EventArgs e)
        {
            if(dgvRetete.SelectedRows.Count != 0)
            {
                if(MessageBox.Show("Doresti sa stergi intrarea ? ", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                    ctx.Retetele.Remove(retetaBindingSource.Current as Reteta);
                    ctx.SaveChanges();//Echivalent commit

                    retetaBindingSource.DataSource = ctx.Retetele.ToList();
                }
            }
        }

        private void Retete_Load(object sender, EventArgs e)
        {
            retetaBindingSource.DataSource = ctx.Retetele.ToList();
        }
        #endregion

    }
}

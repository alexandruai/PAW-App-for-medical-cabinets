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
    public partial class Pacienti : Form
    {
        PacientContext ctx;
        MeniuPrincipal meniufrm;
        public Pacienti()
        {
            InitializeComponent();
            meniufrm = new MeniuPrincipal(this);
        }

        #region BackButton
        private void btInapoiPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            meniufrm.Show();
        }
        #endregion

        #region toolStripButtons

        private void tsbPM_Click(object sender, EventArgs e)
        {
            Medici medic = new Medici();
            this.Hide();
            medic.Show();

        }


        private void tsbPR_Click(object sender, EventArgs e)
        {
            Retete r = new Retete();
            this.Hide();
            r.Show();
        }

        #endregion



        private void Pacienti_Load(object sender, EventArgs e)
        {
            pacientBindingSource.DataSource = ctx.Pacientii.ToList();
        }

        private void btAdaugaP_Click(object sender, EventArgs e)
        {

            if (dgvPacienti.SelectedRows.Count != 0 && pacientBindingSource.Current as Pacient != null)
            {
                Pacient p = pacientBindingSource.Current as Pacient;

                p.Spital = textBoxSpital.Text;
                p.Varsta = int.Parse(tbVarstaPacient.Text);
                p.Nume = textBoxNumePacient.Text;
                p.Prenume = textBoxPrenumePacient.Text;
                p.CNP = textBoxCNP.Text;
                p.MIdP = tbMIdP.Text;
                p.IdP = tbIdP.Text;

                String specializare = comboBoxSpecializareDoc.Text;
                Enum.TryParse(specializare, out SpecializareMedici Specializare);

                ctx.Pacientii.Update(p);
            }
            else
            {
                String specializare = comboBoxSpecializareDoc.Text;
                Enum.TryParse(specializare, out SpecializareMedici Specializare);
                ctx.Pacientii.Add(new Pacient()
                {
                    Spital = textBoxSpital.Text,
                    Varsta = int.Parse(tbVarstaPacient.Text),
                    Nume = textBoxNumePacient.Text,
                    Prenume = textBoxPrenumePacient.Text,
                    CNP = textBoxCNP.Text,
                    MIdP = tbMIdP.Text,
                    IdP = tbIdP.Text
            });
            }

            ctx.SaveChanges();
            pacientBindingSource.DataSource = ctx.Pacientii.ToList();

        }

        private void btStergeP_Click(object sender, EventArgs e)
        {
            if (dgvPacienti.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi intrarea ? ", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ctx.Pacientii.Remove(pacientBindingSource.Current as Pacient);
                    ctx.SaveChanges();//Echivalent commit

                    pacientBindingSource.DataSource = ctx.Pacientii.ToList();
                }
            }
        }
    }
}

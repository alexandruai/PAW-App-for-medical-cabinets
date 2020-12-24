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
    public partial class EditareMedic : Form
    {
        Medic instanceM;

        public EditareMedic(Medic medic)
        {
            InitializeComponent();

            instanceM = medic;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            instanceM.IdM = tbIdM.Text;
            instanceM.Spital = textBoxSpital.Text;
            instanceM.Nume = textBoxNumeMedic.Text;
            instanceM.Prenume = textBoxPrenumeMedic.Text;
            Enum.TryParse(comboBoxSpecializareDoc.Text,
                out SpecializareMedici specializare);
            instanceM.Specializare = specializare;

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditareMedic_Load(object sender, EventArgs e)
        {
            tbIdM.Text = instanceM.IdM;
            textBoxSpital.Text = instanceM.Spital;
            textBoxNumeMedic.Text = instanceM.Nume;
            textBoxPrenumeMedic.Text = instanceM.Prenume;
            comboBoxSpecializareDoc.Text = 
                instanceM.Specializare.ToString();

        }
    }
}

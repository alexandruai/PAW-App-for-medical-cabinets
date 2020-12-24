using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cabinet_Medical_Alexandru_Andra_1052.Models;


namespace Cabinet_Medical_Alexandru_Andra_1052
{
   
    public partial class Medici : Form
    {
        MeniuPrincipal meniufrm;
        List<Medic> listaM = new List<Medic>();
        private PrintDocument printDocument;
        bool buttonWasClicked = false;

        public Medici()
        {
            InitializeComponent();
            meniufrm = new MeniuPrincipal(this);
        }

        #region CRUD   
        //Create



        private void btInregMedic_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            String Spital = textBoxSpital.Text;

            if (String.IsNullOrEmpty(Spital) || String.IsNullOrWhiteSpace(Spital))
            {
                isValid = false;

            }

            String specializare = comboBoxSpecializareDoc.Text;
            Enum.TryParse(specializare, out SpecializareMedici Specializare);

     

            String NumeMedic = textBoxNumeMedic.Text;
            if (String.IsNullOrEmpty(NumeMedic) || String.IsNullOrWhiteSpace(NumeMedic))
            {
                isValid = false;

            }

            String PrenumeMedic = textBoxPrenumeMedic.Text;
            if (String.IsNullOrEmpty(PrenumeMedic) || String.IsNullOrWhiteSpace(PrenumeMedic))
            {
                isValid = false;

            }


            String id = tbIdM.Text;
            if (String.IsNullOrEmpty(id) || String.IsNullOrWhiteSpace(id))
            {
                isValid = false;

            }

            if (isValid)
            {
                try
                {
                    Medic medic = new Medic( id, NumeMedic, PrenumeMedic, Spital, Specializare);
                    listaM.Add(medic);

                    populareListView();

                    curataCampuri();
                    MessageBox.Show("Pacient inregistrat cu succes!");
                    buttonWasClicked = true;
                }

                catch (CustomExceptionVarsta ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Erroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        //Read
        private void populareListView()
        {

            listView.Items.Clear();
            foreach (Medic each in listaM)
            {
  
                    ListViewItem itemM = new ListViewItem(new String[] 
                    {each.IdM, each.Spital ,
                        each.Nume, each.Prenume,
                        each.Specializare.ToString()});
                     listView.Items.Add(itemM);
                

            }
        }

        private void btCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }


        //Delete
        private void btStergeMedic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doresti sa stergi medicul?", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaM.RemoveAt(listView.SelectedIndices[0]);
                // repopulare control UI listView
                populareListView();
            }
        }

        //Update

        private void btEditLista_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                Medic medic = listaM.ElementAt(listView.SelectedIndices[0]);

               EditareMedic editare = new EditareMedic(medic);
               editare.ShowDialog();

                populareListView();
            }
        }

#endregion

        # region CustomMenuStrip
        private void cmsEditeaza_Click(object sender, EventArgs e)
        {
            btEditLista_Click(sender, e);
        }

        private void cmsSterge_Click(object sender, EventArgs e)
        {
            btStergeMedic_Click(sender, e);
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMedic.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        //private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if(e.Button == MouseButtons.Left && 
        //       listView.FocusedItem.Bounds.Contains(e.Spital.X, e.Spital.Y)
        //    {
        //        btEditLista_MouseClick(sender, e);
        //    }
        //}

        #endregion

        #region Auxiliare
        private void curataCampuri()
        {

            textBoxSpital.Clear();
            textBoxNumeMedic.Clear();
            textBoxPrenumeMedic.Clear();
            tbIdM.Clear();


            comboBoxSpecializareDoc.SelectedIndex = -1;
        }

        #endregion

        #region Validare
        private void textBoxSpital_Validating(object sender, CancelEventArgs e)
        {
            String spital = textBoxSpital.Text;

            if (String.IsNullOrEmpty(spital) || String.IsNullOrWhiteSpace(spital))
            {
                erpSpital.SetError((Control)sender, "Completeaza numele!");
                e.Cancel = true;

            }
        }

        private void textBoxSpital_Validated(object sender, EventArgs e)
        {
            erpSpital.Clear();
        }




        #endregion

        #region BackButton
        private void btInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            meniufrm.Show();
        }
        #endregion

        #region Serializare/Deserializare/Fisiere
        private void serializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream("binary.dat", FileMode.Create);
            formatter.Serialize(fs, listaM);

            fs.Close();
        }

        private void deserializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisier binar";
            ofd.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                listaM = formatter.Deserialize(fs) as List<Medic>;
                fs.Close();

                populareListView();
            }
        }

        private void importFisier_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Selecteaza fisier text:";
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;

            //Am schimbat pt citirea mai multor linii

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName);
                string inreg;
                inreg = sr.ReadLine();
                while (inreg != null)
                {

                    while (inreg != null)
                    {
                        //Se citeste toata linia si face un vector care contine elementele de 
                        //pe o linie
                        string[] linieLocala = inreg.Split('@');

                        Enum.TryParse(linieLocala[0], out SpecializareMedici specializare);

                        Medic medicF = new Medic(linieLocala[0],
                           linieLocala[1],
                           linieLocala[2],
                           linieLocala[3],
                            specializare);
                        listaM.Add(medicF);

                    }

                    populareListView();
                    inreg = sr.ReadLine();
                }

                sr.Close();

            }
        }

        private void exportFisier_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Medic each in listaM)
                {
                    sw.Write(each.IdM + " " + each.Nume + " " + each.Prenume + " " + 
                        each.Spital + each.Specializare + " " + "\n");
                }

                sw.Close();
            }
        }


        #endregion

        #region toolStripButtons
        private void tsbPacienti_Click(object sender, EventArgs e)
        {
            Pacienti pacientfrm = new Pacienti();
            this.Hide();
            pacientfrm.Show();

        }

        private void tsbRetete_Click(object sender, EventArgs e)
        {
            Retete retetafrm = new Retete();
            this.Hide();
            retetafrm.Show();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            ppdMedici.Document = printDocument;
            ppdMedici.ShowDialog();

            psdMedici.PageSettings = pdMedici.DefaultPageSettings;

            if (psdMedici.ShowDialog() == DialogResult.OK)
            {
                pdMedici.DefaultPageSettings = psdMedici.PageSettings;
                ppdMedici.Document = printDocument;
                ppdMedici.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Brush brush = Brushes.DarkOrange;
            Font font = new Font("Consolas", 20);

            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Bottom - settings.Margins.Top;

            if (settings.Landscape)
            {
                var temp = totalDrawableH;
                totalDrawableH = totalDrawableW;
                totalDrawableW = temp;
            }

            int cellWidth = totalDrawableW / 4;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Lista Medici" ,  font, brush, totalDrawableW / 2, y);

            y += 100;

            // Desenare cap tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

            // Desensare denumire coloane
            graphics.DrawString("Spital", font, brush, x, y);
            graphics.DrawString("Specializare Doctor ", font, brush, x + cellWidth, y);
            graphics.DrawString("Nume Medic ", font, brush, x + cellWidth, y);
            graphics.DrawString("Prenume Medic ", font, brush, x + cellWidth, y);

            y += cellHeight;

            foreach (Medic m in listaM)
            {
                // desenare tabel
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

                // desensare continut
                graphics.DrawString(m.Spital, font, brush, x, y);
                graphics.DrawString(m.Specializare.ToString(), font, brush, x + cellWidth, y);
                graphics.DrawString(m.Nume, font, brush, x + cellWidth, y);
                graphics.DrawString(m.Prenume, font, brush, x + cellWidth, y);

                y += cellHeight;
            }
        }

        private void tsbStatistici_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            this.Hide();
            stat.ShowDialog();
        }

        #endregion

        #region All Shortcuts
        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.P && e.Control == true)
            {
                tsbPrint_Click(sender, e);
            }
        }

        #endregion

        #region statusStripButtons
        private void StatusStrip_Click(object sender, EventArgs e)
        {
            if(buttonWasClicked == true)
                ssMedici.Text = "Medici Inregistrati" + listaM.Count;
            buttonWasClicked = false;
        }

        #endregion


    }
}

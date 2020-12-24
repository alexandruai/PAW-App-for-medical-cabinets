namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class EditareMedic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareMedic));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.gbMedic = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataInregistrare = new System.Windows.Forms.Label();
            this.lbSpital = new System.Windows.Forms.Label();
            this.textBoxSpital = new System.Windows.Forms.TextBox();
            this.lbSpecializareDoc = new System.Windows.Forms.Label();
            this.comboBoxSpecializareDoc = new System.Windows.Forms.ComboBox();
            this.lbNumeMedic = new System.Windows.Forms.Label();
            this.tbIdM = new System.Windows.Forms.TextBox();
            this.textBoxNumeMedic = new System.Windows.Forms.TextBox();
            this.lbPrenumeMedic = new System.Windows.Forms.Label();
            this.textBoxPrenumeMedic = new System.Windows.Forms.TextBox();
            this.gbMedic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(27, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 50);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Anuleaza/Inapoi";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirma.Location = new System.Drawing.Point(27, 245);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 50);
            this.btnConfirma.TabIndex = 30;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // gbMedic
            // 
            this.gbMedic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbMedic.Controls.Add(this.label1);
            this.gbMedic.Controls.Add(this.btnCancel);
            this.gbMedic.Controls.Add(this.lbDataInregistrare);
            this.gbMedic.Controls.Add(this.btnConfirma);
            this.gbMedic.Controls.Add(this.lbSpital);
            this.gbMedic.Controls.Add(this.textBoxSpital);
            this.gbMedic.Controls.Add(this.lbSpecializareDoc);
            this.gbMedic.Controls.Add(this.comboBoxSpecializareDoc);
            this.gbMedic.Controls.Add(this.lbNumeMedic);
            this.gbMedic.Controls.Add(this.tbIdM);
            this.gbMedic.Controls.Add(this.textBoxNumeMedic);
            this.gbMedic.Controls.Add(this.lbPrenumeMedic);
            this.gbMedic.Controls.Add(this.textBoxPrenumeMedic);
            this.gbMedic.Location = new System.Drawing.Point(12, 12);
            this.gbMedic.Name = "gbMedic";
            this.gbMedic.Size = new System.Drawing.Size(246, 426);
            this.gbMedic.TabIndex = 32;
            this.gbMedic.TabStop = false;
            this.gbMedic.Text = "Formular Inregistrate Medic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // lbDataInregistrare
            // 
            this.lbDataInregistrare.AutoSize = true;
            this.lbDataInregistrare.Location = new System.Drawing.Point(8, 30);
            this.lbDataInregistrare.Name = "lbDataInregistrare";
            this.lbDataInregistrare.Size = new System.Drawing.Size(48, 13);
            this.lbDataInregistrare.TabIndex = 0;
            this.lbDataInregistrare.Text = "Id Medic";
            // 
            // lbSpital
            // 
            this.lbSpital.AutoSize = true;
            this.lbSpital.Location = new System.Drawing.Point(8, 69);
            this.lbSpital.Name = "lbSpital";
            this.lbSpital.Size = new System.Drawing.Size(33, 13);
            this.lbSpital.TabIndex = 2;
            this.lbSpital.Text = "Spital";
            // 
            // textBoxSpital
            // 
            this.textBoxSpital.Location = new System.Drawing.Point(11, 85);
            this.textBoxSpital.Name = "textBoxSpital";
            this.textBoxSpital.Size = new System.Drawing.Size(163, 20);
            this.textBoxSpital.TabIndex = 3;
            // 
            // lbSpecializareDoc
            // 
            this.lbSpecializareDoc.AutoSize = true;
            this.lbSpecializareDoc.Location = new System.Drawing.Point(8, 108);
            this.lbSpecializareDoc.Name = "lbSpecializareDoc";
            this.lbSpecializareDoc.Size = new System.Drawing.Size(99, 13);
            this.lbSpecializareDoc.TabIndex = 4;
            this.lbSpecializareDoc.Text = "Specializare Doctor";
            // 
            // comboBoxSpecializareDoc
            // 
            this.comboBoxSpecializareDoc.FormattingEnabled = true;
            this.comboBoxSpecializareDoc.Items.AddRange(new object[] {
            "Cardiologie",
            "Pedriatie",
            "Neurologie",
            "Psihiatrie",
            "Chirurgie"});
            this.comboBoxSpecializareDoc.Location = new System.Drawing.Point(11, 124);
            this.comboBoxSpecializareDoc.Name = "comboBoxSpecializareDoc";
            this.comboBoxSpecializareDoc.Size = new System.Drawing.Size(163, 21);
            this.comboBoxSpecializareDoc.TabIndex = 5;
            // 
            // lbNumeMedic
            // 
            this.lbNumeMedic.AutoSize = true;
            this.lbNumeMedic.Location = new System.Drawing.Point(8, 148);
            this.lbNumeMedic.Name = "lbNumeMedic";
            this.lbNumeMedic.Size = new System.Drawing.Size(67, 13);
            this.lbNumeMedic.TabIndex = 6;
            this.lbNumeMedic.Text = "Nume Medic";
            // 
            // tbIdM
            // 
            this.tbIdM.Location = new System.Drawing.Point(11, 46);
            this.tbIdM.Name = "tbIdM";
            this.tbIdM.Size = new System.Drawing.Size(163, 20);
            this.tbIdM.TabIndex = 13;
            // 
            // textBoxNumeMedic
            // 
            this.textBoxNumeMedic.Location = new System.Drawing.Point(11, 164);
            this.textBoxNumeMedic.Name = "textBoxNumeMedic";
            this.textBoxNumeMedic.Size = new System.Drawing.Size(163, 20);
            this.textBoxNumeMedic.TabIndex = 7;
            // 
            // lbPrenumeMedic
            // 
            this.lbPrenumeMedic.AutoSize = true;
            this.lbPrenumeMedic.Location = new System.Drawing.Point(8, 187);
            this.lbPrenumeMedic.Name = "lbPrenumeMedic";
            this.lbPrenumeMedic.Size = new System.Drawing.Size(81, 13);
            this.lbPrenumeMedic.TabIndex = 8;
            this.lbPrenumeMedic.Text = "Prenume Medic";
            // 
            // textBoxPrenumeMedic
            // 
            this.textBoxPrenumeMedic.Location = new System.Drawing.Point(11, 203);
            this.textBoxPrenumeMedic.Name = "textBoxPrenumeMedic";
            this.textBoxPrenumeMedic.Size = new System.Drawing.Size(163, 20);
            this.textBoxPrenumeMedic.TabIndex = 9;
            // 
            // EditareMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.gbMedic);
            this.Name = "EditareMedic";
            this.Text = "EditareMedic";
            this.Load += new System.EventHandler(this.EditareMedic_Load);
            this.gbMedic.ResumeLayout(false);
            this.gbMedic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.GroupBox gbMedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDataInregistrare;
        private System.Windows.Forms.Label lbSpital;
        private System.Windows.Forms.TextBox textBoxSpital;
        private System.Windows.Forms.Label lbSpecializareDoc;
        private System.Windows.Forms.ComboBox comboBoxSpecializareDoc;
        private System.Windows.Forms.Label lbNumeMedic;
        private System.Windows.Forms.TextBox tbIdM;
        private System.Windows.Forms.TextBox textBoxNumeMedic;
        private System.Windows.Forms.Label lbPrenumeMedic;
        private System.Windows.Forms.TextBox textBoxPrenumeMedic;
    }
}
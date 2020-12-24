namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class Medici
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medici));
            this.gbMedic = new System.Windows.Forms.GroupBox();
            this.ssMedici = new System.Windows.Forms.StatusStrip();
            this.StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.btInapoi = new System.Windows.Forms.Button();
            this.btStergeMedic = new System.Windows.Forms.Button();
            this.btCurata = new System.Windows.Forms.Button();
            this.btEditLista = new System.Windows.Forms.Button();
            this.btInregMedic = new System.Windows.Forms.Button();
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
            this.cmsMedic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.lbListView = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.erpSpital = new System.Windows.Forms.ErrorProvider(this.components);
            this.msMedic = new System.Windows.Forms.MenuStrip();
            this.operatiiBinare = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiFisierText = new System.Windows.Forms.ToolStripMenuItem();
            this.importFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMedici = new System.Windows.Forms.ToolStrip();
            this.tsbPacienti = new System.Windows.Forms.ToolStripButton();
            this.tsbRetete = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbStats = new System.Windows.Forms.ToolStripButton();
            this.pdMedici = new System.Drawing.Printing.PrintDocument();
            this.ppdMedici = new System.Windows.Forms.PrintPreviewDialog();
            this.psdMedici = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gbMedic.SuspendLayout();
            this.ssMedici.SuspendLayout();
            this.cmsMedic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSpital)).BeginInit();
            this.msMedic.SuspendLayout();
            this.tsMedici.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMedic
            // 
            this.gbMedic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbMedic.Controls.Add(this.ssMedici);
            this.gbMedic.Controls.Add(this.btInapoi);
            this.gbMedic.Controls.Add(this.btStergeMedic);
            this.gbMedic.Controls.Add(this.btCurata);
            this.gbMedic.Controls.Add(this.btEditLista);
            this.gbMedic.Controls.Add(this.btInregMedic);
            this.gbMedic.Controls.Add(this.label1);
            this.gbMedic.Controls.Add(this.lbDataInregistrare);
            this.gbMedic.Controls.Add(this.lbSpital);
            this.gbMedic.Controls.Add(this.textBoxSpital);
            this.gbMedic.Controls.Add(this.lbSpecializareDoc);
            this.gbMedic.Controls.Add(this.comboBoxSpecializareDoc);
            this.gbMedic.Controls.Add(this.lbNumeMedic);
            this.gbMedic.Controls.Add(this.tbIdM);
            this.gbMedic.Controls.Add(this.textBoxNumeMedic);
            this.gbMedic.Controls.Add(this.lbPrenumeMedic);
            this.gbMedic.Controls.Add(this.textBoxPrenumeMedic);
            this.gbMedic.Location = new System.Drawing.Point(12, 66);
            this.gbMedic.Name = "gbMedic";
            this.gbMedic.Size = new System.Drawing.Size(246, 395);
            this.gbMedic.TabIndex = 21;
            this.gbMedic.TabStop = false;
            this.gbMedic.Text = "Formular Inregistrate Medic";
            // 
            // ssMedici
            // 
            this.ssMedici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip});
            this.ssMedici.Location = new System.Drawing.Point(3, 370);
            this.ssMedici.Name = "ssMedici";
            this.ssMedici.Size = new System.Drawing.Size(240, 22);
            this.ssMedici.TabIndex = 28;
            this.ssMedici.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(114, 17);
            this.StatusStrip.Text = "Medici Inregistrati: 0";
            this.StatusStrip.Click += new System.EventHandler(this.StatusStrip_Click);
            // 
            // btInapoi
            // 
            this.btInapoi.Location = new System.Drawing.Point(68, 329);
            this.btInapoi.Name = "btInapoi";
            this.btInapoi.Size = new System.Drawing.Size(93, 32);
            this.btInapoi.TabIndex = 27;
            this.btInapoi.Text = "Inapoi";
            this.btInapoi.UseVisualStyleBackColor = true;
            this.btInapoi.Click += new System.EventHandler(this.btInapoi_Click);
            // 
            // btStergeMedic
            // 
            this.btStergeMedic.Location = new System.Drawing.Point(119, 274);
            this.btStergeMedic.Name = "btStergeMedic";
            this.btStergeMedic.Size = new System.Drawing.Size(111, 49);
            this.btStergeMedic.TabIndex = 26;
            this.btStergeMedic.Text = "Sterge Medic";
            this.btStergeMedic.UseVisualStyleBackColor = true;
            this.btStergeMedic.Click += new System.EventHandler(this.btStergeMedic_Click);
            this.btStergeMedic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // btCurata
            // 
            this.btCurata.Location = new System.Drawing.Point(119, 229);
            this.btCurata.Name = "btCurata";
            this.btCurata.Size = new System.Drawing.Size(111, 39);
            this.btCurata.TabIndex = 21;
            this.btCurata.Text = "Curata Formular";
            this.btCurata.UseVisualStyleBackColor = true;
            this.btCurata.Click += new System.EventHandler(this.btCurata_Click);
            // 
            // btEditLista
            // 
            this.btEditLista.Location = new System.Drawing.Point(6, 274);
            this.btEditLista.Name = "btEditLista";
            this.btEditLista.Size = new System.Drawing.Size(107, 49);
            this.btEditLista.TabIndex = 25;
            this.btEditLista.Text = "Editeaza Lista Medici";
            this.btEditLista.UseVisualStyleBackColor = true;
            this.btEditLista.Click += new System.EventHandler(this.btEditLista_Click);
            // 
            // btInregMedic
            // 
            this.btInregMedic.Location = new System.Drawing.Point(6, 229);
            this.btInregMedic.Name = "btInregMedic";
            this.btInregMedic.Size = new System.Drawing.Size(107, 39);
            this.btInregMedic.TabIndex = 20;
            this.btInregMedic.Text = "Inregistrare Medic";
            this.btInregMedic.UseVisualStyleBackColor = true;
            this.btInregMedic.Click += new System.EventHandler(this.btInregMedic_Click);
            this.btInregMedic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
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
            this.textBoxSpital.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSpital_Validating);
            this.textBoxSpital.Validated += new System.EventHandler(this.textBoxSpital_Validated);
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
            // cmsMedic
            // 
            this.cmsMedic.AllowDrop = true;
            this.cmsMedic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditeaza,
            this.cmsSterge});
            this.cmsMedic.Name = "cmsMedic";
            this.cmsMedic.Size = new System.Drawing.Size(118, 48);
            // 
            // cmsEditeaza
            // 
            this.cmsEditeaza.Name = "cmsEditeaza";
            this.cmsEditeaza.Size = new System.Drawing.Size(117, 22);
            this.cmsEditeaza.Text = "Editeaza";
            this.cmsEditeaza.Click += new System.EventHandler(this.cmsEditeaza_Click);
            // 
            // cmsSterge
            // 
            this.cmsSterge.Name = "cmsSterge";
            this.cmsSterge.Size = new System.Drawing.Size(117, 22);
            this.cmsSterge.Text = "Sterge";
            this.cmsSterge.Click += new System.EventHandler(this.cmsSterge_Click);
            // 
            // lbListView
            // 
            this.lbListView.AutoSize = true;
            this.lbListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbListView.Location = new System.Drawing.Point(530, 66);
            this.lbListView.Name = "lbListView";
            this.lbListView.Size = new System.Drawing.Size(46, 13);
            this.lbListView.TabIndex = 23;
            this.lbListView.Text = "ListView";
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(398, 98);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(323, 329);
            this.listView.TabIndex = 24;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Medic";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Spital";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume Medic";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prenume Medic";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Specializare";
            // 
            // erpSpital
            // 
            this.erpSpital.ContainerControl = this;
            // 
            // msMedic
            // 
            this.msMedic.BackColor = System.Drawing.SystemColors.Window;
            this.msMedic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiBinare,
            this.operatiiFisierText});
            this.msMedic.Location = new System.Drawing.Point(0, 0);
            this.msMedic.Name = "msMedic";
            this.msMedic.Size = new System.Drawing.Size(800, 24);
            this.msMedic.TabIndex = 25;
            this.msMedic.Text = "msMedic";
            // 
            // operatiiBinare
            // 
            this.operatiiBinare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinara,
            this.deserializareBinara});
            this.operatiiBinare.Name = "operatiiBinare";
            this.operatiiBinare.Size = new System.Drawing.Size(97, 20);
            this.operatiiBinare.Text = "Operatii Binare";
            // 
            // serializareBinara
            // 
            this.serializareBinara.Name = "serializareBinara";
            this.serializareBinara.Size = new System.Drawing.Size(139, 22);
            this.serializareBinara.Text = "Serializare";
            this.serializareBinara.Click += new System.EventHandler(this.serializareBinara_Click);
            // 
            // deserializareBinara
            // 
            this.deserializareBinara.Name = "deserializareBinara";
            this.deserializareBinara.Size = new System.Drawing.Size(139, 22);
            this.deserializareBinara.Text = "Deserializare";
            this.deserializareBinara.Click += new System.EventHandler(this.deserializareBinara_Click);
            // 
            // operatiiFisierText
            // 
            this.operatiiFisierText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFisier,
            this.exportFisier});
            this.operatiiFisierText.Name = "operatiiFisierText";
            this.operatiiFisierText.Size = new System.Drawing.Size(121, 20);
            this.operatiiFisierText.Text = "Operatii Fisiere Text";
            // 
            // importFisier
            // 
            this.importFisier.Name = "importFisier";
            this.importFisier.Size = new System.Drawing.Size(110, 22);
            this.importFisier.Text = "Import";
            this.importFisier.Click += new System.EventHandler(this.importFisier_Click);
            // 
            // exportFisier
            // 
            this.exportFisier.Name = "exportFisier";
            this.exportFisier.Size = new System.Drawing.Size(110, 22);
            this.exportFisier.Text = "Export";
            this.exportFisier.Click += new System.EventHandler(this.exportFisier_Click);
            // 
            // tsMedici
            // 
            this.tsMedici.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsMedici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPacienti,
            this.tsbRetete,
            this.tsbPrint,
            this.tsbStats});
            this.tsMedici.Location = new System.Drawing.Point(0, 24);
            this.tsMedici.Name = "tsMedici";
            this.tsMedici.Size = new System.Drawing.Size(800, 25);
            this.tsMedici.TabIndex = 26;
            this.tsMedici.Text = "toolStrip2";
            // 
            // tsbPacienti
            // 
            this.tsbPacienti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPacienti.Image = ((System.Drawing.Image)(resources.GetObject("tsbPacienti.Image")));
            this.tsbPacienti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPacienti.Name = "tsbPacienti";
            this.tsbPacienti.Size = new System.Drawing.Size(23, 22);
            this.tsbPacienti.Text = "Pacienti";
            this.tsbPacienti.Click += new System.EventHandler(this.tsbPacienti_Click);
            // 
            // tsbRetete
            // 
            this.tsbRetete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRetete.Image = ((System.Drawing.Image)(resources.GetObject("tsbRetete.Image")));
            this.tsbRetete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRetete.Name = "tsbRetete";
            this.tsbRetete.Size = new System.Drawing.Size(23, 22);
            this.tsbRetete.Text = "Retete";
            this.tsbRetete.Click += new System.EventHandler(this.tsbRetete_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "Print(Ctr + P)";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbStats
            // 
            this.tsbStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStats.Image = ((System.Drawing.Image)(resources.GetObject("tsbStats.Image")));
            this.tsbStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStats.Name = "tsbStats";
            this.tsbStats.Size = new System.Drawing.Size(23, 22);
            this.tsbStats.Text = "Statistici";
            this.tsbStats.Click += new System.EventHandler(this.tsbStatistici_Click);
            // 
            // pdMedici
            // 
            this.pdMedici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // ppdMedici
            // 
            this.ppdMedici.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdMedici.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdMedici.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdMedici.Enabled = true;
            this.ppdMedici.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdMedici.Icon")));
            this.ppdMedici.Name = "ppdMedici";
            this.ppdMedici.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Medici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.tsMedici);
            this.Controls.Add(this.msMedic);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbListView);
            this.Controls.Add(this.gbMedic);
            this.MainMenuStrip = this.msMedic;
            this.Name = "Medici";
            this.Text = "Medici";
            this.gbMedic.ResumeLayout(false);
            this.gbMedic.PerformLayout();
            this.ssMedici.ResumeLayout(false);
            this.ssMedici.PerformLayout();
            this.cmsMedic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpSpital)).EndInit();
            this.msMedic.ResumeLayout(false);
            this.msMedic.PerformLayout();
            this.tsMedici.ResumeLayout(false);
            this.tsMedici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btCurata;
        private System.Windows.Forms.Button btInregMedic;
        private System.Windows.Forms.Button btStergeMedic;
        private System.Windows.Forms.Button btEditLista;
        private System.Windows.Forms.ContextMenuStrip cmsMedic;
        private System.Windows.Forms.ToolStripMenuItem cmsEditeaza;
        private System.Windows.Forms.ToolStripMenuItem cmsSterge;
        private System.Windows.Forms.Label lbListView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ErrorProvider erpSpital;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btInapoi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip msMedic;
        private System.Windows.Forms.ToolStripMenuItem operatiiBinare;
        private System.Windows.Forms.ToolStripMenuItem serializareBinara;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinara;
        private System.Windows.Forms.ToolStripMenuItem operatiiFisierText;
        private System.Windows.Forms.ToolStripMenuItem importFisier;
        private System.Windows.Forms.ToolStripMenuItem exportFisier;
        private System.Windows.Forms.StatusStrip ssMedici;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip;
        private System.Windows.Forms.ToolStrip tsMedici;
        private System.Windows.Forms.ToolStripButton tsbPacienti;
        private System.Windows.Forms.ToolStripButton tsbRetete;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbStats;
        private System.Drawing.Printing.PrintDocument pdMedici;
        private System.Windows.Forms.PrintPreviewDialog ppdMedici;
        private System.Windows.Forms.PageSetupDialog psdMedici;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
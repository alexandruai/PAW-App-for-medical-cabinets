namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class MeniuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuPrincipal));
            this.btMedici = new System.Windows.Forms.Button();
            this.btPacienti = new System.Windows.Forms.Button();
            this.btRetete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMedici
            // 
            this.btMedici.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMedici.Image = ((System.Drawing.Image)(resources.GetObject("btMedici.Image")));
            this.btMedici.Location = new System.Drawing.Point(27, 30);
            this.btMedici.Name = "btMedici";
            this.btMedici.Size = new System.Drawing.Size(192, 100);
            this.btMedici.TabIndex = 0;
            this.btMedici.Text = "Medici";
            this.btMedici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMedici.UseVisualStyleBackColor = false;
  //          this.btMedici.Click += new System.EventHandler(this.btMedici_Click);
            this.btMedici.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMedici_MouseClick);
            // 
            // btPacienti
            // 
            this.btPacienti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPacienti.Image = ((System.Drawing.Image)(resources.GetObject("btPacienti.Image")));
            this.btPacienti.Location = new System.Drawing.Point(27, 167);
            this.btPacienti.Name = "btPacienti";
            this.btPacienti.Size = new System.Drawing.Size(192, 95);
            this.btPacienti.TabIndex = 1;
            this.btPacienti.Text = "Pacienti";
            this.btPacienti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPacienti.UseVisualStyleBackColor = false;
            this.btPacienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btPacienti_MouseClick);
            // 
            // btRetete
            // 
            this.btRetete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRetete.Image = ((System.Drawing.Image)(resources.GetObject("btRetete.Image")));
            this.btRetete.Location = new System.Drawing.Point(27, 298);
            this.btRetete.Name = "btRetete";
            this.btRetete.Size = new System.Drawing.Size(192, 87);
            this.btRetete.TabIndex = 2;
            this.btRetete.Text = "Retete";
            this.btRetete.UseVisualStyleBackColor = false;
            this.btRetete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRetete_MouseClick);
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetete);
            this.Controls.Add(this.btPacienti);
            this.Controls.Add(this.btMedici);
            this.Name = "MeniuPrincipal";
            this.Text = "Meniu Iregistrari";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMedici;
        private System.Windows.Forms.Button btPacienti;
        private System.Windows.Forms.Button btRetete;
    }
}


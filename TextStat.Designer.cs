namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class TextStat
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
            this.Sursa = new System.Windows.Forms.PictureBox();
            this.Destinatie = new System.Windows.Forms.PictureBox();
            this.btSwitch = new System.Windows.Forms.Button();
            this.tbsursa = new System.Windows.Forms.TextBox();
            this.tbDestinatie = new System.Windows.Forms.TextBox();
            this.btCopy = new System.Windows.Forms.Button();
            this.btPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sursa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destinatie)).BeginInit();
            this.SuspendLayout();
            // 
            // Sursa
            // 
            this.Sursa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sursa.Location = new System.Drawing.Point(36, 41);
            this.Sursa.Name = "Sursa";
            this.Sursa.Size = new System.Drawing.Size(254, 249);
            this.Sursa.TabIndex = 0;
            this.Sursa.TabStop = false;
            // 
            // Destinatie
            // 
            this.Destinatie.Location = new System.Drawing.Point(500, 48);
            this.Destinatie.Name = "Destinatie";
            this.Destinatie.Size = new System.Drawing.Size(259, 241);
            this.Destinatie.TabIndex = 1;
            this.Destinatie.TabStop = false;
            // 
            // btSwitch
            // 
            this.btSwitch.Location = new System.Drawing.Point(339, 128);
            this.btSwitch.Name = "btSwitch";
            this.btSwitch.Size = new System.Drawing.Size(118, 38);
            this.btSwitch.TabIndex = 2;
            this.btSwitch.Text = "Switch";
            this.btSwitch.UseVisualStyleBackColor = true;
            this.btSwitch.Click += new System.EventHandler(this.btSwitch_Click);
            // 
            // tbsursa
            // 
            this.tbsursa.Location = new System.Drawing.Point(36, 332);
            this.tbsursa.Name = "tbsursa";
            this.tbsursa.Size = new System.Drawing.Size(237, 20);
            this.tbsursa.TabIndex = 3;
            // 
            // tbDestinatie
            // 
            this.tbDestinatie.Location = new System.Drawing.Point(500, 332);
            this.tbDestinatie.Name = "tbDestinatie";
            this.tbDestinatie.Size = new System.Drawing.Size(242, 20);
            this.tbDestinatie.TabIndex = 4;
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(36, 389);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(237, 44);
            this.btCopy.TabIndex = 5;
            this.btCopy.Text = "Copy in clipbord";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(500, 389);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(242, 44);
            this.btPaste.TabIndex = 6;
            this.btPaste.Text = "Paste din clipbord";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // TextStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPaste);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.tbDestinatie);
            this.Controls.Add(this.tbsursa);
            this.Controls.Add(this.btSwitch);
            this.Controls.Add(this.Destinatie);
            this.Controls.Add(this.Sursa);
            this.Name = "TextStat";
            this.Text = "TextStat";
            ((System.ComponentModel.ISupportInitialize)(this.Sursa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destinatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Sursa;
        private System.Windows.Forms.PictureBox Destinatie;
        private System.Windows.Forms.Button btSwitch;
        private System.Windows.Forms.TextBox tbsursa;
        private System.Windows.Forms.TextBox tbDestinatie;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Button btPaste;
    }
}
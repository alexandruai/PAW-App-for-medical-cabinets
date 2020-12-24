namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class Retete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retete));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRetete = new System.Windows.Forms.DataGridView();
            this.retetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbRetete = new System.Windows.Forms.Label();
            this.btInapoiRetete = new System.Windows.Forms.Button();
            this.tbUnitate = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbDenumireMed = new System.Windows.Forms.TextBox();
            this.lbUnitate = new System.Windows.Forms.Label();
            this.lbCantitate = new System.Windows.Forms.Label();
            this.lbDenumireMed = new System.Windows.Forms.Label();
            this.tbRIdR = new System.Windows.Forms.TextBox();
            this.btAdaugaR = new System.Windows.Forms.Button();
            this.btStergeR = new System.Windows.Forms.Button();
            this.retetaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Reteta";
            // 
            // dgvRetete
            // 
            this.dgvRetete.AutoGenerateColumns = false;
            this.dgvRetete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvRetete.DataSource = this.retetaBindingSource1;
            this.dgvRetete.Location = new System.Drawing.Point(247, 51);
            this.dgvRetete.Name = "dgvRetete";
            this.dgvRetete.Size = new System.Drawing.Size(541, 326);
            this.dgvRetete.TabIndex = 3;
            // 
            // lbRetete
            // 
            this.lbRetete.AutoSize = true;
            this.lbRetete.Location = new System.Drawing.Point(496, 35);
            this.lbRetete.Name = "lbRetete";
            this.lbRetete.Size = new System.Drawing.Size(39, 13);
            this.lbRetete.TabIndex = 4;
            this.lbRetete.Text = "Retete";
            // 
            // btInapoiRetete
            // 
            this.btInapoiRetete.Location = new System.Drawing.Point(667, 405);
            this.btInapoiRetete.Name = "btInapoiRetete";
            this.btInapoiRetete.Size = new System.Drawing.Size(121, 24);
            this.btInapoiRetete.TabIndex = 5;
            this.btInapoiRetete.Text = "Inapoi";
            this.btInapoiRetete.UseVisualStyleBackColor = true;
            this.btInapoiRetete.Click += new System.EventHandler(this.btInapoiRetete_Click);
            // 
            // tbUnitate
            // 
            this.tbUnitate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbUnitate.Location = new System.Drawing.Point(15, 165);
            this.tbUnitate.Name = "tbUnitate";
            this.tbUnitate.Size = new System.Drawing.Size(163, 20);
            this.tbUnitate.TabIndex = 11;
            // 
            // tbCantitate
            // 
            this.tbCantitate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCantitate.Location = new System.Drawing.Point(15, 126);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(163, 20);
            this.tbCantitate.TabIndex = 10;
            // 
            // tbDenumireMed
            // 
            this.tbDenumireMed.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbDenumireMed.Location = new System.Drawing.Point(15, 87);
            this.tbDenumireMed.Name = "tbDenumireMed";
            this.tbDenumireMed.Size = new System.Drawing.Size(163, 20);
            this.tbDenumireMed.TabIndex = 9;
            // 
            // lbUnitate
            // 
            this.lbUnitate.AutoSize = true;
            this.lbUnitate.Location = new System.Drawing.Point(13, 149);
            this.lbUnitate.Name = "lbUnitate";
            this.lbUnitate.Size = new System.Drawing.Size(94, 13);
            this.lbUnitate.TabIndex = 8;
            this.lbUnitate.Text = "Unitate de Masura";
            // 
            // lbCantitate
            // 
            this.lbCantitate.AutoSize = true;
            this.lbCantitate.Location = new System.Drawing.Point(12, 110);
            this.lbCantitate.Name = "lbCantitate";
            this.lbCantitate.Size = new System.Drawing.Size(49, 13);
            this.lbCantitate.TabIndex = 7;
            this.lbCantitate.Text = "Cantitate";
            // 
            // lbDenumireMed
            // 
            this.lbDenumireMed.AutoSize = true;
            this.lbDenumireMed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDenumireMed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDenumireMed.Location = new System.Drawing.Point(12, 71);
            this.lbDenumireMed.Name = "lbDenumireMed";
            this.lbDenumireMed.Size = new System.Drawing.Size(113, 13);
            this.lbDenumireMed.TabIndex = 6;
            this.lbDenumireMed.Text = "Denumire Medicament";
            // 
            // tbRIdR
            // 
            this.tbRIdR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbRIdR.Location = new System.Drawing.Point(15, 204);
            this.tbRIdR.Name = "tbRIdR";
            this.tbRIdR.Size = new System.Drawing.Size(163, 20);
            this.tbRIdR.TabIndex = 12;
            // 
            // btAdaugaR
            // 
            this.btAdaugaR.Location = new System.Drawing.Point(32, 245);
            this.btAdaugaR.Name = "btAdaugaR";
            this.btAdaugaR.Size = new System.Drawing.Size(105, 40);
            this.btAdaugaR.TabIndex = 14;
            this.btAdaugaR.Text = "Adauga";
            this.btAdaugaR.UseVisualStyleBackColor = true;
            this.btAdaugaR.Click += new System.EventHandler(this.btAdaugaR_Click);
            // 
            // btStergeR
            // 
            this.btStergeR.Location = new System.Drawing.Point(32, 300);
            this.btStergeR.Name = "btStergeR";
            this.btStergeR.Size = new System.Drawing.Size(106, 39);
            this.btStergeR.TabIndex = 15;
            this.btStergeR.Text = "Sterge";
            this.btStergeR.UseVisualStyleBackColor = true;
            // 
            // retetaBindingSource1
            // 
            this.retetaBindingSource1.DataSource = typeof(Cabinet_Medical_Alexandru_Andra_1052.Reteta);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdR";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DenumireMedicament";
            this.dataGridViewTextBoxColumn2.HeaderText = "DenumireMedicament";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "unitateDeMasura";
            this.dataGridViewTextBoxColumn3.HeaderText = "unitateDeMasura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pacient";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pacient";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Retete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStergeR);
            this.Controls.Add(this.btAdaugaR);
            this.Controls.Add(this.tbRIdR);
            this.Controls.Add(this.tbUnitate);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbDenumireMed);
            this.Controls.Add(this.lbUnitate);
            this.Controls.Add(this.lbCantitate);
            this.Controls.Add(this.lbDenumireMed);
            this.Controls.Add(this.btInapoiRetete);
            this.Controls.Add(this.lbRetete);
            this.Controls.Add(this.dgvRetete);
            this.Controls.Add(this.label2);
            this.Name = "Retete";
            this.Text = "Retete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRetete;
        private System.Windows.Forms.Label lbRetete;
        private System.Windows.Forms.Button btInapoiRetete;
        private System.Windows.Forms.TextBox tbUnitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbDenumireMed;
        private System.Windows.Forms.Label lbUnitate;
        private System.Windows.Forms.Label lbCantitate;
        private System.Windows.Forms.Label lbDenumireMed;
        private System.Windows.Forms.TextBox tbRIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitateDeMasuraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource retetaBindingSource;
        private System.Windows.Forms.Button btAdaugaR;
        private System.Windows.Forms.Button btStergeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource retetaBindingSource1;
    }
}
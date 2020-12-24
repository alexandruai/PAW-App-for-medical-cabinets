namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.labeltv = new System.Windows.Forms.Label();
            this.statusStripS = new System.Windows.Forms.StatusStrip();
            this.toolStripLbS = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(50, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(259, 293);
            this.panel.TabIndex = 0;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.labeltv_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.labeltv_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aduceti fisier pentru a popula panelul";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView.Location = new System.Drawing.Point(464, 95);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(285, 305);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // labeltv
            // 
            this.labeltv.AutoSize = true;
            this.labeltv.Location = new System.Drawing.Point(571, 58);
            this.labeltv.Name = "labeltv";
            this.labeltv.Size = new System.Drawing.Size(52, 13);
            this.labeltv.TabIndex = 3;
            this.labeltv.Text = "TreeView";
            this.labeltv.DragDrop += new System.Windows.Forms.DragEventHandler(this.labeltv_DragDrop);
            this.labeltv.DragEnter += new System.Windows.Forms.DragEventHandler(this.labeltv_DragEnter);
            // 
            // statusStripS
            // 
            this.statusStripS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLbS});
            this.statusStripS.Location = new System.Drawing.Point(0, 428);
            this.statusStripS.Name = "statusStripS";
            this.statusStripS.Size = new System.Drawing.Size(800, 22);
            this.statusStripS.TabIndex = 4;
            this.statusStripS.Text = "statusStrip1";
            // 
            // toolStripLbS
            // 
            this.toolStripLbS.Name = "toolStripLbS";
            this.toolStripLbS.Size = new System.Drawing.Size(105, 17);
            this.toolStripLbS.Text = "Ati selectat nodul: ";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripS);
            this.Controls.Add(this.labeltv);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Name = "Stats";
            this.Text = "Stats";
            this.statusStripS.ResumeLayout(false);
            this.statusStripS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label labeltv;
        private System.Windows.Forms.StatusStrip statusStripS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLbS;
    }
}
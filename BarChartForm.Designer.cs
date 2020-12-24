namespace Cabinet_Medical_Alexandru_Andra_1052
{
    partial class BarChartForm
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
            this.controlBarChar1 = new HistogramaLibrary.ControlBarChar();
            this.SuspendLayout();
            // 
            // controlBarChar1
            // 
            this.controlBarChar1.Location = new System.Drawing.Point(30, 12);
            this.controlBarChar1.Name = "controlBarChar1";
            this.controlBarChar1.Size = new System.Drawing.Size(736, 426);
            this.controlBarChar1.TabIndex = 0;
            // 
            // BarChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlBarChar1);
            this.Name = "BarChartForm";
            this.Text = "BarChartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private HistogramaLibrary.ControlBarChar controlBarChar1;
    }
}
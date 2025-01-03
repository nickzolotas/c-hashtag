namespace Askhsh1
{
    partial class DeleteEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            deleteEntry_label = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(0, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 395);
            panel1.TabIndex = 0;
            // 
            // deleteEntry_label
            // 
            deleteEntry_label.AutoSize = true;
            deleteEntry_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteEntry_label.ForeColor = SystemColors.HighlightText;
            deleteEntry_label.Location = new Point(275, 100);
            deleteEntry_label.Name = "deleteEntry_label";
            deleteEntry_label.Size = new Size(231, 31);
            deleteEntry_label.TabIndex = 35;
            deleteEntry_label.Text = "Διαγραφή εγγραφής";
            // 
            // DeleteEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(deleteEntry_label);
            Controls.Add(panel1);
            Name = "DeleteEntry";
            Size = new Size(781, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label deleteEntry_label;
    }
}

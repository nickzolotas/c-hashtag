namespace Askhsh1
{
    partial class EntriesByPerson
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
            allEntries_label = new Label();
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
            // allEntries_label
            // 
            allEntries_label.AutoSize = true;
            allEntries_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allEntries_label.ForeColor = SystemColors.HighlightText;
            allEntries_label.Location = new Point(292, 100);
            allEntries_label.Name = "allEntries_label";
            allEntries_label.Size = new Size(198, 31);
            allEntries_label.TabIndex = 35;
            allEntries_label.Text = "Όλα τα αιτήματα";
            // 
            // EntriesByPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(allEntries_label);
            Controls.Add(panel1);
            Name = "EntriesByPerson";
            Size = new Size(781, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label allEntries_label;
    }
}

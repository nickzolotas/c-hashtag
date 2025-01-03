namespace Askhsh1
{
    partial class StartingScreen
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
            label1 = new Label();
            newRequest = new Button();
            allRequests = new Button();
            requestsByPerson = new Button();
            deleteEntry = new Button();
            editEntry = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(282, 100);
            label1.Name = "label1";
            label1.Size = new Size(231, 31);
            label1.TabIndex = 0;
            label1.Text = "Επιλέξτε λειτουργία:";
            // 
            // newRequest
            // 
            newRequest.Location = new Point(232, 70);
            newRequest.Name = "newRequest";
            newRequest.Size = new Size(317, 40);
            newRequest.TabIndex = 1;
            newRequest.Text = "Εισαγωγή νέου αιτήματος";
            newRequest.UseVisualStyleBackColor = true;
            newRequest.Click += newRequest_Click;
            // 
            // allRequests
            // 
            allRequests.Location = new Point(232, 116);
            allRequests.Name = "allRequests";
            allRequests.Size = new Size(317, 40);
            allRequests.TabIndex = 2;
            allRequests.Text = "Προβολή όλων των αιτημάτων (συνολικά)";
            allRequests.UseVisualStyleBackColor = true;
            allRequests.Click += allRequests_Click;
            // 
            // requestsByPerson
            // 
            requestsByPerson.Location = new Point(232, 162);
            requestsByPerson.Name = "requestsByPerson";
            requestsByPerson.Size = new Size(317, 40);
            requestsByPerson.TabIndex = 3;
            requestsByPerson.Text = "Προβολή όλων των αιτημάτων (ανά πολίτη)";
            requestsByPerson.UseVisualStyleBackColor = true;
            requestsByPerson.Click += requestsByPerson_Click;
            // 
            // deleteEntry
            // 
            deleteEntry.Location = new Point(232, 208);
            deleteEntry.Name = "deleteEntry";
            deleteEntry.Size = new Size(317, 40);
            deleteEntry.TabIndex = 4;
            deleteEntry.Text = "Διαγραφή εγγραφής";
            deleteEntry.UseVisualStyleBackColor = true;
            deleteEntry.Click += deleteEntry_Click;
            // 
            // editEntry
            // 
            editEntry.Location = new Point(232, 254);
            editEntry.Name = "editEntry";
            editEntry.Size = new Size(317, 40);
            editEntry.TabIndex = 5;
            editEntry.Text = "Τροποποίηση εγγραφής";
            editEntry.UseVisualStyleBackColor = true;
            editEntry.Click += editEntry_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(editEntry);
            panel1.Controls.Add(newRequest);
            panel1.Controls.Add(deleteEntry);
            panel1.Controls.Add(allRequests);
            panel1.Controls.Add(requestsByPerson);
            panel1.Location = new Point(0, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 395);
            panel1.TabIndex = 6;
            // 
            // StartingScreen
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.HotTrack;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "StartingScreen";
            Size = new Size(781, 552);
            Load += StartingScreen_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button newRequest;
        private Button allRequests;
        private Button requestsByPerson;
        private Button deleteEntry;
        private Button editEntry;
        private Panel panel1;
    }
}

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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 55);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Επιλέξτε λειτουργία:";
            // 
            // newRequest
            // 
            newRequest.Location = new Point(95, 78);
            newRequest.Name = "newRequest";
            newRequest.Size = new Size(317, 40);
            newRequest.TabIndex = 1;
            newRequest.Text = "Εισαγωγή νέου αιτήματος";
            newRequest.UseVisualStyleBackColor = true;
            newRequest.Click += newRequest_Click;
            // 
            // allRequests
            // 
            allRequests.Location = new Point(95, 124);
            allRequests.Name = "allRequests";
            allRequests.Size = new Size(317, 40);
            allRequests.TabIndex = 2;
            allRequests.Text = "Προβολή όλων των αιτημάτων (συνολικά)";
            allRequests.UseVisualStyleBackColor = true;
            allRequests.Click += allRequests_Click;
            // 
            // requestsByPerson
            // 
            requestsByPerson.Location = new Point(95, 170);
            requestsByPerson.Name = "requestsByPerson";
            requestsByPerson.Size = new Size(317, 40);
            requestsByPerson.TabIndex = 3;
            requestsByPerson.Text = "Προβολή όλων των αιτημάτων (ανά πολίτη)";
            requestsByPerson.UseVisualStyleBackColor = true;
            requestsByPerson.Click += requestsByPerson_Click;
            // 
            // deleteEntry
            // 
            deleteEntry.Location = new Point(95, 216);
            deleteEntry.Name = "deleteEntry";
            deleteEntry.Size = new Size(317, 40);
            deleteEntry.TabIndex = 4;
            deleteEntry.Text = "Διαγραφή εγγραφής";
            deleteEntry.UseVisualStyleBackColor = true;
            deleteEntry.Click += deleteEntry_Click;
            // 
            // editEntry
            // 
            editEntry.Location = new Point(95, 262);
            editEntry.Name = "editEntry";
            editEntry.Size = new Size(317, 40);
            editEntry.TabIndex = 5;
            editEntry.Text = "Τροποποίηση εγγραφής";
            editEntry.UseVisualStyleBackColor = true;
            editEntry.Click += editEntry_Click;
            // 
            // StartingScreen
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(editEntry);
            Controls.Add(deleteEntry);
            Controls.Add(requestsByPerson);
            Controls.Add(allRequests);
            Controls.Add(newRequest);
            Controls.Add(label1);
            Name = "StartingScreen";
            Size = new Size(508, 403);
            Load += StartingScreen_Load;
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
    }
}

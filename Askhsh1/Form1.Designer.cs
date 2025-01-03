namespace Askhsh1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Name_box = new TextBox();
            Email_box = new TextBox();
            Number_box = new TextBox();
            Type_box = new TextBox();
            Address_box = new TextBox();
            Submit_button = new Button();
            name_label = new Label();
            email_label = new Label();
            number_label = new Label();
            birthplace_label = new Label();
            address_label = new Label();
            type_label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Cancel_button = new Button();
            newEntry_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Name_box
            // 
            Name_box.Location = new Point(355, 217);
            Name_box.Margin = new Padding(4);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(248, 27);
            Name_box.TabIndex = 0;
            // 
            // Email_box
            // 
            Email_box.Location = new Point(355, 252);
            Email_box.Margin = new Padding(4);
            Email_box.Name = "Email_box";
            Email_box.Size = new Size(248, 27);
            Email_box.TabIndex = 1;
            // 
            // Number_box
            // 
            Number_box.Location = new Point(355, 287);
            Number_box.Margin = new Padding(4);
            Number_box.Name = "Number_box";
            Number_box.Size = new Size(248, 27);
            Number_box.TabIndex = 2;
            // 
            // Type_box
            // 
            Type_box.Location = new Point(355, 357);
            Type_box.Margin = new Padding(4);
            Type_box.Name = "Type_box";
            Type_box.Size = new Size(248, 27);
            Type_box.TabIndex = 3;
            // 
            // Address_box
            // 
            Address_box.Location = new Point(355, 392);
            Address_box.Margin = new Padding(4);
            Address_box.Name = "Address_box";
            Address_box.Size = new Size(248, 27);
            Address_box.TabIndex = 4;
            // 
            // Submit_button
            // 
            Submit_button.BackColor = Color.SeaGreen;
            Submit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit_button.ForeColor = SystemColors.ButtonHighlight;
            Submit_button.Location = new Point(483, 269);
            Submit_button.Margin = new Padding(4);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(120, 36);
            Submit_button.TabIndex = 5;
            Submit_button.Text = "Υποβολή";
            Submit_button.UseVisualStyleBackColor = false;
            Submit_button.Click += Submit_button_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.BackColor = Color.FromArgb(64, 64, 64);
            name_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_label.ForeColor = SystemColors.HighlightText;
            name_label.Location = new Point(181, 220);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(131, 20);
            name_label.TabIndex = 9;
            name_label.Text = "Ονοματεπώνυμo:";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.BackColor = Color.FromArgb(64, 64, 64);
            email_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_label.ForeColor = SystemColors.HighlightText;
            email_label.Location = new Point(181, 255);
            email_label.Margin = new Padding(4, 0, 4, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(56, 20);
            email_label.TabIndex = 10;
            email_label.Text = "e-mail:";
            // 
            // number_label
            // 
            number_label.AutoSize = true;
            number_label.BackColor = Color.FromArgb(64, 64, 64);
            number_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number_label.ForeColor = SystemColors.HighlightText;
            number_label.Location = new Point(181, 290);
            number_label.Margin = new Padding(4, 0, 4, 0);
            number_label.Name = "number_label";
            number_label.Size = new Size(84, 20);
            number_label.TabIndex = 11;
            number_label.Text = "Τηλέφωνο:";
            // 
            // birthplace_label
            // 
            birthplace_label.AutoSize = true;
            birthplace_label.BackColor = Color.FromArgb(64, 64, 64);
            birthplace_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthplace_label.ForeColor = SystemColors.HighlightText;
            birthplace_label.Location = new Point(181, 327);
            birthplace_label.Margin = new Padding(4, 0, 4, 0);
            birthplace_label.Name = "birthplace_label";
            birthplace_label.Size = new Size(166, 20);
            birthplace_label.TabIndex = 12;
            birthplace_label.Text = "Ημερομηνία γέννησης:";
            birthplace_label.Click += birthplace_label_Click;
            // 
            // address_label
            // 
            address_label.AutoSize = true;
            address_label.BackColor = Color.FromArgb(64, 64, 64);
            address_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address_label.ForeColor = SystemColors.HighlightText;
            address_label.Location = new Point(181, 395);
            address_label.Margin = new Padding(4, 0, 4, 0);
            address_label.Name = "address_label";
            address_label.Size = new Size(157, 20);
            address_label.TabIndex = 13;
            address_label.Text = "Διεύθυνση κατοικίας:";
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.BackColor = Color.FromArgb(64, 64, 64);
            type_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_label.ForeColor = SystemColors.HighlightText;
            type_label.Location = new Point(181, 360);
            type_label.Margin = new Padding(4, 0, 4, 0);
            type_label.Name = "type_label";
            type_label.Size = new Size(126, 20);
            type_label.TabIndex = 14;
            type_label.Text = "Είδος αιτήματος:";
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.Firebrick;
            Cancel_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_button.ForeColor = SystemColors.ButtonHighlight;
            Cancel_button.Location = new Point(355, 269);
            Cancel_button.Margin = new Padding(4);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(120, 36);
            Cancel_button.TabIndex = 16;
            Cancel_button.Text = "Ακύρωση";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // newEntry_label
            // 
            newEntry_label.AutoSize = true;
            newEntry_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newEntry_label.ForeColor = SystemColors.HighlightText;
            newEntry_label.Location = new Point(251, 100);
            newEntry_label.Name = "newEntry_label";
            newEntry_label.Size = new Size(291, 31);
            newEntry_label.TabIndex = 17;
            newEntry_label.Text = "Εισαγωγή νέου αιτήματος";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(355, 322);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(Submit_button);
            panel1.Controls.Add(Cancel_button);
            panel1.Location = new Point(0, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 395);
            panel1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(782, 553);
            Controls.Add(newEntry_label);
            Controls.Add(type_label);
            Controls.Add(address_label);
            Controls.Add(birthplace_label);
            Controls.Add(number_label);
            Controls.Add(email_label);
            Controls.Add(name_label);
            Controls.Add(dateTimePicker1);
            Controls.Add(Address_box);
            Controls.Add(Type_box);
            Controls.Add(Number_box);
            Controls.Add(Email_box);
            Controls.Add(Name_box);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name_box;
        private TextBox Email_box;
        private TextBox Number_box;
        private TextBox Type_box;
        private TextBox Address_box;
        private Button Submit_button;
        private Label name_label;
        private Label email_label;
        private Label number_label;
        private Label birthplace_label;
        private Label address_label;
        private Label type_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Cancel_button;
        private Label newEntry_label;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
    }
}

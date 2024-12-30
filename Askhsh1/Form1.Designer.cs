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
            dateTimePicker1 = new DateTimePicker();
            name_label = new Label();
            email_label = new Label();
            number_label = new Label();
            birthplace_label = new Label();
            address_label = new Label();
            type_label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            startingScreen1 = new StartingScreen();
            SuspendLayout();
            // 
            // Name_box
            // 
            Name_box.Location = new Point(182, 99);
            Name_box.Margin = new Padding(4);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(246, 27);
            Name_box.TabIndex = 0;
            // 
            // Email_box
            // 
            Email_box.Location = new Point(182, 135);
            Email_box.Margin = new Padding(4);
            Email_box.Name = "Email_box";
            Email_box.Size = new Size(246, 27);
            Email_box.TabIndex = 1;
            // 
            // Number_box
            // 
            Number_box.Location = new Point(182, 171);
            Number_box.Margin = new Padding(4);
            Number_box.Name = "Number_box";
            Number_box.Size = new Size(246, 27);
            Number_box.TabIndex = 2;
            // 
            // Type_box
            // 
            Type_box.Location = new Point(182, 244);
            Type_box.Margin = new Padding(4);
            Type_box.Name = "Type_box";
            Type_box.Size = new Size(246, 27);
            Type_box.TabIndex = 3;
            // 
            // Address_box
            // 
            Address_box.Location = new Point(182, 280);
            Address_box.Margin = new Padding(4);
            Address_box.Name = "Address_box";
            Address_box.Size = new Size(246, 27);
            Address_box.TabIndex = 4;
            // 
            // Submit_button
            // 
            Submit_button.Location = new Point(182, 316);
            Submit_button.Margin = new Padding(4);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(94, 29);
            Submit_button.TabIndex = 5;
            Submit_button.Text = "Υποβολή";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_button_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 208);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(15, 106);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(127, 20);
            name_label.TabIndex = 9;
            name_label.Text = "Ονοματεπώνυμo:";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(15, 142);
            email_label.Margin = new Padding(4, 0, 4, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(55, 20);
            email_label.TabIndex = 10;
            email_label.Text = "e-mail:";
            // 
            // number_label
            // 
            number_label.AutoSize = true;
            number_label.Location = new Point(15, 178);
            number_label.Margin = new Padding(4, 0, 4, 0);
            number_label.Name = "number_label";
            number_label.Size = new Size(82, 20);
            number_label.TabIndex = 11;
            number_label.Text = "Τηλέφωνο:";
            // 
            // birthplace_label
            // 
            birthplace_label.AutoSize = true;
            birthplace_label.Location = new Point(15, 215);
            birthplace_label.Margin = new Padding(4, 0, 4, 0);
            birthplace_label.Name = "birthplace_label";
            birthplace_label.Size = new Size(165, 20);
            birthplace_label.TabIndex = 12;
            birthplace_label.Text = "Ημερομηνία γέννησης:";
            birthplace_label.Click += birthplace_label_Click;
            // 
            // address_label
            // 
            address_label.AutoSize = true;
            address_label.Location = new Point(15, 287);
            address_label.Margin = new Padding(4, 0, 4, 0);
            address_label.Name = "address_label";
            address_label.Size = new Size(153, 20);
            address_label.TabIndex = 13;
            address_label.Text = "Διεύθυνση κατοικίας:";
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Location = new Point(15, 251);
            type_label.Margin = new Padding(4, 0, 4, 0);
            type_label.Name = "type_label";
            type_label.Size = new Size(123, 20);
            type_label.TabIndex = 14;
            type_label.Text = "Είδος αιτήματος:";
            // 
            // startingScreen1
            // 
            startingScreen1.Location = new Point(12, 12);
            startingScreen1.Name = "startingScreen1";
            startingScreen1.Size = new Size(635, 504);
            startingScreen1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(669, 538);
            Controls.Add(startingScreen1);
            Controls.Add(type_label);
            Controls.Add(address_label);
            Controls.Add(birthplace_label);
            Controls.Add(number_label);
            Controls.Add(email_label);
            Controls.Add(name_label);
            Controls.Add(dateTimePicker1);
            Controls.Add(Submit_button);
            Controls.Add(Address_box);
            Controls.Add(Type_box);
            Controls.Add(Number_box);
            Controls.Add(Email_box);
            Controls.Add(Name_box);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
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
        private DateTimePicker dateTimePicker1;
        private Label name_label;
        private Label email_label;
        private Label number_label;
        private Label birthplace_label;
        private Label address_label;
        private Label type_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private StartingScreen startingScreen1;
    }
}

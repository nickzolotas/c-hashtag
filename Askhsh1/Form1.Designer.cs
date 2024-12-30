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
            menuStrip1 = new MenuStrip();
            Function_box = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // Name_box
            // 
            Name_box.Location = new Point(108, 84);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(100, 23);
            Name_box.TabIndex = 0;
            // 
            // Email_box
            // 
            Email_box.Location = new Point(108, 113);
            Email_box.Name = "Email_box";
            Email_box.Size = new Size(100, 23);
            Email_box.TabIndex = 1;
            // 
            // Number_box
            // 
            Number_box.Location = new Point(108, 142);
            Number_box.Name = "Number_box";
            Number_box.Size = new Size(100, 23);
            Number_box.TabIndex = 2;
            // 
            // Type_box
            // 
            Type_box.Location = new Point(108, 200);
            Type_box.Name = "Type_box";
            Type_box.Size = new Size(100, 23);
            Type_box.TabIndex = 3;
            // 
            // Address_box
            // 
            Address_box.Location = new Point(108, 229);
            Address_box.Name = "Address_box";
            Address_box.Size = new Size(100, 23);
            Address_box.TabIndex = 4;
            // 
            // Submit_button
            // 
            Submit_button.Location = new Point(121, 258);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(75, 23);
            Submit_button.TabIndex = 5;
            Submit_button.Text = "button1";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // Function_box
            // 
            Function_box.FormattingEnabled = true;
            Function_box.Items.AddRange(new object[] { "Εισαγωγή νέου αιτήματος", "Προβολή όλων των αιτημάτων", "Διαγραφή εγγραφής", "Τροποποίηση εγγραφής" });
            Function_box.Location = new Point(108, 55);
            Function_box.Name = "Function_box";
            Function_box.Size = new Size(145, 23);
            Function_box.TabIndex = 7;
            Function_box.SelectedIndexChanged += Function_box_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(Function_box);
            Controls.Add(Submit_button);
            Controls.Add(Address_box);
            Controls.Add(Type_box);
            Controls.Add(Number_box);
            Controls.Add(Email_box);
            Controls.Add(Name_box);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
        private MenuStrip menuStrip1;
        private ComboBox Function_box;
        private DateTimePicker dateTimePicker1;
    }
}

namespace Askhsh1
{
    partial class AllEntries
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            Cancel_button2 = new Button();
            search_button = new Button();
            phone_label = new Label();
            Phone_box = new TextBox();
            editEntry_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(Cancel_button2);
            panel1.Controls.Add(search_button);
            panel1.Controls.Add(phone_label);
            panel1.Controls.Add(Phone_box);
            panel1.Location = new Point(0, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 395);
            panel1.TabIndex = 1;
            // 
            // Cancel_button2
            // 
            Cancel_button2.BackColor = Color.Firebrick;
            Cancel_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_button2.ForeColor = SystemColors.ButtonHighlight;
            Cancel_button2.Location = new Point(353, 204);
            Cancel_button2.Margin = new Padding(4);
            Cancel_button2.Name = "Cancel_button2";
            Cancel_button2.Size = new Size(120, 36);
            Cancel_button2.TabIndex = 17;
            Cancel_button2.Text = "Ακύρωση";
            Cancel_button2.UseVisualStyleBackColor = false;
            Cancel_button2.Click += Cancel_button2_Click;
            // 
            // search_button
            // 
            search_button.BackColor = Color.SeaGreen;
            search_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_button.ForeColor = SystemColors.HighlightText;
            search_button.Location = new Point(477, 204);
            search_button.Name = "search_button";
            search_button.Size = new Size(120, 36);
            search_button.TabIndex = 3;
            search_button.Text = "Αναζήτηση";
            search_button.UseVisualStyleBackColor = false;
            search_button.Click += search_button_Click;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_label.ForeColor = SystemColors.HighlightText;
            phone_label.Location = new Point(191, 172);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(155, 20);
            phone_label.TabIndex = 2;
            phone_label.Text = "Αριθμός τηλεφώνου:";
            phone_label.Click += label1_Click;
            // 
            // Phone_box
            // 
            Phone_box.Location = new Point(353, 169);
            Phone_box.Margin = new Padding(4);
            Phone_box.Name = "Phone_box";
            Phone_box.Size = new Size(244, 27);
            Phone_box.TabIndex = 1;
            // 
            // editEntry_label
            // 
            editEntry_label.AutoSize = true;
            editEntry_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editEntry_label.ForeColor = SystemColors.HighlightText;
            editEntry_label.Location = new Point(221, 100);
            editEntry_label.Name = "editEntry_label";
            editEntry_label.Size = new Size(340, 31);
            editEntry_label.TabIndex = 35;
            editEntry_label.Text = "Όλα τα αιτήματα (ανά πολίτη)";
            // 
            // AllEntries
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.HotTrack;
            Controls.Add(editEntry_label);
            Controls.Add(panel1);
            Name = "AllEntries";
            Size = new Size(781, 552);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label editEntry_label;
        private TextBox Phone_box;
        private Label phone_label;
        private Button search_button;
        private Button Cancel_button2;
    }
}

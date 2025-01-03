using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhsh1
{
    public partial class ReqByPerson : UserControl
    {
        public ReqByPerson()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search_button.Hide();
            phone_label.Hide();
            Phone_box.Hide();
            dataGridView1.Show();
        }

        private void Cancel_button2_Click(object sender, EventArgs e)
        {
            Phone_box.Text = "";
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Hide();
                    if (control is StartingScreen)
                    {
                        control.Show();
                    }
                }

            }
        }
    }
}

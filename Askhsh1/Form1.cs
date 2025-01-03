using System.Drawing.Text;
using System.IO.Packaging;

namespace Askhsh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Data.StartDB();
            InitializeComponent();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {

        }

        private void birthplace_label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startingScreen1_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if(control is UserControl)
                {
                    control.Hide();

                    Name_box.Text = "";
                    Email_box.Text = "";
                    Number_box.Text = "";
                    Type_box.Text = "";
                    Address_box.Text = "";

                    if (control is StartingScreen)
                    { 
                        control.Show();
                    }
                }
               
            }
        }
    }
}
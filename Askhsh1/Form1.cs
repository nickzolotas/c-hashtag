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

        private void Function_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Function_box.SelectedIndex.ToString())
            {
                case "Εισαγωγή νέου αιτήματος":
                    Name_box.Visible = true;

                    break;
                case "Προβολή όλων των αιτημάτων":
                    Name_box.Visible = false;

                    break;
                case "Διαγραφή εγγραφής":
                    Name_box.Visible = true;

                    break;
                case "Τροποποίηση εγγραφής":
                    Name_box.Visible = false;
                    break;
                default:

                    break;
            }
        }
    }
}

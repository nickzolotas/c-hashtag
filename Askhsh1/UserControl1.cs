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
    public partial class StartingScreen : UserControl
    {
        public StartingScreen()
        {
            InitializeComponent();
        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {

        }

        private void newRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void allRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    c.Hide();
                }
                if (c is AllReq)
                {
                    c.Show();
                }
            }
        }

        private void requestsByPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    c.Hide();
                }
                if (c is ReqByPerson)
                {
                    c.Show();
                }
            }
        }

        private void deleteEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    c.Hide();
                }
                if (c is DeleteEntry)
                {
                    c.Show();
                }
            }
        }

        private void editEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    c.Hide();
                }
                if (c is EditEntry)
                {
                    c.Show();
                }
            }
        }
    }
}
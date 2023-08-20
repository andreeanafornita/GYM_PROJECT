using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProjectPWA
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }


        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();  
            addMemberForm.ShowDialog();
            this.Hide();
        }

        private void btnCreateMembership_Click(object sender, EventArgs e)
        {

            DisplayMembershipType displayMembershipType = new DisplayMembershipType();
            displayMembershipType.ShowDialog();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();   
            intro.ShowDialog();
            this.Hide();
        }
    }
}

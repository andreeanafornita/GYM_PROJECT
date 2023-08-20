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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
          
            Intro intro = new Intro();
            intro.Show();

        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            ShowMembers showMembers = new ShowMembers();    
            showMembers.Show();

        }

        private void btnRaports_Click(object sender, EventArgs e)
        {
            ShowGrafic showGrafic = new ShowGrafic();
            showGrafic.Show();
        }

        
    }
}

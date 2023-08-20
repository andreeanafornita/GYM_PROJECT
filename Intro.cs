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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm mainForm = new ClientForm(); 
            mainForm.ShowDialog();  
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();  
            admin.ShowDialog();
            this.Close();
        }
    }
}

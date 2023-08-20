using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProjectPWA
{
    public partial class AddMembershipType : Form
    {
        public AddMembershipType()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(tbPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int duration;
            if (!int.TryParse(tbDuration.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Please enter a valid duration.");
                return;
            }

            var membershipTypeRepository = new MembershipTypeRepository();

            var membershipType = new MembershipType
            {
                Name = tbName.Text,
                Price = price,
                DurationInDays = duration
            };

            membershipTypeRepository.Add(membershipType);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(fs, membershipTypeRepository);
            fs.Close();

            MessageBox.Show("Membership type added successfully!");
            this.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm mainForm = new ClientForm(); 
            mainForm.ShowDialog();
        }
    }
}

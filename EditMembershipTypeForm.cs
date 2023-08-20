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
    public partial class EditMembershipTypeForm : Form
    {
        private MembershipType membershipType;
        public EditMembershipTypeForm(MembershipType membershipType)
        {
            InitializeComponent();
            textBoxName.Text = membershipType.Name;
            textBoxPrice.Text = membershipType.Price.ToString();
            textBoxDurationInDays.Text = membershipType.DurationInDays.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            membershipType.Name = textBoxName.Text;
            membershipType.Price = decimal.Parse(textBoxPrice.Text);
            membershipType.DurationInDays = int.Parse(textBoxDurationInDays.Text);

            // Set the DialogResult property to indicate that the form was closed successfully
            this.DialogResult = DialogResult.OK;

            // Close the form
            this.Close();
        }
    }
}

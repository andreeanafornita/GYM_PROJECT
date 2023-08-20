using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProjectPWA
{
    public partial class DisplayMembershipType : Form
    {
        private List<MembershipType> membershipTypes;
        public DisplayMembershipType()
        {
            InitializeComponent();
            loadDataInListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();  
            addMemberForm.ShowDialog();
            this.Close();
        }

        private void loadDataInListView()
        {
            
            using (StreamReader sr = new StreamReader("membershiptype.txt"))
            {
                membershipTypes = new List<MembershipType>();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    int id = int.Parse(fields[0]);
                    string name = fields[1];
                    decimal price = decimal.Parse(fields[2]);
                    int durationInDays = int.Parse(fields[3]);

                    MembershipType membershipType = new MembershipType
                    {
                        Id = id,
                        Name = name,
                        Price = price,
                        DurationInDays = durationInDays
                    };

                    
                    membershipTypes.Add(membershipType);
                }
                lvMembership.View = View.Details;
                lvMembership.Columns.Add("ID");
                lvMembership.Columns.Add("Name");
                lvMembership.Columns.Add("Price");
                lvMembership.Columns.Add("Duration in Days");

                foreach (MembershipType membershipType in membershipTypes)
                {
                    ListViewItem item = new ListViewItem(membershipType.Id.ToString());
                    item.SubItems.Add(membershipType.Name);
                    item.SubItems.Add(membershipType.Price.ToString());
                    item.SubItems.Add(membershipType.DurationInDays.ToString());
                    lvMembership.Items.Add(item);
                }
            }

        }

        private void lvMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMembership.SelectedItems.Count == 0)
            {
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = lvMembership.SelectedItems[0];

            // Extract the MembershipType object from the Tag property of the ListViewItem
            MembershipType selectedMembershipType = (MembershipType)selectedItem.Tag;

            // Create a new instance of the AddMemberForm
            AddMemberForm addMemberForm = new AddMemberForm();

            // Pass the selected MembershipType object to the AddMemberForm

            // Show the AddMemberForm
            addMemberForm.Show();
        }

        private void lvMembership_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected membership type from the ListView
                MembershipType selectedMembershipType = membershipTypes[e.ItemIndex-1];

                // Open a new form to edit the membership type
                EditMembershipTypeForm editForm = new EditMembershipTypeForm(selectedMembershipType);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the ListView item with the edited membership type data
                    e.Item.SubItems[1].Text = selectedMembershipType.Name;
                    e.Item.SubItems[2].Text = selectedMembershipType.Price.ToString();
                    e.Item.SubItems[3].Text = selectedMembershipType.DurationInDays.ToString();

                    // Save the edited membership type to the txt file
                    UpdateMembershipType(selectedMembershipType);
                }
            }
        }

        public void UpdateMembershipType(MembershipType membershipTypeToUpdate)
        {
            // Step 1: Read data from the txt file
            List<MembershipType> membershipTypes = new List<MembershipType>();
            using (StreamReader sr = new StreamReader("membershipTypes.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    int id = int.Parse(fields[0]);
                    string name = fields[1];
                    decimal price = decimal.Parse(fields[2]);
                    int durationInDays = int.Parse(fields[3]);

                    MembershipType membershipType = new MembershipType
                    {
                        Id = id,
                        Name = name,
                        Price = price,
                        DurationInDays = durationInDays
                    };

                    membershipTypes.Add(membershipType);
                }
            }

            // Step 2: Find the membership type to update in the list
            MembershipType membershipTypeFound = membershipTypes.Find(mt => mt.Id == membershipTypeToUpdate.Id);

            if (membershipTypeFound != null)
            {
                // Step 3: Update the membership type with the new values
                membershipTypeFound.Name = membershipTypeToUpdate.Name;
                membershipTypeFound.Price = membershipTypeToUpdate.Price;
                membershipTypeFound.DurationInDays = membershipTypeToUpdate.DurationInDays;

                // Step 4: Save the updated list to the txt file
                using (StreamWriter sw = new StreamWriter("membershipTypes.txt"))
                {
                    foreach (MembershipType membershipType in membershipTypes)
                    {
                        string line = $"{membershipType.Id},{membershipType.Name},{membershipType.Price},{membershipType.DurationInDays}";
                        sw.WriteLine(line);
                    }
                }
            }
        }

    }
}

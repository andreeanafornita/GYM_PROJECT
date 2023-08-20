using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace GymProjectPWA
{
    public partial class AddMemberForm : Form
    {
        private readonly MemberRepository memberRepository;
        private readonly MembershipTypeRepository membershipTypeRepository;
        Member member;
        Payment payments;
        public AddMemberForm()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
            membershipTypeRepository = new MembershipTypeRepository();
            tbVisible.Visible = false;
            LoadData();
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.Match(phone, @"^\+?\d{10,12}$").Success;
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            if (dtpDateOfBirth.Value >= DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (!IsValidPhone(tbPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            if (cbMembershipType.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid membership type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPayment.Text))
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            decimal paymentAmount;
            if (!decimal.TryParse(tbPayment.Text, out paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            var membershipTypeId = (int)cbMembershipType.SelectedValue;
            var membershipType = membershipTypeRepository.GetById(membershipTypeId);

            var member = new Member
            {
                Name = tbName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Email = tbEmail.Text,
                Phone = tbPhone.Text,
                MembershipType = membershipType,
                RegistrationDate = DateTime.Now,
            };

            var payment = new Payment
            {
                Member = member,
                Amount = paymentAmount,
                PaymentDate = DateTime.Now,
            };

            member.Payments.Add(payment);

            memberRepository.Add(member);

            MessageBox.Show("Member added successfully!");

            Close();
        }
        private void LoadMembershipTypes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.OpenOrCreate,
                FileAccess.Read);

            try
            {
                // Deserialize the object from the file
                MembershipTypeRepository membershipTypeRepository = (MembershipTypeRepository)bf.Deserialize(fs);

                // Load the membership type names into the combo box
                foreach (MembershipType membershipType in membershipTypeRepository._membershipTypes)
                {
                    cbMembershipType.Items.Add(membershipType.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the file stream
                fs.Close();
            }

        }

        public void LoadData()
        {
            string[] lines = File.ReadAllLines("membershiptype.txt");

            List<MembershipType> membershipTypes = new List<MembershipType>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                MembershipType membershipType = new MembershipType
                {
                    Id = int.Parse(parts[0]),
                    Name = parts[1],
                    Price = decimal.Parse(parts[2]),
                    DurationInDays = int.Parse(parts[3])
                };
                membershipTypes.Add(membershipType);
            }

            cbMembershipType.DataSource = membershipTypes;
            cbMembershipType.DisplayMember = "Name";
           
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //// Build the connection string for the Access database
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=path/to/database.accdb;Persist Security Info=False;";

            //// Create a new OleDbConnection object
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    // Open the connection
            //    connection.Open();

            //    // Create a new OleDbCommand object with the SQL statement to insert the data
            //    OleDbCommand command = new OleDbCommand("INSERT INTO Members (Name, DateOfBirth, Email, Phone, MembershipType, RegistrationDate, PaymentAmount, PaymentDate) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", connection);

            //    // Set the parameters for the command
            //    command.Parameters.AddWithValue("@Name", member.Name);
            //    command.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth);
            //    command.Parameters.AddWithValue("@Email", member.Email);
            //    command.Parameters.AddWithValue("@Phone", member.Phone);
            //    command.Parameters.AddWithValue("@MembershipType", member.MembershipType.Name);
            //    command.Parameters.AddWithValue("@RegistrationDate", member.RegistrationDate);
            //    command.Parameters.AddWithValue("@PaymentAmount", payment.Amount);
            //    command.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);

            //    // Execute the command
            //    command.ExecuteNonQuery();
            //}

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm(); 
            form.ShowDialog();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(tbVisible.Text);
                sw.Close();
                tbVisible.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Members.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "SELECT MAX(id) FROM members";
                int cod = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "INSERT INTO members (ID, nameOfClient, dateOfBirth, email, phone, membershipType, registrationTime, payment, paymentDate) " +
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                cmd.Parameters.Add("@ID", OleDbType.Integer).Value = cod + 1;
                cmd.Parameters.AddWithValue("@nameOfClient", this.tbName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", this.dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@email", this.tbEmail.Text);
                cmd.Parameters.AddWithValue("@phone", this.tbPhone.Text);
                cmd.Parameters.AddWithValue("@membershipType", this.cbMembershipType.Text);
                cmd.Parameters.AddWithValue("@registrationTime", this.dtpRegistrationTime.Value);
                cmd.Parameters.AddWithValue("@payment", this.tbPayment.Text);
                cmd.Parameters.AddWithValue("@paymentDate", this.dtpPaymentDay.Value);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }
    }
    
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProjectPWA
{
    public partial class ShowMembers : Form
    {
        string connString;
        public ShowMembers()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Members.accdb";
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            lvLoadedData.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM members";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nameOfClient"].ToString());
                    itm.SubItems.Add(reader["dateofbirth"].ToString());
                    itm.SubItems.Add(reader["email"].ToString());
                    itm.SubItems.Add(reader["phone"].ToString());
                    itm.SubItems.Add(reader["membershiptype"].ToString());
                    itm.SubItems.Add(reader["registrationtime"].ToString());
                    itm.SubItems.Add(reader["payment"].ToString());
                    itm.SubItems.Add(reader["paymentdate"].ToString());

                    lvLoadedData.Items.Add(itm);


                }
                reader.Close();
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

        private void lvLoadedData_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvLoadedData.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvModifiedData_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvModifiedData_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                lvModifiedData.Items.Add(item.Text);
                lvLoadedData.Items.Remove(item);
            }

        }

        private void lvModifiedData_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvModifiedData.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvLoadedData_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                lvLoadedData.Items.Add(item.Text);
                lvModifiedData.Items.Remove(item);
            }
        }

        private void lvLoadedData_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a stream writer to write to the file
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write the column headers
                    for (int i = 0; i < lvModifiedData.Columns.Count; i++)
                    {
                        writer.Write(lvModifiedData.Columns[i].Text);
                        if (i < lvModifiedData.Columns.Count - 1)
                        {
                            writer.Write("\t");
                        }
                    }
                    writer.WriteLine();

                    // Write the items and subitems
                    foreach (ListViewItem item in lvModifiedData.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            writer.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void lvModifiedData_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            System.Windows.Forms.ListView listView = lvLoadedData; // Replace 'listView1' with the actual name of your ListView control
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            int y = 100; // Starting y-coordinate for printing

            foreach (ListViewItem item in listView.Items)
            {
                string line = "";
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    line += subItem.Text + " ";
                }

                e.Graphics.DrawString(line, font, brush, 100, y); // Adjust the x-coordinate as needed
                y += 20; // Increment the y-coordinate for the next line
            }
        }
    }
}
    


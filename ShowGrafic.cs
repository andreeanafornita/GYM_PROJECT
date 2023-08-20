using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace GymProjectPWA
{
   
    public partial class ShowGrafic : Form
    {
        string connString;
        public ShowGrafic()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Members.accdb";
            PopulateListViewAndCreatePieChart();
        }


    private void PopulateListViewAndCreatePieChart()
    {
        lvLoadedData.Items.Clear();

        // Create a dictionary to store membership type counts
        Dictionary<string, int> membershipTypeCounts = new Dictionary<string, int>();

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
                // Populate ListView
                ListViewItem itm = new ListViewItem(reader["nameOfClient"].ToString());
                itm.SubItems.Add(reader["dateofbirth"].ToString());
                itm.SubItems.Add(reader["email"].ToString());
                itm.SubItems.Add(reader["phone"].ToString());
                itm.SubItems.Add(reader["membershiptype"].ToString());
                itm.SubItems.Add(reader["registrationtime"].ToString());
                itm.SubItems.Add(reader["payment"].ToString());
                itm.SubItems.Add(reader["paymentdate"].ToString());

                lvLoadedData.Items.Add(itm);

                // Update membership type counts
                string membershipType = reader["membershiptype"].ToString();
                if (membershipTypeCounts.ContainsKey(membershipType))
                {
                    membershipTypeCounts[membershipType]++;
                }
                else
                {
                    membershipTypeCounts[membershipType] = 1;
                }
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

        // Generate data for pie chart
        ChartValues<ObservableValue> chartData = new ChartValues<ObservableValue>();
        foreach (var kvp in membershipTypeCounts)
        {
            chartData.Add(new ObservableValue(kvp.Value));
        }

        // Bind chart data to PieChart control
        pieChart.Series.Clear();
        pieChart.Series.Add(new PieSeries
        {
            Title = "Membership Types",
            Values = chartData,
            DataLabels = true
        });
    }

}
}

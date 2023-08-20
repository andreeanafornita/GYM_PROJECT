namespace GymProjectPWA
{
    partial class ShowGrafic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lvLoadedData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // lvLoadedData
            // 
            this.lvLoadedData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvLoadedData.HideSelection = false;
            this.lvLoadedData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvLoadedData.Location = new System.Drawing.Point(13, 54);
            this.lvLoadedData.Name = "lvLoadedData";
            this.lvLoadedData.Size = new System.Drawing.Size(656, 457);
            this.lvLoadedData.TabIndex = 2;
            this.lvLoadedData.UseCompatibleStateImageBehavior = false;
            this.lvLoadedData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DateOfBirth";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MembershipType";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "RegistrationDate";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Payment";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PaymentDate";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(636, 54);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(617, 449);
            this.pieChart.TabIndex = 3;
            this.pieChart.Text = "pieChart1";
            // 
            // ShowGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 583);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lvLoadedData);
            this.Name = "ShowGrafic";
            this.Text = "ShowGrafic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLoadedData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}
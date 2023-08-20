namespace GymProjectPWA
{
    partial class ShowMembers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMembers));
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lvLoadedData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvModifiedData = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportData = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(4, 13);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(97, 45);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lvLoadedData
            // 
            this.lvLoadedData.AllowDrop = true;
            this.lvLoadedData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvLoadedData.HideSelection = false;
            this.lvLoadedData.Location = new System.Drawing.Point(4, 79);
            this.lvLoadedData.Name = "lvLoadedData";
            this.lvLoadedData.Size = new System.Drawing.Size(620, 583);
            this.lvLoadedData.TabIndex = 1;
            this.lvLoadedData.UseCompatibleStateImageBehavior = false;
            this.lvLoadedData.View = System.Windows.Forms.View.Details;
            this.lvLoadedData.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvLoadedData_ItemDrag);
            this.lvLoadedData.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvLoadedData_DragDrop);
            this.lvLoadedData.DragOver += new System.Windows.Forms.DragEventHandler(this.lvLoadedData_DragOver);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DateOfBirth";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MembershipType";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RegistrationTime";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payment";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PaymentDate";
            // 
            // lvModifiedData
            // 
            this.lvModifiedData.AllowDrop = true;
            this.lvModifiedData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvModifiedData.HideSelection = false;
            this.lvModifiedData.Location = new System.Drawing.Point(674, 79);
            this.lvModifiedData.Name = "lvModifiedData";
            this.lvModifiedData.Size = new System.Drawing.Size(620, 583);
            this.lvModifiedData.TabIndex = 2;
            this.lvModifiedData.UseCompatibleStateImageBehavior = false;
            this.lvModifiedData.View = System.Windows.Forms.View.Details;
            this.lvModifiedData.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvModifiedData_ItemDrag);
            this.lvModifiedData.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvModifiedData_DragDrop);
            this.lvModifiedData.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvModifiedData_DragEnter);
            this.lvModifiedData.DragOver += new System.Windows.Forms.DragEventHandler(this.lvModifiedData_DragOver);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DateOfBirth";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Email";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Phone";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MembershipType";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "RegistrationTime";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Payment";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "PaymentDate";
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(1197, 13);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(97, 45);
            this.btnExportData.TabIndex = 3;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 28);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ShowMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1294, 662);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.lvModifiedData);
            this.Controls.Add(this.lvLoadedData);
            this.Controls.Add(this.btnLoadData);
            this.Name = "ShowMembers";
            this.Text = "ShowMembers";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ListView lvLoadedData;
        private System.Windows.Forms.ListView lvModifiedData;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
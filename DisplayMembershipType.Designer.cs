namespace GymProjectPWA
{
    partial class DisplayMembershipType
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
            this.lvMembership = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMembership
            // 
            this.lvMembership.HideSelection = false;
            this.lvMembership.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvMembership.Location = new System.Drawing.Point(23, 26);
            this.lvMembership.Name = "lvMembership";
            this.lvMembership.Size = new System.Drawing.Size(421, 386);
            this.lvMembership.TabIndex = 0;
            this.lvMembership.UseCompatibleStateImageBehavior = false;
            this.lvMembership.View = System.Windows.Forms.View.Tile;
            this.lvMembership.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMembership_ItemSelectionChanged);
            this.lvMembership.SelectedIndexChanged += new System.EventHandler(this.lvMembership_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy Membership";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayMembershipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvMembership);
            this.Name = "DisplayMembershipType";
            this.Text = "DisplayMembershipType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMembership;
        private System.Windows.Forms.Button button1;
    }
}
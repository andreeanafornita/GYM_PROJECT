namespace GymProjectPWA
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnShowMembers = new System.Windows.Forms.Button();
            this.btnRaports = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMembers
            // 
            this.btnShowMembers.Location = new System.Drawing.Point(234, 296);
            this.btnShowMembers.Name = "btnShowMembers";
            this.btnShowMembers.Size = new System.Drawing.Size(106, 63);
            this.btnShowMembers.TabIndex = 0;
            this.btnShowMembers.Text = "Show Members";
            this.btnShowMembers.UseVisualStyleBackColor = true;
            this.btnShowMembers.Click += new System.EventHandler(this.btnShowMembers_Click);
            // 
            // btnRaports
            // 
            this.btnRaports.Location = new System.Drawing.Point(234, 60);
            this.btnRaports.Name = "btnRaports";
            this.btnRaports.Size = new System.Drawing.Size(106, 63);
            this.btnRaports.TabIndex = 1;
            this.btnRaports.Text = "Show Raports";
            this.btnRaports.UseVisualStyleBackColor = true;
            this.btnRaports.Click += new System.EventHandler(this.btnRaports_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(478, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(575, 497);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRaports);
            this.Controls.Add(this.btnShowMembers);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMembers;
        private System.Windows.Forms.Button btnRaports;
        private System.Windows.Forms.Button btnBack;
    }
}
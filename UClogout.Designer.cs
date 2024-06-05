namespace LaundryManagementSystem
{
    partial class UClogout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UClogout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoLogoutButton = new System.Windows.Forms.Button();
            this.YesLogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.NoLogoutButton);
            this.panel1.Controls.Add(this.YesLogoutButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(221, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 175);
            this.panel1.TabIndex = 1;
            // 
            // NoLogoutButton
            // 
            this.NoLogoutButton.BackColor = System.Drawing.Color.White;
            this.NoLogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoLogoutButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLogoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NoLogoutButton.Location = new System.Drawing.Point(151, 107);
            this.NoLogoutButton.Name = "NoLogoutButton";
            this.NoLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.NoLogoutButton.TabIndex = 2;
            this.NoLogoutButton.Text = "No";
            this.NoLogoutButton.UseVisualStyleBackColor = false;
            // 
            // YesLogoutButton
            // 
            this.YesLogoutButton.BackColor = System.Drawing.Color.White;
            this.YesLogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesLogoutButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesLogoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YesLogoutButton.Location = new System.Drawing.Point(34, 107);
            this.YesLogoutButton.Name = "YesLogoutButton";
            this.YesLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.YesLogoutButton.TabIndex = 1;
            this.YesLogoutButton.Text = "Yes";
            this.YesLogoutButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to log out?";
            // 
            // UClogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "UClogout";
            this.Size = new System.Drawing.Size(735, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NoLogoutButton;
        private System.Windows.Forms.Button YesLogoutButton;
        private System.Windows.Forms.Label label1;
    }
}

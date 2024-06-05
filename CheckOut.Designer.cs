namespace LaundryManagementSystem
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.machineIconHome = new System.Windows.Forms.PictureBox();
            this.PanelCategories = new System.Windows.Forms.Panel();
            this.ButtonPayment = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CashButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.machineIconHome)).BeginInit();
            this.PanelCategories.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // machineIconHome
            // 
            this.machineIconHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machineIconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.machineIconHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("machineIconHome.BackgroundImage")));
            this.machineIconHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.machineIconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.machineIconHome.Location = new System.Drawing.Point(11, 11);
            this.machineIconHome.Name = "machineIconHome";
            this.machineIconHome.Size = new System.Drawing.Size(50, 51);
            this.machineIconHome.TabIndex = 12;
            this.machineIconHome.TabStop = false;
            this.machineIconHome.Click += new System.EventHandler(this.machineIconHome_Click);
            // 
            // PanelCategories
            // 
            this.PanelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelCategories.Controls.Add(this.ButtonPayment);
            this.PanelCategories.Controls.Add(this.machineIconHome);
            this.PanelCategories.Controls.Add(this.LogOutButton);
            this.PanelCategories.Controls.Add(this.AdminButton);
            this.PanelCategories.Controls.Add(this.SettingsButton);
            this.PanelCategories.Controls.Add(this.ClientButton);
            this.PanelCategories.Controls.Add(this.CartButton);
            this.PanelCategories.ForeColor = System.Drawing.Color.White;
            this.PanelCategories.Location = new System.Drawing.Point(0, 0);
            this.PanelCategories.Name = "PanelCategories";
            this.PanelCategories.Size = new System.Drawing.Size(74, 458);
            this.PanelCategories.TabIndex = 9;
            // 
            // ButtonPayment
            // 
            this.ButtonPayment.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPayment.BackgroundImage")));
            this.ButtonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPayment.ForeColor = System.Drawing.Color.Gray;
            this.ButtonPayment.Location = new System.Drawing.Point(23, 201);
            this.ButtonPayment.Name = "ButtonPayment";
            this.ButtonPayment.Size = new System.Drawing.Size(25, 25);
            this.ButtonPayment.TabIndex = 13;
            this.ButtonPayment.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Turquoise;
            this.LogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.BackgroundImage")));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOutButton.Location = new System.Drawing.Point(23, 381);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(29, 26);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Turquoise;
            this.AdminButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_male_user_50__2_;
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AdminButton.Location = new System.Drawing.Point(23, 316);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(29, 29);
            this.AdminButton.TabIndex = 5;
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Turquoise;
            this.SettingsButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_settings_48__1_;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.Gray;
            this.SettingsButton.Location = new System.Drawing.Point(23, 250);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(25, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.Turquoise;
            this.ClientButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_admin_settings_male_64__1_;
            this.ClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientButton.ForeColor = System.Drawing.Color.White;
            this.ClientButton.Location = new System.Drawing.Point(23, 97);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(26, 26);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.UseVisualStyleBackColor = false;
            // 
            // CartButton
            // 
            this.CartButton.BackColor = System.Drawing.Color.Turquoise;
            this.CartButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_fast_cart_48__1_;
            this.CartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButton.ForeColor = System.Drawing.Color.Cyan;
            this.CartButton.Location = new System.Drawing.Point(23, 154);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(26, 26);
            this.CartButton.TabIndex = 2;
            this.CartButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CashButton);
            this.panel1.Location = new System.Drawing.Point(80, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 458);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(282, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(487, 346);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 34);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Payment Methods:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(289, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 79);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CashButton.Location = new System.Drawing.Point(269, 131);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(127, 166);
            this.CashButton.TabIndex = 5;
            this.CashButton.UseVisualStyleBackColor = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCategories);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.machineIconHome)).EndInit();
            this.PanelCategories.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox machineIconHome;
        private System.Windows.Forms.Panel PanelCategories;
        private System.Windows.Forms.Button ButtonPayment;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
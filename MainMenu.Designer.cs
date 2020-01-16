namespace Session3
{
    partial class MainMenu
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
            this.menu_label = new System.Windows.Forms.Label();
            this.arrival_button = new System.Windows.Forms.Button();
            this.hotel_button = new System.Windows.Forms.Button();
            this.booking_or_guests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_label.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label.Location = new System.Drawing.Point(0, 0);
            this.menu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(132, 26);
            this.menu_label.TabIndex = 2;
            this.menu_label.Text = "Main Menu";
            // 
            // arrival_button
            // 
            this.arrival_button.Location = new System.Drawing.Point(176, 58);
            this.arrival_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrival_button.Name = "arrival_button";
            this.arrival_button.Size = new System.Drawing.Size(235, 68);
            this.arrival_button.TabIndex = 11;
            this.arrival_button.Text = "Create Account";
            this.arrival_button.UseVisualStyleBackColor = true;
            this.arrival_button.Click += new System.EventHandler(this.arrival_button_Click);
            // 
            // hotel_button
            // 
            this.hotel_button.Location = new System.Drawing.Point(176, 132);
            this.hotel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hotel_button.Name = "hotel_button";
            this.hotel_button.Size = new System.Drawing.Size(235, 68);
            this.hotel_button.TabIndex = 12;
            this.hotel_button.Text = "Create Account";
            this.hotel_button.UseVisualStyleBackColor = true;
            this.hotel_button.Click += new System.EventHandler(this.hotel_button_Click);
            // 
            // booking_or_guests
            // 
            this.booking_or_guests.Location = new System.Drawing.Point(176, 205);
            this.booking_or_guests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.booking_or_guests.Name = "booking_or_guests";
            this.booking_or_guests.Size = new System.Drawing.Size(235, 68);
            this.booking_or_guests.TabIndex = 13;
            this.booking_or_guests.Text = "Create Account";
            this.booking_or_guests.UseVisualStyleBackColor = true;
            this.booking_or_guests.Click += new System.EventHandler(this.booking_or_guests_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.booking_or_guests);
            this.Controls.Add(this.hotel_button);
            this.Controls.Add(this.arrival_button);
            this.Controls.Add(this.menu_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button arrival_button;
        private System.Windows.Forms.Button hotel_button;
        private System.Windows.Forms.Button booking_or_guests;
    }
}
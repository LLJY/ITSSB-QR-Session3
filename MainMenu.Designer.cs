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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label.Location = new System.Drawing.Point(297, 49);
            this.menu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(132, 26);
            this.menu_label.TabIndex = 2;
            this.menu_label.Text = "Main Menu";
            this.menu_label.Click += new System.EventHandler(this.Menu_label_Click);
            // 
            // arrival_button
            // 
            this.arrival_button.Location = new System.Drawing.Point(237, 131);
            this.arrival_button.Margin = new System.Windows.Forms.Padding(2);
            this.arrival_button.Name = "arrival_button";
            this.arrival_button.Size = new System.Drawing.Size(235, 68);
            this.arrival_button.TabIndex = 11;
            this.arrival_button.Text = "Create Account";
            this.arrival_button.UseVisualStyleBackColor = true;
            this.arrival_button.Click += new System.EventHandler(this.arrival_button_Click);
            // 
            // hotel_button
            // 
            this.hotel_button.Location = new System.Drawing.Point(237, 205);
            this.hotel_button.Margin = new System.Windows.Forms.Padding(2);
            this.hotel_button.Name = "hotel_button";
            this.hotel_button.Size = new System.Drawing.Size(235, 68);
            this.hotel_button.TabIndex = 12;
            this.hotel_button.Text = "Create Account";
            this.hotel_button.UseVisualStyleBackColor = true;
            this.hotel_button.Click += new System.EventHandler(this.hotel_button_Click);
            // 
            // booking_or_guests
            // 
            this.booking_or_guests.Location = new System.Drawing.Point(237, 278);
            this.booking_or_guests.Margin = new System.Windows.Forms.Padding(2);
            this.booking_or_guests.Name = "booking_or_guests";
            this.booking_or_guests.Size = new System.Drawing.Size(235, 68);
            this.booking_or_guests.TabIndex = 13;
            this.booking_or_guests.Text = "Create Account";
            this.booking_or_guests.UseVisualStyleBackColor = true;
            this.booking_or_guests.Click += new System.EventHandler(this.booking_or_guests_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.date_label);
            this.panel2.Location = new System.Drawing.Point(-7, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 48);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 45);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(511, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "ASEAN Skills 2020";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 10);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.White;
            this.date_label.Location = new System.Drawing.Point(542, 11);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(46, 16);
            this.date_label.TabIndex = 25;
            this.date_label.Text = "label3";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.booking_or_guests);
            this.Controls.Add(this.hotel_button);
            this.Controls.Add(this.arrival_button);
            this.Controls.Add(this.menu_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button arrival_button;
        private System.Windows.Forms.Button hotel_button;
        private System.Windows.Forms.Button booking_or_guests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label date_label;
    }
}
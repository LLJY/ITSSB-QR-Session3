namespace Session3
{
    partial class HotelSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelSummary));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelname_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_pacific_button = new System.Windows.Forms.Button();
            this.ritz_button = new System.Windows.Forms.Button();
            this.intercontinental_button = new System.Windows.Forms.Button();
            this.grand_pacific_button = new System.Windows.Forms.Button();
            this.queens_hotel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hotel Summary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 45);
            this.panel1.TabIndex = 18;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 10);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 174);
            this.dataGridView1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hotel Name:";
            // 
            // hotelname_label
            // 
            this.hotelname_label.AutoSize = true;
            this.hotelname_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelname_label.Location = new System.Drawing.Point(508, 90);
            this.hotelname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hotelname_label.Name = "hotelname_label";
            this.hotelname_label.Size = new System.Drawing.Size(112, 18);
            this.hotelname_label.TabIndex = 23;
            this.hotelname_label.Text = "Hotel Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(67, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 12);
            this.button1.TabIndex = 24;
            this.button1.Text = "carlton_click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pan_pacific_button
            // 
            this.pan_pacific_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_pacific_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_pacific_button.Location = new System.Drawing.Point(215, 254);
            this.pan_pacific_button.Name = "pan_pacific_button";
            this.pan_pacific_button.Size = new System.Drawing.Size(12, 12);
            this.pan_pacific_button.TabIndex = 25;
            this.pan_pacific_button.Text = "button2";
            this.pan_pacific_button.UseVisualStyleBackColor = false;
            this.pan_pacific_button.Click += new System.EventHandler(this.Pan_pacific_button_Click);
            // 
            // ritz_button
            // 
            this.ritz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ritz_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ritz_button.Location = new System.Drawing.Point(257, 291);
            this.ritz_button.Name = "ritz_button";
            this.ritz_button.Size = new System.Drawing.Size(12, 12);
            this.ritz_button.TabIndex = 26;
            this.ritz_button.Text = "button3";
            this.ritz_button.UseVisualStyleBackColor = false;
            this.ritz_button.Click += new System.EventHandler(this.Ritz_button_Click);
            // 
            // intercontinental_button
            // 
            this.intercontinental_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intercontinental_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intercontinental_button.Location = new System.Drawing.Point(118, 123);
            this.intercontinental_button.Name = "intercontinental_button";
            this.intercontinental_button.Size = new System.Drawing.Size(12, 12);
            this.intercontinental_button.TabIndex = 27;
            this.intercontinental_button.Text = "button4";
            this.intercontinental_button.UseVisualStyleBackColor = false;
            this.intercontinental_button.Click += new System.EventHandler(this.Intercontinental_button_Click);
            // 
            // grand_pacific_button
            // 
            this.grand_pacific_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grand_pacific_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grand_pacific_button.Location = new System.Drawing.Point(67, 138);
            this.grand_pacific_button.Name = "grand_pacific_button";
            this.grand_pacific_button.Size = new System.Drawing.Size(12, 12);
            this.grand_pacific_button.TabIndex = 28;
            this.grand_pacific_button.Text = "button5";
            this.grand_pacific_button.UseVisualStyleBackColor = false;
            this.grand_pacific_button.Click += new System.EventHandler(this.Grand_pacific_button_Click);
            // 
            // queens_hotel_button
            // 
            this.queens_hotel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.queens_hotel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queens_hotel_button.Location = new System.Drawing.Point(39, 123);
            this.queens_hotel_button.Name = "queens_hotel_button";
            this.queens_hotel_button.Size = new System.Drawing.Size(12, 12);
            this.queens_hotel_button.TabIndex = 29;
            this.queens_hotel_button.Text = "button6";
            this.queens_hotel_button.UseVisualStyleBackColor = false;
            this.queens_hotel_button.Click += new System.EventHandler(this.Queens_hotel_button_Click);
            // 
            // HotelSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queens_hotel_button);
            this.Controls.Add(this.grand_pacific_button);
            this.Controls.Add(this.intercontinental_button);
            this.Controls.Add(this.ritz_button);
            this.Controls.Add(this.pan_pacific_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hotelname_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "HotelSummary";
            this.Text = "HotelSummary";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hotelname_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pan_pacific_button;
        private System.Windows.Forms.Button ritz_button;
        private System.Windows.Forms.Button intercontinental_button;
        private System.Windows.Forms.Button grand_pacific_button;
        private System.Windows.Forms.Button queens_hotel_button;
    }
}
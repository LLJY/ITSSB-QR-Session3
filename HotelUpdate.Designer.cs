namespace Session3
{
    partial class HotelUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.done_button = new System.Windows.Forms.Button();
            this.valuelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.competitors_updown = new System.Windows.Forms.NumericUpDown();
            this.delegates_updown = new System.Windows.Forms.NumericUpDown();
            this.head_updown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitors_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegates_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 45);
            this.panel1.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 10);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "button1";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 45);
            this.panel2.TabIndex = 1;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(601, 373);
            this.done_button.Margin = new System.Windows.Forms.Padding(2);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(91, 30);
            this.done_button.TabIndex = 26;
            this.done_button.Text = "Update";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // valuelabel
            // 
            this.valuelabel.AutoSize = true;
            this.valuelabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuelabel.Location = new System.Drawing.Point(598, 354);
            this.valuelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuelabel.Name = "valuelabel";
            this.valuelabel.Size = new System.Drawing.Size(75, 14);
            this.valuelabel.TabIndex = 25;
            this.valuelabel.Text = "Total Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "TOTAL ($) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Competitors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Delegates(excluding head)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "No of Pax :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 189);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hotel Booking";
            // 
            // competitors_updown
            // 
            this.competitors_updown.Location = new System.Drawing.Point(221, 139);
            this.competitors_updown.Margin = new System.Windows.Forms.Padding(2);
            this.competitors_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.competitors_updown.Name = "competitors_updown";
            this.competitors_updown.Size = new System.Drawing.Size(90, 20);
            this.competitors_updown.TabIndex = 33;
            // 
            // delegates_updown
            // 
            this.delegates_updown.Location = new System.Drawing.Point(221, 116);
            this.delegates_updown.Margin = new System.Windows.Forms.Padding(2);
            this.delegates_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delegates_updown.Name = "delegates_updown";
            this.delegates_updown.Size = new System.Drawing.Size(90, 20);
            this.delegates_updown.TabIndex = 32;
            // 
            // head_updown
            // 
            this.head_updown.Location = new System.Drawing.Point(221, 90);
            this.head_updown.Margin = new System.Windows.Forms.Padding(2);
            this.head_updown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.head_updown.Name = "head_updown";
            this.head_updown.Size = new System.Drawing.Size(90, 20);
            this.head_updown.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Head of Delegation";
            // 
            // HotelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.competitors_updown);
            this.Controls.Add(this.delegates_updown);
            this.Controls.Add(this.head_updown);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.valuelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HotelUpdate";
            this.Text = "HotelUpdate";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitors_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegates_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label valuelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown competitors_updown;
        private System.Windows.Forms.NumericUpDown delegates_updown;
        private System.Windows.Forms.NumericUpDown head_updown;
        private System.Windows.Forms.Label label3;
    }
}
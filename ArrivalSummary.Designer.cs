namespace Session3
{
    partial class ArrivalSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.july22_dgv = new System.Windows.Forms.DataGridView();
            this.july23_dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.july22_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.july23_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Arrival Summary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 45);
            this.panel1.TabIndex = 16;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "22 July 2020";
            // 
            // july22_dgv
            // 
            this.july22_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.july22_dgv.Location = new System.Drawing.Point(12, 127);
            this.july22_dgv.Name = "july22_dgv";
            this.july22_dgv.Size = new System.Drawing.Size(776, 120);
            this.july22_dgv.TabIndex = 19;
            // 
            // july23_dgv
            // 
            this.july23_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.july23_dgv.Location = new System.Drawing.Point(12, 272);
            this.july23_dgv.Name = "july23_dgv";
            this.july23_dgv.Size = new System.Drawing.Size(776, 120);
            this.july23_dgv.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "23 July 2020";
            // 
            // ArrivalSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.july23_dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.july22_dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ArrivalSummary";
            this.Text = "ArrivalSummary";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.july22_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.july23_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView july22_dgv;
        private System.Windows.Forms.DataGridView july23_dgv;
        private System.Windows.Forms.Label label3;
    }
}
namespace Session3
{
    partial class CreateAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.country_combo = new System.Windows.Forms.ComboBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_again_box = new System.Windows.Forms.TextBox();
            this.create_account_box = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospitality Management Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Re-Enter Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID (For login) :";
            // 
            // country_combo
            // 
            this.country_combo.FormattingEnabled = true;
            this.country_combo.Location = new System.Drawing.Point(174, 82);
            this.country_combo.Name = "country_combo";
            this.country_combo.Size = new System.Drawing.Size(121, 24);
            this.country_combo.TabIndex = 6;
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(174, 114);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(252, 22);
            this.user_box.TabIndex = 7;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(173, 153);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(252, 22);
            this.password_box.TabIndex = 8;
            // 
            // password_again_box
            // 
            this.password_again_box.Location = new System.Drawing.Point(173, 187);
            this.password_again_box.Name = "password_again_box";
            this.password_again_box.Size = new System.Drawing.Size(252, 22);
            this.password_again_box.TabIndex = 9;
            // 
            // create_account_box
            // 
            this.create_account_box.Location = new System.Drawing.Point(330, 275);
            this.create_account_box.Name = "create_account_box";
            this.create_account_box.Size = new System.Drawing.Size(159, 57);
            this.create_account_box.TabIndex = 10;
            this.create_account_box.Text = "Create Account";
            this.create_account_box.UseVisualStyleBackColor = true;
            this.create_account_box.Click += new System.EventHandler(this.create_account_box_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.create_account_box);
            this.Controls.Add(this.password_again_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.country_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox country_combo;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox password_again_box;
        private System.Windows.Forms.Button create_account_box;
        private System.Windows.Forms.Button button2;
    }
}
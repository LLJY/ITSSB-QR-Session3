﻿namespace Session3
{
    partial class LoginForm
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
            this.user_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.create_acct_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitality Management Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID :";
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(127, 125);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(284, 22);
            this.user_box.TabIndex = 3;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(127, 195);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(284, 22);
            this.password_box.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(310, 241);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(136, 65);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // create_acct_button
            // 
            this.create_acct_button.Location = new System.Drawing.Point(271, 312);
            this.create_acct_button.Name = "create_acct_button";
            this.create_acct_button.Size = new System.Drawing.Size(221, 81);
            this.create_acct_button.TabIndex = 6;
            this.create_acct_button.Text = "Create New Country Representative";
            this.create_acct_button.UseVisualStyleBackColor = true;
            this.create_acct_button.Click += new System.EventHandler(this.create_acct_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_acct_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_acct_button;
    }
}

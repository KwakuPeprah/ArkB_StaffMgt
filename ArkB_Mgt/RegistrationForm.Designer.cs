namespace ArkB_Mgt
{
    partial class RegistrationForm
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
            this.Exit = new System.Windows.Forms.Label();
            this.btnSign_UP = new System.Windows.Forms.Button();
            this.cbShowPassword_SignUp = new System.Windows.Forms.CheckBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSign_IN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(702, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(15, 16);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSign_UP
            // 
            this.btnSign_UP.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSign_UP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign_UP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign_UP.ForeColor = System.Drawing.Color.White;
            this.btnSign_UP.Location = new System.Drawing.Point(330, 397);
            this.btnSign_UP.Name = "btnSign_UP";
            this.btnSign_UP.Size = new System.Drawing.Size(104, 51);
            this.btnSign_UP.TabIndex = 16;
            this.btnSign_UP.Text = "SIGNUP";
            this.btnSign_UP.UseVisualStyleBackColor = false;
            this.btnSign_UP.Click += new System.EventHandler(this.btnSign_UP_Click);
            // 
            // cbShowPassword_SignUp
            // 
            this.cbShowPassword_SignUp.AutoSize = true;
            this.cbShowPassword_SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPassword_SignUp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword_SignUp.Location = new System.Drawing.Point(587, 341);
            this.cbShowPassword_SignUp.Name = "cbShowPassword_SignUp";
            this.cbShowPassword_SignUp.Size = new System.Drawing.Size(130, 22);
            this.cbShowPassword_SignUp.TabIndex = 15;
            this.cbShowPassword_SignUp.Text = "Show Password";
            this.cbShowPassword_SignUp.UseVisualStyleBackColor = true;
            this.cbShowPassword_SignUp.CheckedChanged += new System.EventHandler(this.cbShowPassword_SignUp_CheckedChanged);
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(330, 305);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(387, 30);
            this.signup_password.TabIndex = 14;
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_TextChanged);
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(330, 205);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(387, 30);
            this.signup_username.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Register Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSign_IN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 537);
            this.panel1.TabIndex = 8;
            // 
            // btnSign_IN
            // 
            this.btnSign_IN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign_IN.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign_IN.Location = new System.Drawing.Point(39, 476);
            this.btnSign_IN.Name = "btnSign_IN";
            this.btnSign_IN.Size = new System.Drawing.Size(246, 47);
            this.btnSign_IN.TabIndex = 3;
            this.btnSign_IN.Text = "SIGN IN";
            this.btnSign_IN.UseVisualStyleBackColor = true;
            this.btnSign_IN.Click += new System.EventHandler(this.btnSign_IN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login Your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARK B NATURALS";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 537);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSign_UP);
            this.Controls.Add(this.cbShowPassword_SignUp);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button btnSign_UP;
        private System.Windows.Forms.CheckBox cbShowPassword_SignUp;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSign_IN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace ArkB_Mgt
{
    partial class AddStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboStatus_AddStaff = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear_AddStaff = new System.Windows.Forms.Button();
            this.btnDelete_AddStaff = new System.Windows.Forms.Button();
            this.btnUpdate_AddStaff = new System.Windows.Forms.Button();
            this.btnAdd_AddStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboGender_AddStaff = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddStaffPicture = new System.Windows.Forms.PictureBox();
            this.txtPhone_AddStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPosition_AddStaff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName_AddStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID_AddStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStaffPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 267);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboStatus_AddStaff);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnClear_AddStaff);
            this.panel2.Controls.Add(this.btnDelete_AddStaff);
            this.panel2.Controls.Add(this.btnUpdate_AddStaff);
            this.panel2.Controls.Add(this.btnAdd_AddStaff);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cboGender_AddStaff);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.AddStaffPicture);
            this.panel2.Controls.Add(this.txtPhone_AddStaff);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboPosition_AddStaff);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFullName_AddStaff);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmpID_AddStaff);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 261);
            this.panel2.TabIndex = 1;
            // 
            // cboStatus_AddStaff
            // 
            this.cboStatus_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus_AddStaff.FormattingEnabled = true;
            this.cboStatus_AddStaff.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus_AddStaff.Location = new System.Drawing.Point(450, 112);
            this.cboStatus_AddStaff.Name = "cboStatus_AddStaff";
            this.cboStatus_AddStaff.Size = new System.Drawing.Size(157, 26);
            this.cboStatus_AddStaff.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status";
            // 
            // btnClear_AddStaff
            // 
            this.btnClear_AddStaff.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear_AddStaff.FlatAppearance.BorderSize = 0;
            this.btnClear_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_AddStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_AddStaff.ForeColor = System.Drawing.Color.White;
            this.btnClear_AddStaff.Location = new System.Drawing.Point(560, 177);
            this.btnClear_AddStaff.Name = "btnClear_AddStaff";
            this.btnClear_AddStaff.Size = new System.Drawing.Size(113, 52);
            this.btnClear_AddStaff.TabIndex = 15;
            this.btnClear_AddStaff.Text = "Clear";
            this.btnClear_AddStaff.UseVisualStyleBackColor = false;
            this.btnClear_AddStaff.Click += new System.EventHandler(this.btnClear_AddStaff_Click);
            // 
            // btnDelete_AddStaff
            // 
            this.btnDelete_AddStaff.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete_AddStaff.FlatAppearance.BorderSize = 0;
            this.btnDelete_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_AddStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_AddStaff.ForeColor = System.Drawing.Color.White;
            this.btnDelete_AddStaff.Location = new System.Drawing.Point(423, 177);
            this.btnDelete_AddStaff.Name = "btnDelete_AddStaff";
            this.btnDelete_AddStaff.Size = new System.Drawing.Size(113, 52);
            this.btnDelete_AddStaff.TabIndex = 14;
            this.btnDelete_AddStaff.Text = "Delete";
            this.btnDelete_AddStaff.UseVisualStyleBackColor = false;
            this.btnDelete_AddStaff.Click += new System.EventHandler(this.btnDelete_AddStaff_Click);
            // 
            // btnUpdate_AddStaff
            // 
            this.btnUpdate_AddStaff.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate_AddStaff.FlatAppearance.BorderSize = 0;
            this.btnUpdate_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_AddStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_AddStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_AddStaff.Location = new System.Drawing.Point(289, 177);
            this.btnUpdate_AddStaff.Name = "btnUpdate_AddStaff";
            this.btnUpdate_AddStaff.Size = new System.Drawing.Size(113, 52);
            this.btnUpdate_AddStaff.TabIndex = 13;
            this.btnUpdate_AddStaff.Text = "Update";
            this.btnUpdate_AddStaff.UseVisualStyleBackColor = false;
            this.btnUpdate_AddStaff.Click += new System.EventHandler(this.btnUpdate_AddStaff_Click);
            // 
            // btnAdd_AddStaff
            // 
            this.btnAdd_AddStaff.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd_AddStaff.FlatAppearance.BorderSize = 0;
            this.btnAdd_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_AddStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_AddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAdd_AddStaff.Location = new System.Drawing.Point(152, 177);
            this.btnAdd_AddStaff.Name = "btnAdd_AddStaff";
            this.btnAdd_AddStaff.Size = new System.Drawing.Size(113, 52);
            this.btnAdd_AddStaff.TabIndex = 12;
            this.btnAdd_AddStaff.Text = "Add";
            this.btnAdd_AddStaff.UseVisualStyleBackColor = false;
            this.btnAdd_AddStaff.Click += new System.EventHandler(this.btnAdd_AddStaff_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(704, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboGender_AddStaff
            // 
            this.cboGender_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender_AddStaff.FormattingEnabled = true;
            this.cboGender_AddStaff.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender_AddStaff.Location = new System.Drawing.Point(108, 125);
            this.cboGender_AddStaff.Name = "cboGender_AddStaff";
            this.cboGender_AddStaff.Size = new System.Drawing.Size(204, 26);
            this.cboGender_AddStaff.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender";
            // 
            // AddStaffPicture
            // 
            this.AddStaffPicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddStaffPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddStaffPicture.Location = new System.Drawing.Point(704, 17);
            this.AddStaffPicture.Name = "AddStaffPicture";
            this.AddStaffPicture.Size = new System.Drawing.Size(100, 101);
            this.AddStaffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddStaffPicture.TabIndex = 8;
            this.AddStaffPicture.TabStop = false;
            // 
            // txtPhone_AddStaff
            // 
            this.txtPhone_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone_AddStaff.Location = new System.Drawing.Point(450, 44);
            this.txtPhone_AddStaff.Name = "txtPhone_AddStaff";
            this.txtPhone_AddStaff.Size = new System.Drawing.Size(157, 24);
            this.txtPhone_AddStaff.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number";
            // 
            // cboPosition_AddStaff
            // 
            this.cboPosition_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition_AddStaff.FormattingEnabled = true;
            this.cboPosition_AddStaff.Items.AddRange(new object[] {
            "Business Management Executive",
            "Sales and Marketting",
            "Sofware Development Team",
            "Operations",
            "Production",
            "Packaging",
            "Transport",
            "Logistics",
            ""});
            this.cboPosition_AddStaff.Location = new System.Drawing.Point(450, 80);
            this.cboPosition_AddStaff.Name = "cboPosition_AddStaff";
            this.cboPosition_AddStaff.Size = new System.Drawing.Size(157, 26);
            this.cboPosition_AddStaff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position";
            // 
            // txtFullName_AddStaff
            // 
            this.txtFullName_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName_AddStaff.Location = new System.Drawing.Point(108, 82);
            this.txtFullName_AddStaff.Name = "txtFullName_AddStaff";
            this.txtFullName_AddStaff.Size = new System.Drawing.Size(214, 24);
            this.txtFullName_AddStaff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // txtEmpID_AddStaff
            // 
            this.txtEmpID_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID_AddStaff.Location = new System.Drawing.Point(108, 44);
            this.txtEmpID_AddStaff.Name = "txtEmpID_AddStaff";
            this.txtEmpID_AddStaff.Size = new System.Drawing.Size(157, 24);
            this.txtEmpID_AddStaff.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employe ID";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStaff";
            this.Size = new System.Drawing.Size(875, 618);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStaffPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmpID_AddStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPosition_AddStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName_AddStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate_AddStaff;
        private System.Windows.Forms.Button btnAdd_AddStaff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboGender_AddStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox AddStaffPicture;
        private System.Windows.Forms.TextBox txtPhone_AddStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear_AddStaff;
        private System.Windows.Forms.Button btnDelete_AddStaff;
        private System.Windows.Forms.ComboBox cboStatus_AddStaff;
        private System.Windows.Forms.Label label7;
    }
}

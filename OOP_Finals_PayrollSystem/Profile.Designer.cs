namespace OOP_Finals_PayrollSystem
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProMidInit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProSname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProContactNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpProBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbProGender = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbProGender);
            this.panel1.Controls.Add(this.dtpProBirth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProMidInit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProSname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProFname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(28, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 241);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "GENDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "BIRTHDATE";
            // 
            // txtProMidInit
            // 
            this.txtProMidInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProMidInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProMidInit.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProMidInit.Location = new System.Drawing.Point(616, 89);
            this.txtProMidInit.Name = "txtProMidInit";
            this.txtProMidInit.ReadOnly = true;
            this.txtProMidInit.Size = new System.Drawing.Size(271, 37);
            this.txtProMidInit.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "MIDDLE INITIAL";
            // 
            // txtProSname
            // 
            this.txtProSname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProSname.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProSname.Location = new System.Drawing.Point(322, 89);
            this.txtProSname.Name = "txtProSname";
            this.txtProSname.ReadOnly = true;
            this.txtProSname.Size = new System.Drawing.Size(271, 37);
            this.txtProSname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SURNAME";
            // 
            // txtProFname
            // 
            this.txtProFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProFname.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProFname.Location = new System.Drawing.Point(26, 89);
            this.txtProFname.Name = "txtProFname";
            this.txtProFname.ReadOnly = true;
            this.txtProFname.Size = new System.Drawing.Size(271, 37);
            this.txtProFname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIRST NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DM Sans 14pt SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "PERSONAL INFORMATION";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("DM Sans 14pt SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.lblUser.Location = new System.Drawing.Point(135, 45);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 39);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "label1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("DM Sans 14pt SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.lblPosition.Location = new System.Drawing.Point(137, 84);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(66, 26);
            this.lblPosition.TabIndex = 20;
            this.lblPosition.Text = "label1";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(28, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(101, 97);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtProAddress);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtProEmail);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtProContactNo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(28, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 154);
            this.panel2.TabIndex = 21;
            // 
            // txtProAddress
            // 
            this.txtProAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProAddress.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProAddress.Location = new System.Drawing.Point(616, 89);
            this.txtProAddress.Name = "txtProAddress";
            this.txtProAddress.ReadOnly = true;
            this.txtProAddress.Size = new System.Drawing.Size(271, 37);
            this.txtProAddress.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(613, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "HOME ADDRESS";
            // 
            // txtProEmail
            // 
            this.txtProEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProEmail.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProEmail.Location = new System.Drawing.Point(322, 89);
            this.txtProEmail.Name = "txtProEmail";
            this.txtProEmail.ReadOnly = true;
            this.txtProEmail.Size = new System.Drawing.Size(271, 37);
            this.txtProEmail.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(319, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "EMAIL";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtProContactNo
            // 
            this.txtProContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProContactNo.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProContactNo.Location = new System.Drawing.Point(26, 89);
            this.txtProContactNo.Name = "txtProContactNo";
            this.txtProContactNo.ReadOnly = true;
            this.txtProContactNo.Size = new System.Drawing.Size(271, 37);
            this.txtProContactNo.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "CONTACT NO.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("DM Sans 14pt SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "CONTACT DETAILS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtProPass);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtProUserID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(28, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 158);
            this.panel3.TabIndex = 22;
            // 
            // txtProPass
            // 
            this.txtProPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProPass.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPass.Location = new System.Drawing.Point(322, 89);
            this.txtProPass.Name = "txtProPass";
            this.txtProPass.ReadOnly = true;
            this.txtProPass.Size = new System.Drawing.Size(271, 37);
            this.txtProPass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "PASSWORD";
            // 
            // txtProUserID
            // 
            this.txtProUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.txtProUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProUserID.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProUserID.Location = new System.Drawing.Point(26, 89);
            this.txtProUserID.Name = "txtProUserID";
            this.txtProUserID.ReadOnly = true;
            this.txtProUserID.Size = new System.Drawing.Size(271, 37);
            this.txtProUserID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DM Sans 14pt Medium", 7.799999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "USER ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DM Sans 14pt SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "LOGIN CREDENTIALS";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(173)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("DM Sans 14pt", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.btnEditProfile.Location = new System.Drawing.Point(805, 31);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(140, 46);
            this.btnEditProfile.TabIndex = 28;
            this.btnEditProfile.Text = "EDIT PROFILE";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("DM Sans 14pt", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.btnClose.Location = new System.Drawing.Point(820, 715);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpProBirth
            // 
            this.dtpProBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.dtpProBirth.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProBirth.Location = new System.Drawing.Point(26, 177);
            this.dtpProBirth.Name = "dtpProBirth";
            this.dtpProBirth.Size = new System.Drawing.Size(271, 37);
            this.dtpProBirth.TabIndex = 20;
            this.dtpProBirth.ValueChanged += new System.EventHandler(this.dtpProBirth_ValueChanged);
            // 
            // cmbProGender
            // 
            this.cmbProGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.cmbProGender.Font = new System.Drawing.Font("DM Sans 14pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProGender.FormattingEnabled = true;
            this.cmbProGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbProGender.Location = new System.Drawing.Point(322, 176);
            this.cmbProGender.Name = "cmbProGender";
            this.cmbProGender.Size = new System.Drawing.Size(271, 38);
            this.cmbProGender.TabIndex = 21;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(968, 766);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProSname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProMidInit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProContactNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpProBirth;
        private System.Windows.Forms.ComboBox cmbProGender;
    }
}
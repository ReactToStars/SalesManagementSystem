namespace SaleManagementWinApp
{
	partial class frmProfile
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
			label1 = new Label();
			btnSubmit = new Button();
			txtEmail = new TextBox();
			txtName = new TextBox();
			label2 = new Label();
			txtCity = new TextBox();
			label3 = new Label();
			txtCountry = new TextBox();
			label4 = new Label();
			label5 = new Label();
			btnChangePassword = new Button();
			btnBack = new Button();
			dtBirthday = new DateTimePicker();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(33, 55);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 0;
			label1.Text = "Email";
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Location = new Point(33, 355);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(94, 29);
			btnSubmit.TabIndex = 1;
			btnSubmit.Text = "Save";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(138, 52);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(271, 27);
			txtEmail.TabIndex = 2;
			// 
			// txtName
			// 
			txtName.Location = new Point(138, 107);
			txtName.Name = "txtName";
			txtName.Size = new Size(271, 27);
			txtName.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 110);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 3;
			label2.Text = "Full name";
			// 
			// txtCity
			// 
			txtCity.Location = new Point(138, 165);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(271, 27);
			txtCity.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(33, 168);
			label3.Name = "label3";
			label3.Size = new Size(34, 20);
			label3.TabIndex = 5;
			label3.Text = "City";
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(138, 222);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(271, 27);
			txtCountry.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(33, 225);
			label4.Name = "label4";
			label4.Size = new Size(60, 20);
			label4.TabIndex = 7;
			label4.Text = "Country";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(33, 285);
			label5.Name = "label5";
			label5.Size = new Size(64, 20);
			label5.TabIndex = 9;
			label5.Text = "Birthday";
			// 
			// btnChangePassword
			// 
			btnChangePassword.BackColor = Color.OrangeRed;
			btnChangePassword.Location = new Point(150, 355);
			btnChangePassword.Name = "btnChangePassword";
			btnChangePassword.Size = new Size(147, 29);
			btnChangePassword.TabIndex = 11;
			btnChangePassword.Text = "Change password";
			btnChangePassword.UseVisualStyleBackColor = false;
			btnChangePassword.Click += btnChangePassword_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.DarkGray;
			btnBack.Location = new Point(315, 355);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 12;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// dtBirthday
			// 
			dtBirthday.Format = DateTimePickerFormat.Short;
			dtBirthday.Location = new Point(141, 286);
			dtBirthday.Name = "dtBirthday";
			dtBirthday.Size = new Size(268, 27);
			dtBirthday.TabIndex = 13;
			// 
			// frmProfile
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(455, 435);
			Controls.Add(dtBirthday);
			Controls.Add(btnBack);
			Controls.Add(btnChangePassword);
			Controls.Add(label5);
			Controls.Add(txtCountry);
			Controls.Add(label4);
			Controls.Add(txtCity);
			Controls.Add(label3);
			Controls.Add(txtName);
			Controls.Add(label2);
			Controls.Add(txtEmail);
			Controls.Add(btnSubmit);
			Controls.Add(label1);
			Name = "frmProfile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProfile";
			Load += frmProfile_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnSubmit;
		private TextBox txtEmail;
		private TextBox txtName;
		private Label label2;
		private TextBox txtCity;
		private Label label3;
		private TextBox txtCountry;
		private Label label4;
		private Label label5;
		private Button btnChangePassword;
		private Button btnBack;
		private DateTimePicker dtBirthday;
	}
}
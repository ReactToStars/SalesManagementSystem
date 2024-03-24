namespace SaleManagementWinApp
{
	partial class frmLogin
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
			lblEmail = new Label();
			txtEmail = new TextBox();
			txtPassword = new TextBox();
			lblPassword = new Label();
			btnLogin = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(57, 176);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(46, 20);
			lblEmail.TabIndex = 0;
			lblEmail.Text = "Email";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(57, 212);
			txtEmail.Margin = new Padding(3, 4, 3, 4);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(267, 27);
			txtEmail.TabIndex = 1;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(57, 303);
			txtPassword.Margin = new Padding(3, 4, 3, 4);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(267, 27);
			txtPassword.TabIndex = 3;
			txtPassword.TextChanged += txtPassword_TextChanged;
			txtPassword.Enter += txtPassword_Enter;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(57, 268);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(70, 20);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Password";
			// 
			// btnLogin
			// 
			btnLogin.BackColor = SystemColors.Highlight;
			btnLogin.Location = new Point(101, 354);
			btnLogin.Margin = new Padding(3, 4, 3, 4);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(86, 31);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.IndianRed;
			btnCancel.Location = new Point(193, 354);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(86, 31);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(417, 600);
			Controls.Add(btnCancel);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(lblPassword);
			Controls.Add(txtEmail);
			Controls.Add(lblEmail);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmLogin";
			Load += frmLogin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblEmail;
		private TextBox txtEmail;
		private TextBox txtPassword;
		private Label lblPassword;
		private Button btnLogin;
		private Button btnCancel;
	}
}
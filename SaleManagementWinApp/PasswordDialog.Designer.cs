namespace SaleManagementWinApp
{
	partial class PasswordDialog
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
			txtPassword = new TextBox();
			txtNewPassword = new TextBox();
			label2 = new Label();
			txtVerifyPassword = new TextBox();
			label3 = new Label();
			btnSubmit = new Button();
			btnCancel = new Button();
			lblNotify = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 125);
			label1.Name = "label1";
			label1.Size = new Size(124, 20);
			label1.TabIndex = 0;
			label1.Text = "Current password";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(183, 122);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(271, 27);
			txtPassword.TabIndex = 1;
			txtPassword.Enter += txtPassword_Enter;
			// 
			// txtNewPassword
			// 
			txtNewPassword.Location = new Point(183, 182);
			txtNewPassword.Name = "txtNewPassword";
			txtNewPassword.Size = new Size(271, 27);
			txtNewPassword.TabIndex = 3;
			txtNewPassword.Enter += txtNewPassword_Enter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 185);
			label2.Name = "label2";
			label2.Size = new Size(106, 20);
			label2.TabIndex = 2;
			label2.Text = "New password";
			// 
			// txtVerifyPassword
			// 
			txtVerifyPassword.Location = new Point(183, 242);
			txtVerifyPassword.Name = "txtVerifyPassword";
			txtVerifyPassword.Size = new Size(271, 27);
			txtVerifyPassword.TabIndex = 5;
			txtVerifyPassword.Enter += txtVerifyPassword_Enter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 245);
			label3.Name = "label3";
			label3.Size = new Size(113, 20);
			label3.TabIndex = 4;
			label3.Text = "Verify password";
			// 
			// btnSubmit
			// 
			btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Location = new Point(122, 309);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(94, 29);
			btnSubmit.TabIndex = 6;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnCancel
			// 
			btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnCancel.BackColor = Color.IndianRed;
			btnCancel.Location = new Point(265, 309);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// lblNotify
			// 
			lblNotify.AutoSize = true;
			lblNotify.BackColor = Color.Salmon;
			lblNotify.Location = new Point(21, 74);
			lblNotify.Name = "lblNotify";
			lblNotify.Size = new Size(50, 20);
			lblNotify.TabIndex = 8;
			lblNotify.Text = "Notify";
			// 
			// PasswordDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(499, 371);
			Controls.Add(lblNotify);
			Controls.Add(btnCancel);
			Controls.Add(btnSubmit);
			Controls.Add(txtVerifyPassword);
			Controls.Add(label3);
			Controls.Add(txtNewPassword);
			Controls.Add(label2);
			Controls.Add(txtPassword);
			Controls.Add(label1);
			Name = "PasswordDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PasswordDialog";
			Load += PasswordDialog_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtPassword;
		private TextBox txtNewPassword;
		private Label label2;
		private TextBox txtVerifyPassword;
		private Label label3;
		private Button btnSubmit;
		private Button btnCancel;
		private Label lblNotify;
	}
}
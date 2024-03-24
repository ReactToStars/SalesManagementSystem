namespace SaleManagementWinApp
{
	partial class CustomerDialog
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
			panel1 = new Panel();
			txtCountry = new TextBox();
			cbxStatus = new ComboBox();
			txtName = new TextBox();
			txtEmail = new TextBox();
			label7 = new Label();
			label8 = new Label();
			txtCity = new TextBox();
			dtBirthday = new DateTimePicker();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			txtId = new TextBox();
			label1 = new Label();
			btnSubmit = new Button();
			btnRefresh = new Button();
			btnCancel = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(txtCountry);
			panel1.Controls.Add(cbxStatus);
			panel1.Controls.Add(txtName);
			panel1.Controls.Add(txtEmail);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(txtCity);
			panel1.Controls.Add(dtBirthday);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtId);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(14, 41);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(383, 465);
			panel1.TabIndex = 13;
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(99, 287);
			txtCountry.Margin = new Padding(3, 4, 3, 4);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(255, 27);
			txtCountry.TabIndex = 5;
			// 
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Location = new Point(101, 408);
			cbxStatus.Margin = new Padding(3, 4, 3, 4);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(255, 28);
			cbxStatus.TabIndex = 8;
			// 
			// txtName
			// 
			txtName.Location = new Point(99, 161);
			txtName.Margin = new Padding(3, 4, 3, 4);
			txtName.Name = "txtName";
			txtName.Size = new Size(255, 27);
			txtName.TabIndex = 3;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(102, 92);
			txtEmail.Margin = new Padding(3, 4, 3, 4);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(255, 27);
			txtEmail.TabIndex = 2;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(14, 412);
			label7.Name = "label7";
			label7.Size = new Size(49, 20);
			label7.TabIndex = 21;
			label7.Text = "Status";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(14, 353);
			label8.Name = "label8";
			label8.Size = new Size(64, 20);
			label8.TabIndex = 20;
			label8.Text = "Birthday";
			// 
			// txtCity
			// 
			txtCity.Location = new Point(101, 224);
			txtCity.Margin = new Padding(3, 4, 3, 4);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(255, 27);
			txtCity.TabIndex = 4;
			// 
			// dtBirthday
			// 
			dtBirthday.CustomFormat = "dd/MM/yyyy";
			dtBirthday.Format = DateTimePickerFormat.Custom;
			dtBirthday.Location = new Point(99, 352);
			dtBirthday.Margin = new Padding(3, 4, 3, 4);
			dtBirthday.Name = "dtBirthday";
			dtBirthday.Size = new Size(257, 27);
			dtBirthday.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(13, 291);
			label5.Name = "label5";
			label5.Size = new Size(60, 20);
			label5.TabIndex = 12;
			label5.Text = "Country";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 228);
			label4.Name = "label4";
			label4.Size = new Size(34, 20);
			label4.TabIndex = 10;
			label4.Text = "City";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(13, 165);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 8;
			label3.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 96);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 6;
			label2.Text = "Email";
			// 
			// txtId
			// 
			txtId.Location = new Point(102, 21);
			txtId.Margin = new Padding(3, 4, 3, 4);
			txtId.Name = "txtId";
			txtId.Size = new Size(255, 27);
			txtId.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 25);
			label1.Name = "label1";
			label1.Size = new Size(22, 20);
			label1.TabIndex = 0;
			label1.Text = "Id";
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Location = new Point(43, 532);
			btnSubmit.Margin = new Padding(3, 4, 3, 4);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(86, 31);
			btnSubmit.TabIndex = 14;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.BackColor = Color.DarkGray;
			btnRefresh.Location = new Point(146, 532);
			btnRefresh.Margin = new Padding(3, 4, 3, 4);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(86, 31);
			btnRefresh.TabIndex = 15;
			btnRefresh.Text = "Reset";
			btnRefresh.UseVisualStyleBackColor = false;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.IndianRed;
			btnCancel.Location = new Point(249, 532);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(86, 31);
			btnCancel.TabIndex = 16;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// CustomerDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(413, 607);
			Controls.Add(btnCancel);
			Controls.Add(btnRefresh);
			Controls.Add(btnSubmit);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "CustomerDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CustomerDialog";
			Load += CustomerDialog_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TextBox txtCountry;
		private ComboBox cbxStatus;
		private TextBox txtName;
		private TextBox txtEmail;
		private Label label7;
		private Label label8;
		private TextBox txtCity;
		private DateTimePicker dtBirthday;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox txtId;
		private Label label1;
		private Button btnSubmit;
		private Button btnRefresh;
		private Button btnCancel;
	}
}
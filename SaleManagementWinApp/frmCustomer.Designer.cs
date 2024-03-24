namespace SaleManagementWinApp
{
	partial class frmCustomer
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
			dataGridView1 = new DataGridView();
			btnSearch = new Button();
			txtSearch = new TextBox();
			btnBack = new Button();
			panel2 = new Panel();
			btnRefresh = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
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
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 407);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1077, 337);
			dataGridView1.TabIndex = 17;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(769, 16);
			btnSearch.Margin = new Padding(3, 4, 3, 4);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(86, 31);
			btnSearch.TabIndex = 16;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(514, 16);
			txtSearch.Margin = new Padding(3, 4, 3, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(231, 27);
			txtSearch.TabIndex = 15;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(951, 4);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(86, 31);
			btnBack.TabIndex = 14;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ControlLight;
			panel2.Controls.Add(btnRefresh);
			panel2.Controls.Add(btnDelete);
			panel2.Controls.Add(btnEdit);
			panel2.Controls.Add(btnAdd);
			panel2.Location = new Point(886, 55);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(151, 264);
			panel2.TabIndex = 13;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(35, 200);
			btnRefresh.Margin = new Padding(3, 4, 3, 4);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(86, 31);
			btnRefresh.TabIndex = 3;
			btnRefresh.Text = "Reset";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(35, 143);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(86, 31);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(35, 85);
			btnEdit.Margin = new Padding(3, 4, 3, 4);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(86, 31);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(35, 32);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(86, 31);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
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
			panel1.Location = new Point(14, 16);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(447, 361);
			panel1.TabIndex = 12;
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(160, 201);
			txtCountry.Margin = new Padding(3, 4, 3, 4);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(255, 27);
			txtCountry.TabIndex = 5;
			// 
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Location = new Point(159, 303);
			cbxStatus.Margin = new Padding(3, 4, 3, 4);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(255, 28);
			cbxStatus.TabIndex = 8;
			// 
			// txtName
			// 
			txtName.Location = new Point(160, 105);
			txtName.Margin = new Padding(3, 4, 3, 4);
			txtName.Name = "txtName";
			txtName.Size = new Size(255, 27);
			txtName.TabIndex = 3;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(160, 61);
			txtEmail.Margin = new Padding(3, 4, 3, 4);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(255, 27);
			txtEmail.TabIndex = 2;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(14, 313);
			label7.Name = "label7";
			label7.Size = new Size(49, 20);
			label7.TabIndex = 21;
			label7.Text = "Status";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(15, 265);
			label8.Name = "label8";
			label8.Size = new Size(64, 20);
			label8.TabIndex = 20;
			label8.Text = "Birthday";
			// 
			// txtCity
			// 
			txtCity.Location = new Point(160, 153);
			txtCity.Margin = new Padding(3, 4, 3, 4);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(255, 27);
			txtCity.TabIndex = 4;
			// 
			// dtBirthday
			// 
			dtBirthday.CustomFormat = "dd/MM/yyyy";
			dtBirthday.Format = DateTimePickerFormat.Custom;
			dtBirthday.Location = new Point(159, 257);
			dtBirthday.Margin = new Padding(3, 4, 3, 4);
			dtBirthday.Name = "dtBirthday";
			dtBirthday.Size = new Size(257, 27);
			dtBirthday.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(15, 212);
			label5.Name = "label5";
			label5.Size = new Size(60, 20);
			label5.TabIndex = 12;
			label5.Text = "Country";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 157);
			label4.Name = "label4";
			label4.Size = new Size(34, 20);
			label4.TabIndex = 10;
			label4.Text = "City";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 109);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 8;
			label3.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 65);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 6;
			label2.Text = "Email";
			// 
			// txtId
			// 
			txtId.Location = new Point(160, 15);
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
			// frmCustomer
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1077, 744);
			Controls.Add(dataGridView1);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(btnBack);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmCustomer";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCustomer";
			Load += frmCustomer_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnSearch;
		private TextBox txtSearch;
		private Button btnBack;
		private Panel panel2;
		private Button btnRefresh;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private Panel panel1;
		private DateTimePicker dtBirthday;
		private DateTimePicker dtOrderDate;
		private ComboBox cbxStatus;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txtTotal;
		private Label label2;
		private TextBox txtId;
		private Label label1;
		private Label label7;
		private Label label8;
		private TextBox txtCity;
		private TextBox txtName;
		private TextBox txtEmail;
		private TextBox txtCountry;
	}
}
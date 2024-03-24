namespace SaleManagementWinApp
{
	partial class frmOrder
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
			btnReset = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			panel1 = new Panel();
			btnDetails = new Button();
			dtShippedDate = new DateTimePicker();
			dtOrderDate = new DateTimePicker();
			cbxStatus = new ComboBox();
			cbxCustomer = new ComboBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			txtTotal = new TextBox();
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
			dataGridView1.Location = new Point(0, 403);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1071, 337);
			dataGridView1.TabIndex = 11;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = SystemColors.Highlight;
			btnSearch.Location = new Point(745, 16);
			btnSearch.Margin = new Padding(3, 4, 3, 4);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(86, 31);
			btnSearch.TabIndex = 10;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(490, 16);
			txtSearch.Margin = new Padding(3, 4, 3, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(231, 27);
			txtSearch.TabIndex = 9;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(957, -1);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(86, 31);
			btnBack.TabIndex = 8;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ControlLight;
			panel2.Controls.Add(btnReset);
			panel2.Controls.Add(btnDelete);
			panel2.Controls.Add(btnEdit);
			panel2.Controls.Add(btnAdd);
			panel2.Location = new Point(891, 49);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(151, 264);
			panel2.TabIndex = 7;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.DarkGray;
			btnReset.Location = new Point(35, 200);
			btnReset.Margin = new Padding(3, 4, 3, 4);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(86, 31);
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.IndianRed;
			btnDelete.Location = new Point(35, 143);
			btnDelete.Margin = new Padding(3, 4, 3, 4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(86, 31);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.DarkOrange;
			btnEdit.Location = new Point(35, 85);
			btnEdit.Margin = new Padding(3, 4, 3, 4);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(86, 31);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = SystemColors.Highlight;
			btnAdd.Location = new Point(35, 32);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(86, 31);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(btnDetails);
			panel1.Controls.Add(dtShippedDate);
			panel1.Controls.Add(dtOrderDate);
			panel1.Controls.Add(cbxStatus);
			panel1.Controls.Add(cbxCustomer);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(txtTotal);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtId);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(5, 16);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(447, 333);
			panel1.TabIndex = 6;
			// 
			// btnDetails
			// 
			btnDetails.BackColor = SystemColors.Highlight;
			btnDetails.Location = new Point(314, 285);
			btnDetails.Margin = new Padding(3, 4, 3, 4);
			btnDetails.Name = "btnDetails";
			btnDetails.Size = new Size(102, 31);
			btnDetails.TabIndex = 18;
			btnDetails.Text = "View Details";
			btnDetails.UseVisualStyleBackColor = false;
			btnDetails.Click += btnDetails_Click;
			// 
			// dtShippedDate
			// 
			dtShippedDate.CustomFormat = "dd/MM/yyyy";
			dtShippedDate.Format = DateTimePickerFormat.Custom;
			dtShippedDate.Location = new Point(159, 149);
			dtShippedDate.Margin = new Padding(3, 4, 3, 4);
			dtShippedDate.Name = "dtShippedDate";
			dtShippedDate.Size = new Size(257, 27);
			dtShippedDate.TabIndex = 17;
			// 
			// dtOrderDate
			// 
			dtOrderDate.CustomFormat = "dd/MM/yyyy";
			dtOrderDate.Format = DateTimePickerFormat.Custom;
			dtOrderDate.Location = new Point(160, 101);
			dtOrderDate.Margin = new Padding(3, 4, 3, 4);
			dtOrderDate.Name = "dtOrderDate";
			dtOrderDate.Size = new Size(257, 27);
			dtOrderDate.TabIndex = 16;
			// 
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Location = new Point(160, 247);
			cbxStatus.Margin = new Padding(3, 4, 3, 4);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(255, 28);
			cbxStatus.TabIndex = 6;
			// 
			// cbxCustomer
			// 
			cbxCustomer.FormattingEnabled = true;
			cbxCustomer.Location = new Point(160, 60);
			cbxCustomer.Margin = new Padding(3, 4, 3, 4);
			cbxCustomer.Name = "cbxCustomer";
			cbxCustomer.Size = new Size(255, 28);
			cbxCustomer.TabIndex = 2;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(14, 257);
			label6.Name = "label6";
			label6.Size = new Size(49, 20);
			label6.TabIndex = 14;
			label6.Text = "Status";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 205);
			label5.Name = "label5";
			label5.Size = new Size(42, 20);
			label5.TabIndex = 12;
			label5.Text = "Total";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 157);
			label4.Name = "label4";
			label4.Size = new Size(100, 20);
			label4.TabIndex = 10;
			label4.Text = "Shipped Date";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 109);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 8;
			label3.Text = "Order Date";
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(160, 201);
			txtTotal.Margin = new Padding(3, 4, 3, 4);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(255, 27);
			txtTotal.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 65);
			label2.Name = "label2";
			label2.Size = new Size(72, 20);
			label2.TabIndex = 6;
			label2.Text = "Customer";
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
			// frmOrder
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1071, 740);
			Controls.Add(dataGridView1);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(btnBack);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmOrder";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmOrder";
			Load += frmOrder_Load;
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
		private Button btnReset;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private Panel panel1;
		private ComboBox cbxCustomer;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox txtUnitsInStock;
		private Label label3;
		private TextBox txtTotal;
		private Label label2;
		private TextBox txtId;
		private Label label1;
		private DateTimePicker dtShippedDate;
		private DateTimePicker dtOrderDate;
		private ComboBox cbxStatus;
		private Button btnDetails;
	}
}
namespace SaleManagementWinApp
{
	partial class frmOrderHistory
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
			txtFind = new TextBox();
			btnFind = new Button();
			btnBack = new Button();
			panel1 = new Panel();
			btnDetails = new Button();
			dtShippedDate = new DateTimePicker();
			dtOrderDate = new DateTimePicker();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			txtTotal = new TextBox();
			txtId = new TextBox();
			label1 = new Label();
			cbxStatus = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 362);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1064, 281);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// txtFind
			// 
			txtFind.Location = new Point(537, 3);
			txtFind.Name = "txtFind";
			txtFind.Size = new Size(251, 27);
			txtFind.TabIndex = 2;
			// 
			// btnFind
			// 
			btnFind.BackColor = SystemColors.Highlight;
			btnFind.Location = new Point(808, 3);
			btnFind.Name = "btnFind";
			btnFind.Size = new Size(68, 29);
			btnFind.TabIndex = 3;
			btnFind.Text = "Search";
			btnFind.UseVisualStyleBackColor = false;
			btnFind.Click += btnFind_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(924, 3);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(94, 29);
			btnBack.TabIndex = 4;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(btnDetails);
			panel1.Controls.Add(dtShippedDate);
			panel1.Controls.Add(dtOrderDate);
			panel1.Controls.Add(cbxStatus);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(txtTotal);
			panel1.Controls.Add(txtId);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(12, 13);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(447, 313);
			panel1.TabIndex = 7;
			// 
			// btnDetails
			// 
			btnDetails.BackColor = SystemColors.Highlight;
			btnDetails.Location = new Point(314, 265);
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
			dtShippedDate.Location = new Point(159, 120);
			dtShippedDate.Margin = new Padding(3, 4, 3, 4);
			dtShippedDate.Name = "dtShippedDate";
			dtShippedDate.Size = new Size(257, 27);
			dtShippedDate.TabIndex = 17;
			// 
			// dtOrderDate
			// 
			dtOrderDate.CustomFormat = "dd/MM/yyyy";
			dtOrderDate.Format = DateTimePickerFormat.Custom;
			dtOrderDate.Location = new Point(160, 72);
			dtOrderDate.Margin = new Padding(3, 4, 3, 4);
			dtOrderDate.Name = "dtOrderDate";
			dtOrderDate.Size = new Size(257, 27);
			dtOrderDate.TabIndex = 16;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(14, 228);
			label6.Name = "label6";
			label6.Size = new Size(49, 20);
			label6.TabIndex = 14;
			label6.Text = "Status";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 176);
			label5.Name = "label5";
			label5.Size = new Size(42, 20);
			label5.TabIndex = 12;
			label5.Text = "Total";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 128);
			label4.Name = "label4";
			label4.Size = new Size(100, 20);
			label4.TabIndex = 10;
			label4.Text = "Shipped Date";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 80);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 8;
			label3.Text = "Order Date";
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(160, 172);
			txtTotal.Margin = new Padding(3, 4, 3, 4);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(255, 27);
			txtTotal.TabIndex = 5;
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
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Location = new Point(160, 218);
			cbxStatus.Margin = new Padding(3, 4, 3, 4);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(255, 28);
			cbxStatus.TabIndex = 6;
			// 
			// frmOrderHistory
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1064, 643);
			Controls.Add(panel1);
			Controls.Add(btnBack);
			Controls.Add(btnFind);
			Controls.Add(txtFind);
			Controls.Add(dataGridView1);
			Name = "frmOrderHistory";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmOrderHistory";
			Load += frmOrderHistory_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private TextBox txtFind;
		private Button btnFind;
		private Button btnBack;
		private Panel panel1;
		private Button btnDetails;
		private DateTimePicker dtShippedDate;
		private DateTimePicker dtOrderDate;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txtTotal;
		private TextBox txtId;
		private Label label1;
		private ComboBox cbxStatus;
	}
}
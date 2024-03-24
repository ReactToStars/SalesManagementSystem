namespace SaleManagementWinApp
{
	partial class frmProduct
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
			numUnitsInStock = new NumericUpDown();
			numUnitPrice = new NumericUpDown();
			label10 = new Label();
			txtMorphology = new TextBox();
			ptMorphology = new PictureBox();
			cbxStatus = new ComboBox();
			cbxCategory = new ComboBox();
			cbxSupplier = new ComboBox();
			txtName = new TextBox();
			label8 = new Label();
			txtDescription = new TextBox();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			txtId = new TextBox();
			label1 = new Label();
			panel2 = new Panel();
			btnRefresh = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			btnBack = new Button();
			txtSearch = new TextBox();
			btnSearch = new Button();
			dataGridView1 = new DataGridView();
			cbxFilter = new ComboBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numUnitsInStock).BeginInit();
			((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)ptMorphology).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(numUnitsInStock);
			panel1.Controls.Add(numUnitPrice);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(txtMorphology);
			panel1.Controls.Add(ptMorphology);
			panel1.Controls.Add(cbxStatus);
			panel1.Controls.Add(cbxCategory);
			panel1.Controls.Add(cbxSupplier);
			panel1.Controls.Add(txtName);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(txtDescription);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtId);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(14, 81);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(563, 435);
			panel1.TabIndex = 0;
			// 
			// numUnitsInStock
			// 
			numUnitsInStock.Location = new Point(160, 260);
			numUnitsInStock.Name = "numUnitsInStock";
			numUnitsInStock.Size = new Size(255, 27);
			numUnitsInStock.TabIndex = 25;
			// 
			// numUnitPrice
			// 
			numUnitPrice.Location = new Point(160, 208);
			numUnitPrice.Name = "numUnitPrice";
			numUnitPrice.Size = new Size(255, 27);
			numUnitPrice.TabIndex = 24;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(14, 397);
			label10.Name = "label10";
			label10.Size = new Size(83, 20);
			label10.TabIndex = 23;
			label10.Text = "Image Path";
			// 
			// txtMorphology
			// 
			txtMorphology.Location = new Point(160, 387);
			txtMorphology.Margin = new Padding(3, 4, 3, 4);
			txtMorphology.Name = "txtMorphology";
			txtMorphology.Size = new Size(255, 27);
			txtMorphology.TabIndex = 22;
			// 
			// ptMorphology
			// 
			ptMorphology.BackColor = SystemColors.GrayText;
			ptMorphology.Location = new Point(443, 15);
			ptMorphology.Margin = new Padding(3, 4, 3, 4);
			ptMorphology.Name = "ptMorphology";
			ptMorphology.Size = new Size(101, 131);
			ptMorphology.TabIndex = 21;
			ptMorphology.TabStop = false;
			// 
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Location = new Point(160, 348);
			cbxStatus.Margin = new Padding(3, 4, 3, 4);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(255, 28);
			cbxStatus.TabIndex = 7;
			// 
			// cbxCategory
			// 
			cbxCategory.FormattingEnabled = true;
			cbxCategory.Location = new Point(160, 65);
			cbxCategory.Margin = new Padding(3, 4, 3, 4);
			cbxCategory.Name = "cbxCategory";
			cbxCategory.Size = new Size(255, 28);
			cbxCategory.TabIndex = 2;
			// 
			// cbxSupplier
			// 
			cbxSupplier.FormattingEnabled = true;
			cbxSupplier.Location = new Point(160, 297);
			cbxSupplier.Margin = new Padding(3, 4, 3, 4);
			cbxSupplier.Name = "cbxSupplier";
			cbxSupplier.Size = new Size(255, 28);
			cbxSupplier.TabIndex = 8;
			// 
			// txtName
			// 
			txtName.Location = new Point(160, 104);
			txtName.Margin = new Padding(3, 4, 3, 4);
			txtName.Name = "txtName";
			txtName.Size = new Size(255, 27);
			txtName.TabIndex = 3;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(14, 301);
			label8.Name = "label8";
			label8.Size = new Size(64, 20);
			label8.TabIndex = 18;
			label8.Text = "Supplier";
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(160, 152);
			txtDescription.Margin = new Padding(3, 4, 3, 4);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(255, 27);
			txtDescription.TabIndex = 4;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(19, 352);
			label7.Name = "label7";
			label7.Size = new Size(49, 20);
			label7.TabIndex = 16;
			label7.Text = "Status";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(14, 263);
			label6.Name = "label6";
			label6.Size = new Size(98, 20);
			label6.TabIndex = 14;
			label6.Text = "Units In Stock";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 211);
			label5.Name = "label5";
			label5.Size = new Size(72, 20);
			label5.TabIndex = 12;
			label5.Text = "Unit Price";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 163);
			label4.Name = "label4";
			label4.Size = new Size(85, 20);
			label4.TabIndex = 10;
			label4.Text = "Description";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 115);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 8;
			label3.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 71);
			label2.Name = "label2";
			label2.Size = new Size(69, 20);
			label2.TabIndex = 6;
			label2.Text = "Category";
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
			// panel2
			// 
			panel2.BackColor = SystemColors.ControlLight;
			panel2.Controls.Add(btnRefresh);
			panel2.Controls.Add(btnDelete);
			panel2.Controls.Add(btnEdit);
			panel2.Controls.Add(btnAdd);
			panel2.Location = new Point(914, 81);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(151, 264);
			panel2.TabIndex = 1;
			// 
			// btnRefresh
			// 
			btnRefresh.BackColor = Color.DarkGray;
			btnRefresh.Location = new Point(35, 200);
			btnRefresh.Margin = new Padding(3, 4, 3, 4);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(86, 31);
			btnRefresh.TabIndex = 3;
			btnRefresh.Text = "Reset";
			btnRefresh.UseVisualStyleBackColor = false;
			btnRefresh.Click += btnRefresh_Click;
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
			btnEdit.BackColor = Color.OrangeRed;
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
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(979, -1);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(86, 31);
			btnBack.TabIndex = 2;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(573, 16);
			txtSearch.Margin = new Padding(3, 4, 3, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(231, 27);
			txtSearch.TabIndex = 3;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = SystemColors.Highlight;
			btnSearch.Location = new Point(811, 16);
			btnSearch.Margin = new Padding(3, 4, 3, 4);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(86, 31);
			btnSearch.TabIndex = 4;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 524);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1103, 273);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// cbxFilter
			// 
			cbxFilter.FormattingEnabled = true;
			cbxFilter.Location = new Point(914, 475);
			cbxFilter.Name = "cbxFilter";
			cbxFilter.Size = new Size(151, 28);
			cbxFilter.TabIndex = 6;
			cbxFilter.SelectedIndexChanged += cbxFilter_SelectedIndexChanged;
			// 
			// frmProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1103, 797);
			Controls.Add(cbxFilter);
			Controls.Add(dataGridView1);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(btnBack);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmProduct";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProduct";
			Load += frmProduct_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numUnitsInStock).EndInit();
			((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
			((System.ComponentModel.ISupportInitialize)ptMorphology).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private TextBox txtId;
		private Label label1;
		private Panel panel2;
		private Button btnRefresh;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private Button btnBack;
		private TextBox txtSearch;
		private Button btnSearch;
		private DataGridView dataGridView1;
		private Label label9;
		private TextBox txtName;
		private Label label8;
		private TextBox txtDescription;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private ComboBox cbxStatus;
		private ComboBox cbxCategory;
		private ComboBox cbxSupplier;
		private PictureBox ptMorphology;
		private Label label10;
		private TextBox txtMorphology;
		private NumericUpDown numUnitsInStock;
		private NumericUpDown numUnitPrice;
		private ComboBox cbxFilter;
	}
}
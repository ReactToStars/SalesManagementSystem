namespace SaleManagementWinApp
{
	partial class ProductDialog
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
			btnClear = new Button();
			label10 = new Label();
			txtMorphology = new TextBox();
			ptMorphology = new PictureBox();
			cbxStatus = new ComboBox();
			cbxCategory = new ComboBox();
			btnSelect = new Button();
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
			btnSubmit = new Button();
			btnReset = new Button();
			btnCancel = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numUnitsInStock).BeginInit();
			((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)ptMorphology).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(numUnitsInStock);
			panel1.Controls.Add(numUnitPrice);
			panel1.Controls.Add(btnClear);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(txtMorphology);
			panel1.Controls.Add(ptMorphology);
			panel1.Controls.Add(cbxStatus);
			panel1.Controls.Add(cbxCategory);
			panel1.Controls.Add(btnSelect);
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
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(608, 435);
			panel1.TabIndex = 1;
			// 
			// numUnitsInStock
			// 
			numUnitsInStock.Location = new Point(160, 260);
			numUnitsInStock.Name = "numUnitsInStock";
			numUnitsInStock.Size = new Size(255, 27);
			numUnitsInStock.TabIndex = 26;
			// 
			// numUnitPrice
			// 
			numUnitPrice.Location = new Point(160, 208);
			numUnitPrice.Name = "numUnitPrice";
			numUnitPrice.Size = new Size(255, 27);
			numUnitPrice.TabIndex = 25;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.DarkGray;
			btnClear.Location = new Point(357, 385);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(59, 32);
			btnClear.TabIndex = 24;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
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
			txtMorphology.Size = new Size(189, 27);
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
			// btnSelect
			// 
			btnSelect.BackColor = SystemColors.ActiveCaption;
			btnSelect.Location = new Point(455, 153);
			btnSelect.Margin = new Padding(3, 4, 3, 4);
			btnSelect.Name = "btnSelect";
			btnSelect.Size = new Size(73, 31);
			btnSelect.TabIndex = 6;
			btnSelect.Text = "Select";
			btnSelect.UseVisualStyleBackColor = false;
			btnSelect.Click += btnSelect_Click;
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
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Location = new Point(155, 455);
			btnSubmit.Margin = new Padding(3, 4, 3, 4);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(86, 31);
			btnSubmit.TabIndex = 2;
			btnSubmit.Text = "Save";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.DarkGray;
			btnReset.Location = new Point(248, 455);
			btnReset.Margin = new Padding(3, 4, 3, 4);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(86, 31);
			btnReset.TabIndex = 4;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.IndianRed;
			btnCancel.Location = new Point(341, 455);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(86, 31);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// ProductDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(608, 524);
			Controls.Add(btnCancel);
			Controls.Add(btnReset);
			Controls.Add(btnSubmit);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "ProductDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProductDialog";
			Load += ProductDialog_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numUnitsInStock).EndInit();
			((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
			((System.ComponentModel.ISupportInitialize)ptMorphology).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button btnClear;
		private Label label10;
		private TextBox txtMorphology;
		private PictureBox ptMorphology;
		private ComboBox cbxStatus;
		private ComboBox cbxCategory;
		private Button btnSelect;
		private ComboBox cbxSupplier;
		private TextBox txtName;
		private Label label8;
		private TextBox txtDescription;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox txtId;
		private Label label1;
		private Button btnSubmit;
		private Button btnReset;
		private Button btnCancel;
		private NumericUpDown numUnitsInStock;
		private NumericUpDown numUnitPrice;
	}
}
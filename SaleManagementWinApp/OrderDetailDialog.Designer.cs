namespace SaleManagementWinApp
{
	partial class OrderDetailDialog
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
			txtUnitPrice = new TextBox();
			cbxDiscount = new ComboBox();
			numQuantity = new NumericUpDown();
			cbxProduct = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			txtId = new TextBox();
			label1 = new Label();
			btnAdd = new Button();
			btnRefresh = new Button();
			btnBack = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Controls.Add(txtUnitPrice);
			panel1.Controls.Add(cbxDiscount);
			panel1.Controls.Add(numQuantity);
			panel1.Controls.Add(cbxProduct);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtId);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(14, 66);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(447, 266);
			panel1.TabIndex = 13;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(160, 102);
			txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(255, 27);
			txtUnitPrice.TabIndex = 22;
			// 
			// cbxDiscount
			// 
			cbxDiscount.FormattingEnabled = true;
			cbxDiscount.Location = new Point(160, 195);
			cbxDiscount.Margin = new Padding(3, 4, 3, 4);
			cbxDiscount.Name = "cbxDiscount";
			cbxDiscount.Size = new Size(255, 28);
			cbxDiscount.TabIndex = 21;
			// 
			// numQuantity
			// 
			numQuantity.Location = new Point(160, 155);
			numQuantity.Margin = new Padding(3, 4, 3, 4);
			numQuantity.Name = "numQuantity";
			numQuantity.Size = new Size(256, 27);
			numQuantity.TabIndex = 18;
			// 
			// cbxProduct
			// 
			cbxProduct.FormattingEnabled = true;
			cbxProduct.Location = new Point(160, 60);
			cbxProduct.Margin = new Padding(3, 4, 3, 4);
			cbxProduct.Name = "cbxProduct";
			cbxProduct.Size = new Size(255, 28);
			cbxProduct.TabIndex = 2;
			cbxProduct.SelectedValueChanged += cbxProduct_SelectedValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 205);
			label5.Name = "label5";
			label5.Size = new Size(67, 20);
			label5.TabIndex = 12;
			label5.Text = "Discount";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 157);
			label4.Name = "label4";
			label4.Size = new Size(65, 20);
			label4.TabIndex = 10;
			label4.Text = "Quantity";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 109);
			label3.Name = "label3";
			label3.Size = new Size(72, 20);
			label3.TabIndex = 8;
			label3.Text = "Unit Price";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 65);
			label2.Name = "label2";
			label2.Size = new Size(60, 20);
			label2.TabIndex = 6;
			label2.Text = "Product";
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
			// btnAdd
			// 
			btnAdd.BackColor = SystemColors.Highlight;
			btnAdd.Location = new Point(55, 376);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(86, 31);
			btnAdd.TabIndex = 14;
			btnAdd.Text = "Save";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.BackColor = Color.DarkGray;
			btnRefresh.Location = new Point(174, 376);
			btnRefresh.Margin = new Padding(3, 4, 3, 4);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(86, 31);
			btnRefresh.TabIndex = 15;
			btnRefresh.Text = "Reset";
			btnRefresh.UseVisualStyleBackColor = false;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(286, 376);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(86, 31);
			btnBack.TabIndex = 16;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// OrderDetailDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(477, 449);
			Controls.Add(btnBack);
			Controls.Add(btnRefresh);
			Controls.Add(btnAdd);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "OrderDetailDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OrderDetailDialog";
			Load += OrderDetailDialog_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private ComboBox cbxDiscount;
		private NumericUpDown numQuantity;
		private ComboBox cbxProduct;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox txtId;
		private Label label1;
		private Button btnAdd;
		private Button btnRefresh;
		private Button btnBack;
		private TextBox txtUnitPrice;
	}
}
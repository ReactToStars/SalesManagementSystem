namespace SaleManagementWinApp
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			menu = new MenuStrip();
			statisticsSalesToolStripMenuItem = new ToolStripMenuItem();
			productsToolStripMenuItem = new ToolStripMenuItem();
			ordersToolStripMenuItem = new ToolStripMenuItem();
			customersToolStripMenuItem = new ToolStripMenuItem();
			lblWelcome = new Label();
			toolStrip1 = new ToolStrip();
			toolStrip = new ToolStripDropDownButton();
			profileToolStripMenuItem = new ToolStripMenuItem();
			historyOrdersToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			label1 = new Label();
			menu.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menu
			// 
			menu.Dock = DockStyle.None;
			menu.ImageScalingSize = new Size(20, 20);
			menu.Items.AddRange(new ToolStripItem[] { statisticsSalesToolStripMenuItem, productsToolStripMenuItem, ordersToolStripMenuItem, customersToolStripMenuItem });
			menu.Location = new Point(0, 0);
			menu.Name = "menu";
			menu.Padding = new Padding(7, 3, 0, 3);
			menu.Size = new Size(367, 30);
			menu.TabIndex = 0;
			menu.Text = "menuStrip1";
			// 
			// statisticsSalesToolStripMenuItem
			// 
			statisticsSalesToolStripMenuItem.Name = "statisticsSalesToolStripMenuItem";
			statisticsSalesToolStripMenuItem.Size = new Size(119, 24);
			statisticsSalesToolStripMenuItem.Text = "Statistics Sales";
			statisticsSalesToolStripMenuItem.Click += statisticsSalesToolStripMenuItem_Click;
			// 
			// productsToolStripMenuItem
			// 
			productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			productsToolStripMenuItem.Size = new Size(80, 24);
			productsToolStripMenuItem.Text = "Products";
			productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
			// 
			// ordersToolStripMenuItem
			// 
			ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			ordersToolStripMenuItem.Size = new Size(67, 24);
			ordersToolStripMenuItem.Text = "Orders";
			ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
			// 
			// customersToolStripMenuItem
			// 
			customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			customersToolStripMenuItem.Size = new Size(92, 24);
			customersToolStripMenuItem.Text = "Customers";
			customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Location = new Point(638, 7);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(71, 20);
			lblWelcome.TabIndex = 2;
			lblWelcome.Text = "Welcome";
			lblWelcome.TextAlign = ContentAlignment.TopRight;
			// 
			// toolStrip1
			// 
			toolStrip1.Dock = DockStyle.None;
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStrip });
			toolStrip1.Location = new Point(878, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(37, 27);
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStrip
			// 
			toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStrip.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, historyOrdersToolStripMenuItem, logoutToolStripMenuItem });
			toolStrip.Image = (Image)resources.GetObject("toolStrip.Image");
			toolStrip.ImageTransparentColor = Color.Magenta;
			toolStrip.Name = "toolStrip";
			toolStrip.RightToLeft = RightToLeft.Yes;
			toolStrip.ShowDropDownArrow = false;
			toolStrip.Size = new Size(24, 24);
			toolStrip.Text = "toolStripDropDownButton1";
			// 
			// profileToolStripMenuItem
			// 
			profileToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
			profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			profileToolStripMenuItem.Size = new Size(224, 26);
			profileToolStripMenuItem.Text = "Profile";
			profileToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
			profileToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
			profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
			// 
			// historyOrdersToolStripMenuItem
			// 
			historyOrdersToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
			historyOrdersToolStripMenuItem.Name = "historyOrdersToolStripMenuItem";
			historyOrdersToolStripMenuItem.Size = new Size(224, 26);
			historyOrdersToolStripMenuItem.Text = "History Orders";
			historyOrdersToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
			historyOrdersToolStripMenuItem.Click += historyOrdersToolStripMenuItem_Click;
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new Size(224, 26);
			logoutToolStripMenuItem.Text = "Log Out";
			logoutToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
			logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
			// 
			// sqlCommand1
			// 
			sqlCommand1.CommandTimeout = 30;
			sqlCommand1.Connection = null;
			sqlCommand1.Notification = null;
			sqlCommand1.Transaction = null;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Millimeter);
			label1.Location = new Point(164, 179);
			label1.Name = "label1";
			label1.Size = new Size(562, 59);
			label1.TabIndex = 4;
			label1.Text = "Sales Management System";
			label1.TextAlign = ContentAlignment.TopRight;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(914, 600);
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			Controls.Add(lblWelcome);
			Controls.Add(menu);
			MainMenuStrip = menu;
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmMain";
			Load += frmMain_Load;
			menu.ResumeLayout(false);
			menu.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menu;
		private ToolStripMenuItem statisticsSalesToolStripMenuItem;
		private ToolStripMenuItem productsToolStripMenuItem;
		private ToolStripMenuItem ordersToolStripMenuItem;
		private ToolStripMenuItem customersToolStripMenuItem;
		private Label lblWelcome;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStrip;
		private ToolStripMenuItem profileToolStripMenuItem;
		private ToolStripMenuItem historyOrdersToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private Label label1;
	}
}
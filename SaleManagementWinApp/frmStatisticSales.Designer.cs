namespace SaleManagementWinApp
{
	partial class frmStatisticSales
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
			label1 = new Label();
			dtFrom = new DateTimePicker();
			btnFilter = new Button();
			dtTo = new DateTimePicker();
			label2 = new Label();
			btnBack = new Button();
			((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
			SuspendLayout();
			// 
			// chartRevenue
			// 
			chartArea2.Name = "ChartArea1";
			chartRevenue.ChartAreas.Add(chartArea2);
			chartRevenue.Dock = DockStyle.Bottom;
			legend2.Name = "Legend1";
			chartRevenue.Legends.Add(legend2);
			chartRevenue.Location = new Point(0, 126);
			chartRevenue.Name = "chartRevenue";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Revenue";
			chartRevenue.Series.Add(series2);
			chartRevenue.Size = new Size(1187, 617);
			chartRevenue.TabIndex = 0;
			chartRevenue.Text = "chart1";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(194, 41);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 1;
			label1.Text = "From:";
			// 
			// dtFrom
			// 
			dtFrom.CustomFormat = "dd/MM/yyyy";
			dtFrom.Format = DateTimePickerFormat.Custom;
			dtFrom.Location = new Point(246, 37);
			dtFrom.Name = "dtFrom";
			dtFrom.Size = new Size(250, 27);
			dtFrom.TabIndex = 2;
			// 
			// btnFilter
			// 
			btnFilter.BackColor = SystemColors.Highlight;
			btnFilter.Location = new Point(855, 37);
			btnFilter.Name = "btnFilter";
			btnFilter.Size = new Size(94, 29);
			btnFilter.TabIndex = 3;
			btnFilter.Text = "Filter";
			btnFilter.UseVisualStyleBackColor = false;
			btnFilter.Click += btnFilter_Click;
			// 
			// dtTo
			// 
			dtTo.CustomFormat = "dd/MM/yyyy";
			dtTo.Format = DateTimePickerFormat.Custom;
			dtTo.Location = new Point(569, 37);
			dtTo.Name = "dtTo";
			dtTo.Size = new Size(250, 27);
			dtTo.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(535, 41);
			label2.Name = "label2";
			label2.Size = new Size(28, 20);
			label2.TabIndex = 4;
			label2.Text = "To:";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.IndianRed;
			btnBack.Location = new Point(1066, 1);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(86, 31);
			btnBack.TabIndex = 15;
			btnBack.Text = "Cancel";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// frmStatisticSales
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1187, 743);
			Controls.Add(btnBack);
			Controls.Add(dtTo);
			Controls.Add(label2);
			Controls.Add(btnFilter);
			Controls.Add(dtFrom);
			Controls.Add(label1);
			Controls.Add(chartRevenue);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmStatisticSales";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmStatisticSales";
			Load += frmStatisticSales_Load;
			((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
		private Label label1;
		private DateTimePicker dtFrom;
		private Button btnFilter;
		private DateTimePicker dtTo;
		private Label label2;
		private Button btnBack;
	}
}
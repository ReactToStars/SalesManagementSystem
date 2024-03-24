using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace SaleManagementWinApp
{
	public partial class frmStatisticSales : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public frmStatisticSales(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void frmStatisticSales_Load(object sender, EventArgs e)
		{
			dtFrom.Value = DateTime.Now.AddDays(-7);
			dtTo.Value = DateTime.Now;
			//DisplayChart();
			LoadChart();
		}

		private void DisplayChart()
		{
			// Add chart area
			ChartArea chartArea = new ChartArea();
			chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Set date format
			chartRevenue.ChartAreas.Add(chartArea);

			// Add series
			Series series = new Series();
			//series.ChartType = SeriesChartType.Line;

			var date1 = new DateTime(2024, 3, 1);
			var date2 = new DateTime(2024, 3, 2);
			var date3 = new DateTime(2024, 3, 3);
			var date4 = new DateTime(2024, 3, 4);
			var date5 = new DateTime(2024, 3, 5);

			// Add data points with dates
			series.Points.AddXY(date1, 1000);
			series.Points.AddXY(date2, 2000);
			series.Points.AddXY(date3, 5600);
			series.Points.AddXY(date4, 1200);
			series.Points.AddXY(date5, 8620);

			// Add series to the chart
			chartRevenue.Series.Add(series);
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			var fromDate = dtFrom.Value;
			var toDate = dtTo.Value;
			if (dtFrom.Value.AddDays(30) < dtTo.Value || dtFrom.Value > dtTo.Value)
			{
				MessageBox.Show("'From date' must be smaller than 'to date' and maximum filter range is 30 days", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			LoadChart();
		}

		private void LoadChart()
		{
			// Clear previous data
			chartRevenue.Series["Revenue"].Points.Clear();

			// Assuming you have a DataTable named "revenueDataTable" with columns "Date" and "Revenue"
			DataTable revenueDataTable = GetRevenueData();

			// Filter the data to the specific date range
			DataView dv = new DataView(revenueDataTable);
			dv.RowFilter = $"Date >= #{dtFrom.Value.Date}# AND Date <= #{dtTo.Value.Date}#";

			// Add data points to the chart
			foreach (DataRowView drv in dv)
			{
				DateTime date = (DateTime)drv["Date"];
				var revenue = drv["Revenue"];
				// Add the data point to the series
				chartRevenue.Series["Revenue"].Points.AddXY(date, revenue);
			}

			// Set X-axis label format
			chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";

			//Set X-axis interval type and interval
			chartRevenue.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
			chartRevenue.ChartAreas[0].AxisX.Interval = 5;

			chartRevenue.Series["Revenue"]["PixelPointWidth"] = "15";
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private DataTable GetRevenueData()
		{
			using var scope = _serviceProvider.CreateScope();
			var repository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
			var revenueData = repository.GetRevenueBy(dtFrom.Value, dtTo.Value);

			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Date", typeof(DateTime));
			dataTable.Columns.Add("Revenue", typeof(decimal));

			foreach (var item in revenueData)
			{
				dataTable.Rows.Add(item.Date, item.Revenue);
			}
			return dataTable;
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlFormsApp.Classes;

namespace SqlFormsApp
{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm(int sensorId, string name, double englow, double enghigh, DateTime start, DateTime end)
        {
            InitializeComponent();
            int selectedSensorId = sensorId;
            string selectedName = name;
            double selectedEngLow = englow;
            double selectedEngHigh = enghigh;
            DateTime selectedStart = start;
            DateTime selectedEnd = end;
            labelSensordata.Text = "Sensor: " + selectedName;
            labelStart.Text = "Start time: " + selectedStart.ToString();
            labelEnd.Text = "End time: " + selectedEnd.ToString();
            FillGridView(selectedSensorId,selectedStart,selectedEnd);
            FillChartView(selectedSensorId,selectedStart,selectedEnd,selectedName,selectedEngLow,selectedEngHigh);
            GridConfig();
        }

        void FillGridView(int sensorId,DateTime start, DateTime end)
        {
            List<Data> dataList = new List<Data>();

            Data data = new Data();

            dataList = data.GetData(sensorId, start, end);

            dataGridViewData.DataSource = dataList;
        }

        void FillChartView(int sensorId,DateTime start,DateTime end, string name, double englow, double enghigh)
        {
            List<Data> dataList = new List<Data>();

            Data data = new Data();

            dataList = data.GetData(sensorId, start, end);
            //var objChart = chartData.ChartAreas[0];
            //objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            //objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            //chartData.Series.Clear();
            //chartData.Series.Add("0");

            foreach (Data dataData in dataList)
            {
                chartData.Series["Series1"].Points.AddXY(dataData.Timestamp,dataData.Value);
            }

            chartData.Titles.Add("Sensor Chart: " + name);
            chartData.ChartAreas[0].AxisY.Minimum = englow;
            chartData.ChartAreas[0].AxisY.Maximum = enghigh;
            chartData.ChartAreas[0].AxisY.Title = "Value";
            chartData.ChartAreas[0].AxisX.Title = "Time";
        }

        void GridConfig()
        {
            dataGridViewData.Columns[0].HeaderText = "SensorId";
            dataGridViewData.Columns[1].HeaderText = "Value";
            dataGridViewData.Columns[2].HeaderText = "Timestamp";

            dataGridViewData.Columns[0].Width = 70;
            dataGridViewData.Columns[1].Width = 100;
            dataGridViewData.Columns[2].Width = 135;
        }
    }
}

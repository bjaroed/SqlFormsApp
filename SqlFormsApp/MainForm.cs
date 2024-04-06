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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
            GridConfig();
        }

        void FillGridView()
        {
            List<Sensor> sensorList = new List<Sensor>();

            Sensor sensor = new Sensor();

            sensorList = sensor.GetSensors();

            dataGridViewSensors.DataSource = sensorList;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewSensorForm formNewSensor = new NewSensorForm();
            formNewSensor.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSensor();
        }

        void DeleteSensor()
        {
            int sensorId;
            string Name;

            sensorId = (int)dataGridViewSensors.CurrentRow.Cells[0].Value;
            Name = (string)dataGridViewSensors.CurrentRow.Cells[1].Value;
            var msg = MessageBox.Show("Do you really want to delete sensor: " + Name, "Delete Sensor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                Sensor sensor = new Sensor();
                sensor.DeleteSensor(sensorId);
            }
            FillGridView();
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        void GetData()
        {
            int sensorId;
            string name;
            double englow;
            double enghigh;
            DateTime start;
            DateTime end;

            sensorId = (int)dataGridViewSensors.CurrentRow.Cells[0].Value;
            name = (string)dataGridViewSensors.CurrentRow.Cells[1].Value;
            englow = (double)dataGridViewSensors.CurrentRow.Cells[4].Value;
            enghigh = (double)dataGridViewSensors.CurrentRow.Cells[5].Value;
            start = dateTimePickerFrom.Value;
            end = dateTimePickerTo.Value;


            ViewDataForm viewDataForm = new ViewDataForm(sensorId, name, englow, enghigh, start, end);
            viewDataForm.ShowDialog();

        }
        void GridConfig()
        {
            dataGridViewSensors.Columns[0].HeaderText = "SensorId";
            dataGridViewSensors.Columns[1].HeaderText = "Name";
            dataGridViewSensors.Columns[2].HeaderText = "Description";
            dataGridViewSensors.Columns[3].HeaderText = "Unit";
            dataGridViewSensors.Columns[4].HeaderText = "Eng Low";
            dataGridViewSensors.Columns[5].HeaderText = "Eng High";

            dataGridViewSensors.Columns[0].Width = 70;
            dataGridViewSensors.Columns[1].Width = 150;
            dataGridViewSensors.Columns[2].Width = 175;
            dataGridViewSensors.Columns[3].Width = 80;
            dataGridViewSensors.Columns[4].Width = 90;
            dataGridViewSensors.Columns[5].Width = 90;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int sensorId;

            sensorId = (int)dataGridViewSensors.CurrentRow.Cells[0].Value;

            EditSensorForm editSensorForm = new EditSensorForm(sensorId);
            editSensorForm.ShowDialog();
        }
    }
}

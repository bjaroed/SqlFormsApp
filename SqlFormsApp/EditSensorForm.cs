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
    public partial class EditSensorForm : Form
    {
        int selectedSensorId;
        public EditSensorForm(int sensorId)
        {
            InitializeComponent();
            selectedSensorId = sensorId;
            GetSensorData();
        }
        void GetSensorData()
        {
            Sensor sensor = new Sensor();
            sensor = sensor.GetSensorData(selectedSensorId);

            textBoxName.Text = sensor.Name;
            textBoxDescription.Text = sensor.Description;
            textBoxUnit.Text = sensor.Unit;
            textBoxEngLow.Text = Convert.ToString(sensor.EngLow);
            textBoxEngHigh.Text = Convert.ToString(sensor.EngHigh);
        }
        void EditSensorData()
        {
            Sensor sensor = new Sensor();

            sensor.SensorId = selectedSensorId;
            sensor.Name = textBoxName.Text;
            sensor.Description = textBoxDescription.Text;
            sensor.Unit = textBoxUnit.Text;
            sensor.EngLow = Convert.ToDouble(textBoxEngLow.Text);
            sensor.EngHigh = Convert.ToDouble(textBoxEngHigh.Text);

            sensor.EditSensor(sensor);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditSensorData();
            this.Close();
        }
    }
}

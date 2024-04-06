using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlFormsApp.Classes;

namespace SqlFormsApp
{
    public partial class NewSensorForm : Form
    {
        public NewSensorForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" & textBoxDescription.Text != "" & textBoxUnit.Text != "" & textBoxEngLow.Text != "" & textBoxEngHigh.Text != "")
            {
                SaveSensorData();
                this.Close();
            }
            else
            {
                var msg = MessageBox.Show("All input fields are mandatory","Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
        }

        void SaveSensorData()
        {
            Sensor sensor = new Sensor();

            sensor.Name = textBoxName.Text;
            sensor.Description = textBoxDescription.Text;
            sensor.Unit = textBoxUnit.Text;
            sensor.EngLow = Convert.ToDouble(textBoxEngLow.Text);
            sensor.EngHigh = Convert.ToDouble(textBoxEngHigh.Text);

            sensor.CreateSensor(sensor);
        }

        void ValidateForm()
        {

        }
    }
}

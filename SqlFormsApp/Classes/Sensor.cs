using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlFormsApp.Classes
{
    internal class Sensor
    {
        public int SensorId {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit {  get; set; }
        public double EngLow {  get; set; }
        public double EngHigh { get; set; }


        string connectionstring = "Server=BJARTE\\SQLEXPRESS;Database=SENSORDB;User Id=br;Password=admin;";
        
        //readonly string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public List<Sensor> GetSensors()

        {
            List<Sensor> SensorList = new List<Sensor>();

            SqlConnection conn = new SqlConnection(connectionstring);

            string selectSQL = "select SensorId, Name, Description, Unit, EngLow, EngHigh from SENSOR";

            conn.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    Sensor Sensor = new Sensor();

                    Sensor.SensorId = Convert.ToInt16(reader["SensorId"]);
                    Sensor.Name = Convert.ToString(reader["Name"]);
                    Sensor.Description = Convert.ToString(reader["Description"]);
                    Sensor.Unit = Convert.ToString(reader["Unit"]);
                    Sensor.EngLow = Convert.ToDouble(reader["EngLow"]);
                    Sensor.EngHigh = Convert.ToDouble(reader["EngHigh"]);

                    SensorList.Add(Sensor);
                }
            }
            return SensorList;
        }

        public void CreateSensor(Sensor sensor)
        {
            SqlConnection conn = new SqlConnection(connectionstring);

            string selectSQL = "INSERT INTO SENSOR (Name, Description, Unit, EngLow, EngHigh) VALUES('";
            string values = sensor.Name + "','" + sensor.Description + "','" + sensor.Unit + "','" + sensor.EngLow + "','" + sensor.EngHigh + "')";
            selectSQL += values;

            conn.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteSensor(int SensorId)
        {
            SqlConnection conn = new SqlConnection(connectionstring);

            string selectSQL = "DELETE FROM DATA WHERE SensorId=";
            string values = SensorId.ToString();
            selectSQL += values;

            conn.Open();

            SqlCommand cmd1 = new SqlCommand(selectSQL, conn);

            cmd1.ExecuteNonQuery();

            selectSQL = "DELETE FROM SENSOR WHERE SensorId=";
            values = SensorId.ToString();
            selectSQL += values;

            SqlCommand cmd2 = new SqlCommand(selectSQL, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();
        }
        public Sensor GetSensorData(int SensorId)
        {
            Sensor sensor = new Sensor();

            SqlConnection conn = new SqlConnection(connectionstring);

            string selectSQL = "select SensorId, Name, Description, Unit, EngLow, EngHigh from SENSOR WHERE SensorId=" + SensorId;

            conn.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    sensor.SensorId = Convert.ToInt16(reader["SensorId"]);
                    sensor.Name = Convert.ToString(reader["Name"]);
                    sensor.Description = Convert.ToString(reader["Description"]);
                    sensor.Unit = Convert.ToString(reader["Unit"]);
                    sensor.EngLow = Convert.ToDouble(reader["EngLow"]);
                    sensor.EngHigh = Convert.ToDouble(reader["EngHigh"]);
                }
            }
            return sensor;
        }
        public void EditSensor(Sensor sensor)
        {
            SqlConnection conn = new SqlConnection(connectionstring);

            string selectSQL = "UPDATE SENSOR SET Name='"+sensor.Name+"',Description='"+sensor.Description+"',Unit='"+sensor.Unit+"',EngLow="+sensor.EngLow+",EngHigh=" +sensor.EngHigh +" WHERE SensorId="+sensor.SensorId;

            conn.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}

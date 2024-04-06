using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlFormsApp.Classes
{
    internal class Data
    {
        public int SensorId { get; set; }
        public double Value { get; set; }
        public string Timestamp { get; set; }

        string connectionstring = "Server=BJARTE\\SQLEXPRESS;Database=SENSORDB;User Id=br;Password=admin;";

        //readonly string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public List<Data> GetData(int SensorId, DateTime Start, DateTime End)
        {
            List<Data> DataList = new List<Data>();

            SqlConnection conn = new SqlConnection(connectionstring);

            string selectedStart = Start.ToString("yyyy-MM-dd HH:mm:ss");
            string selectedEnd = End.ToString("yyyy-MM-dd HH:mm:ss");

            string selectSQL = "SELECT SensorId, Value,Timestamp FROM DATA WHERE Timestamp BETWEEN '" + selectedStart + "' AND '" + selectedEnd + "' AND SensorId IN (" + SensorId + ")";

            conn.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Data Data = new Data();

                    Data.SensorId = (int)reader["SensorId"];
                    Data.Value = (Double)reader["Value"];
                    Data.Timestamp = Convert.ToString(reader["Timestamp"]);

                    DataList.Add(Data);
                }
            }
            return DataList;
        }
    }
    
}

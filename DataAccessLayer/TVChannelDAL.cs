using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TVChannelDAL
    {

        private SqlConnection sqlConnection;

        private void Connection()
        {
            string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddChannel(TVChannel tVChannel)
        {
            Connection();
            sqlConnection.Open();
            string query = "INSERT INTO TVChannel Values ('" + tVChannel.TVChannelName + "','" + tVChannel.TVChanneltype + "','" + tVChannel.Description + "');";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            int rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows >= 1)
                return true;
            else
                return false;
        }

         public List<TVChannel> GetChannel()
        {
            Connection();
            sqlConnection.Open();
            List<TVChannel> tvChannel = new List<TVChannel>();
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM TVChannel";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                tvChannel.Add(
                    new TVChannel
                    {
                        TVChannelId = Convert.ToInt32(dataRow["TVChannelId"]),
                        TVChannelName = dataRow["TVChannelName"].ToString(),
                        TVChanneltype = dataRow["TVChannelType"].ToString(),
                        Description = dataRow["Description"].ToString()
                    }
                    ) ;
            }

            return tvChannel;

        }
    }
}

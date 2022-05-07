using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class TVProgramDAL
    {

        private SqlConnection sqlConnection;

        private void Connection()
        {
            string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddProgram(TVProgram tVProgram)
        {
            int rows = -1;
            try
            {
                Connection();
                sqlConnection.Open();
                string query = "INSERT INTO TVProgram Values ('" + tVProgram.TVProgramName + "','" + tVProgram.TVProgramCategory + "','" + tVProgram.TVProgramChannelName +
                    "','" + tVProgram.TVProgramDesc + "','" + tVProgram.TVProgramDuration + "');";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                rows = sqlCommand.ExecuteNonQuery();
            }catch(Exception )
            {

            }
            if (rows >= 1)
                return true;
            else
                return false;
        }

        public List<TVProgram> DisplayTVProgByChannelType(string channeltype)
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection();
                sqlConnection.Open();
                string query = "select * from TVProgram P inner  join TVChannel C on P.TVProgramChannelName = C.TVChannelName and C.TVChannelType = '" + channeltype + "';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
            }catch(Exception)
            {

            }
            sqlConnection.Close();

            List<TVProgram> tVProgram = new List<TVProgram>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                tVProgram.Add(
                    new TVProgram
                    {
                        TVProgramId = Convert.ToInt32(dataRow["TVProgramId"].ToString()),
                        TVProgramName = dataRow["TVProgramName"].ToString(),
                        TVProgramCategory = dataRow["TVProgramCategory"].ToString(),
                        TVProgramChannelName = dataRow["TVProgramChannelName"].ToString(),
                        TVProgramDesc = dataRow["TVProgramDesc"].ToString(),
                        TVProgramDuration = dataRow["TVProgramDuration"].ToString()
                    }
                    ) ;
            }

            return tVProgram;

        }
    }
}

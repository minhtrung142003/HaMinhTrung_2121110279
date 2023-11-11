using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace HaMinhTrung_0279
{
    internal class Modify
    {
        public Modify() { }
        SqlDataAdapter dataAdapter;
        SqlCommand SqlCommand;
        
        public DataTable Table(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(data);
                sqlConnection.Close();
            }
                return data;
        }

      
    }
}

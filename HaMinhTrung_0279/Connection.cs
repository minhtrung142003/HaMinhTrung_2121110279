using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace HaMinhTrung_0279
{
    internal class Connection
    {

        private static string stringConnection = "Data Source=TIEUPHU\\TIEUPHU;Initial Catalog=DoAnMonHoc;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}

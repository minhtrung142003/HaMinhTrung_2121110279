using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaMinhTrung_0279.DAL
{
    public class dbConnectionData
    {
        public static SqlConnection Hamketnoi()
        {
            SqlConnection Conn = new SqlConnection("Data Source=TIEUPHU\\TIEUPHU;Initial Catalog=DoAnMonHoc;Integrated Security=True");
            return Conn;
        }
            
    }
}

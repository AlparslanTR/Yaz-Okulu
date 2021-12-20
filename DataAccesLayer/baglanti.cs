using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccesLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-38ER4CK\SQLEXPRESS;Initial Catalog=YazOkulu;Integrated Security=True");

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADELAYER
{
    class BAGLANTI
    {
        public static readonly SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-I4MA6LQ\\SQLEXPRESS;Initial Catalog=KUTUPHANE;User ID=sa;Password = \"mikrolab\"");
    }
}

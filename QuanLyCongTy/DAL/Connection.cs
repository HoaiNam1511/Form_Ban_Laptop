using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.Strcon);
    }
}

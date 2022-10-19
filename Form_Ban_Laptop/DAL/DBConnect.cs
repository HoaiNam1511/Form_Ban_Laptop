using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.ketnoi);
    }
}

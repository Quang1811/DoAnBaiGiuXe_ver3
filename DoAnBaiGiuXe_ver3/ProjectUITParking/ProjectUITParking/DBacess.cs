using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ProjectUITParking
{
    class DBacess
    {
        public SqlConnection Getcon()
        {
            return new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=parking;Integrated Security=True");

        }

      }
}

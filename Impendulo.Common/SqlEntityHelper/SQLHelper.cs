using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Impendulo.Common.SqlHelper
{
   public  class SQLHelper
    {
        SqlConnection cn;
        public SQLHelper(string ConnectionString)
        {
            cn = new SqlConnection(ConnectionString);
        }
        public Boolean hasSQLConnectionPassed
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                    return true;
                }else
                {
                    return false;
                }
                
            }
        }
       
    }
}

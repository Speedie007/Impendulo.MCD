using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Common.EntityFrameWorkHelper
{
    public class EntityFrameworkHelper
    {
        EntityConnection cn;
        public EntityFrameworkHelper(string ConnectionString)
        {
            cn = new EntityConnection(ConnectionString);
        }
        public Boolean hasSQLConnectionPassed
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}

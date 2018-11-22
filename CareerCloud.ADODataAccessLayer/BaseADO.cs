using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {
        protected string Conn;

        public BaseADO()
        {
            Conn = @"Data Source=DHARMESH4RUCHIT\HUMBERBRIDGING;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True";
        }
    }
}

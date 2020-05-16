using Market.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.ORM.Facade
{
    public class SaleDetailsORM:ORMBase<SaleDetails>
    {
        public string TodaySales()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_TodaySales", Tools.Connection);
            return Tools.Statistics(command);
        }

        public string TodayEarn()
        {
            SqlCommand command = new SqlCommand("prc_Statistics_TodayEarn", Tools.Connection);
            return Tools.Statistics(command);
        }
    }
}

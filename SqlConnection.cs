using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CBDistro
{
    public class SqlConnection
    {
        SqlConnection myConnection = new SqlConnection("User ID=CBDAdmin;" + "Password=N@vy2CbD!stro-2019;Server=tcp:cbdistro.database.windows.net,1433;" + "Trusted_Connection=yes;" + "database=CBDistro; " +
                                       "connection timeout=30");
    }
}

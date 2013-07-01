using System;
using System.Collections.Generic;
using System.Data.Entity.Config;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EFMvcApplication8
{
    public class MyDbConfig : DbConfiguration
    {
        public MyDbConfig()
        {
            AddExecutionStrategy(() => new SqlAzureExecutionStrategy());
        }
        //private IExecutionStrategy myDbExecutionStrategy()
        //{
        //    SqlAzureExecutionStrategy mydb = new SqlAzureExecutionStrategy();
        //    return mydb;
        //}
    }
}
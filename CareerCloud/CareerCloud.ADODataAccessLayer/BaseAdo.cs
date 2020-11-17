using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SqlClient;

namespace CareerCloud.ADODataAccessLayer
{   
    public abstract class BaseAdo
    {
        protected string _connectionString;
        public BaseAdo()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                 .AddJsonFile("appsettings.json", false).Build();
            _connectionString = configuration.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
    }
}

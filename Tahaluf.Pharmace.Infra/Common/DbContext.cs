using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Tahaluf.Pharmace.Core.Common;

namespace Tahaluf.Pharmace.Infra.Common
{
    public class DbContext : IDbContext
    {

        private DbConnection dbConnecion;
        private readonly IConfiguration configuration;


        public DbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public DbConnection Connection
        {
            get
            {
                if (dbConnecion == null)
                {
                    //connect
                    dbConnecion = new OracleConnection(configuration["ConnectionStrings:DBConnectionString"]);
                    dbConnecion.Open();
                }
                else if (dbConnecion.State != ConnectionState.Open)
                {
                    dbConnecion.Open();
                }

                return dbConnecion;
            }
        }
    }
}

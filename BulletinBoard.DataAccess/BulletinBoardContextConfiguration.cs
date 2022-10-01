using BulletinBoard.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess
{
    public class BulletinBoardContextConfiguration : IDbContextOptionsConfigurator<BulletinBoardContext>
    {
        private const string PostgresConnectionStringName = "PostgresBulletinBoardDb";
        private const string MsSqlConnectionStringName = "MsSqlBulletinBoardDb";

        private readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;

        public BulletinBoardContextConfiguration(ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            _loggerFactory = loggerFactory;
            _configuration = configuration;
        }

        public void Configure(DbContextOptionsBuilder<BulletinBoardContext> options)
        {
            
            //var useMsSql = _configuration.Get<bool>("DataBaseOptions:UseMsSql").Value;
            //var usePostgres = _configuration.Get<bool>("DataBaseOptions:UsePostgres").Value;

            var useMsSql = false;

            var conectionString = _configuration.GetConnectionString(useMsSql ? MsSqlConnectionStringName : PostgresConnectionStringName);
            if (string.IsNullOrEmpty(conectionString))
            {
                throw new InvalidOperationException($"The connection string '{conectionString}' wasn't found");
            }

            if (!useMsSql)
            {
                options.UseNpgsql(conectionString);
            }
            else
            {
                options.UseSqlServer(conectionString);
            }

            options
                .UseLoggerFactory(_loggerFactory);
        }
    }
}

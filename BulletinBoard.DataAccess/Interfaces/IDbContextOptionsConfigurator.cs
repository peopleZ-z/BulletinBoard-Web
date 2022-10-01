using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.Interfaces
{
    /// <summary>
    /// Interface congigurator.
    /// </summary>
    public interface IDbContextOptionsConfigurator<TContext> where TContext : DbContext
    {
        /// <summary>
        /// Configures the context.
        /// </summary>
        /// <param name="options">options</param>
        void Configure(DbContextOptionsBuilder<TContext> options);
    }
}

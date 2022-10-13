using BulletinBoard.DataAccess.EntityConfigurations.Bulletin;
using BulletinBoard.DataAccess.EntityConfigurations.Category;
using BulletinBoard.DataAccess.EntityConfigurations.Comment;
using BulletinBoard.DataAccess.EntityConfigurations.Photo;
using BulletinBoard.DataAccess.EntityConfigurations.Role;
using BulletinBoard.DataAccess.EntityConfigurations.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess
{
    public class BulletinBoardContext : DbContext
    {
        /// <summary>
        /// Initializes <see cref="BulletinBoardContext"/>
        /// </summary>
        public BulletinBoardContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BulletinConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PhotoConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

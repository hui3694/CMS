using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CMS.Areas.Admin.Models
{
    public class admin
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public DateTime CreateTime { get; set; }

    }

    public class adminDAL : DbContext
    {
        public DbSet<admin> admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>().ToTable("tb_admin");
            base.OnModelCreating(modelBuilder);
        }
    }
}
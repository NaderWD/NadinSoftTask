using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NadinSoftTask.Domain.Models;

namespace NadinSoftTask.Infra.Data.Context
{
    public class NadinTaskDB : DbContext
    {
        public NadinTaskDB(DbContextOptions<NadinTaskDB> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasNoKey();
        }
    }
}


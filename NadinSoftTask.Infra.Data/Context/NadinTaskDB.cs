using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NadinSoftTask.Domain.Models;

namespace NadinSoftTask.Infra.Data.Context
{
    public class NadinTaskDB(DbContextOptions<NadinTaskDB> options) : DbContext(options)
    {
        public virtual DbSet<Product> Products { get; set; }

    }
}


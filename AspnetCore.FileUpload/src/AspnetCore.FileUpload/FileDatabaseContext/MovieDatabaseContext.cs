using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AspnetCore.FileUpload.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetCore.FileUpload.FileDatabaseContext
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}

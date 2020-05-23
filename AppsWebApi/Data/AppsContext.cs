using AppsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsWebApi.Data
{
    public class AppsContext : DbContext
    {
        public AppsContext(DbContextOptions<AppsContext> options) : base(options)
        {
        }

        //Create DbSet property for Task
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}

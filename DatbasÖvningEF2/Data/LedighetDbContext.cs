using DatbasÖvningEF2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DatbasÖvningEF2.Data
{
    public class LedighetDbContext : DbContext
    {
        public DbSet<VacayTable> VacayTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-3V4DD649\\SQLEXPRESS; Initial Catalog=VacationDatabase; Integrated Security=true");
        }
    }
}

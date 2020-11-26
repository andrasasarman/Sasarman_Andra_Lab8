using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sasarman_Andra_Lab8.Models;

namespace Sasarman_Andra_Lab8.Data
{
    public class Sasarman_Andra_Lab8Context : DbContext
    {
        public Sasarman_Andra_Lab8Context (DbContextOptions<Sasarman_Andra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sasarman_Andra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sasarman_Andra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sasarman_Andra_Lab8.Models.Category> Category { get; set; }
    }
}

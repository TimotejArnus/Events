using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dogodki.Models;
using Microsoft.EntityFrameworkCore;


namespace Dogodki.Database
{
    // class for data managment for Dogoek
    public class DogodekContext : DbContext
    {
        public DogodekContext(DbContextOptions<DogodekContext> options) : base(options)
        {
        }

        public DbSet<Dogodek> Dogodki { get; set; }     // Sets Table Dogodki 
    }
}


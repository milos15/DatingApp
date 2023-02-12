using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {

        // Konstruktor - Generisemo konstruktor sa quick fix na DataContext
        // VS ce pogledati sta se nalazi u DbContext klasi i ponuditi opciju za generisanje
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Setovanje korisnika, tip podatka je AppUser, tabela u bazi je Users
        public DbSet<AppUser> Users { get; set; }

        internal object Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
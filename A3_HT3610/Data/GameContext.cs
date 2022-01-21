using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A3_HT3610.Models;

namespace A3_HT3610.Data
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public DbSet<A3_HT3610.Models.Game> Game { get; set; }
    }
}

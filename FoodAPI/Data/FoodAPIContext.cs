using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodAPI.Models;

namespace FoodAPI.Data
{
    public class FoodAPIContext : DbContext
    {
        public FoodAPIContext (DbContextOptions<FoodAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FoodAPI.Models.Food> Food { get; set; } = default!;
    }
}

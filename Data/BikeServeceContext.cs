using Microsoft.EntityFrameworkCore;
using SimpleBikeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Data
{
    public class BikeServeceContext : DbContext
    {
        public BikeServeceContext(DbContextOptions<BikeServeceContext> options) : base(options)
        {

        }

        public DbSet<BikeModel> Bikes { get; set; }
    }
}

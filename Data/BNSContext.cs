using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BNS.Models;

namespace BNS.Data
{
    public class BNSContext : DbContext
    {
        public BNSContext (DbContextOptions<BNSContext> options)
            : base(options)
        {
        }

        public DbSet<BNS.Models.Accounts> Accounts { get; set; }
    }
}

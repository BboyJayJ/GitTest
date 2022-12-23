using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeetJob_Rent.Models;

namespace MeetJob_Rent.Data
{
    public class MeetJob_RentContext : DbContext
    {
        public MeetJob_RentContext (DbContextOptions<MeetJob_RentContext> options)
            : base(options)
        {
        }

        public DbSet<MeetJob_Rent.Models.Movie> Movie { get; set; } = default!;
    }
}

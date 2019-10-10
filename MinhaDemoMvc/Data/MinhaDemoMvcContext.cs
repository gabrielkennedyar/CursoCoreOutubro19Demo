using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MinhaDemoMvc.Models
{
    public class MinhaDemoMvcContext : DbContext
    {
        public MinhaDemoMvcContext (DbContextOptions<MinhaDemoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MinhaDemoMvc.Models.Filme> Filme { get; set; }
    }
}

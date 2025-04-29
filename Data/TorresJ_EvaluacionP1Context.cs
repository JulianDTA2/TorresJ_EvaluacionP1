using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TorresJ_EvaluacionP1.Models;

namespace TorresJ_EvaluacionP1.Data
{
    public class TorresJ_EvaluacionP1Context : DbContext
    {
        public TorresJ_EvaluacionP1Context (DbContextOptions<TorresJ_EvaluacionP1Context> options)
            : base(options)
        {
        }

        public DbSet<TorresJ_EvaluacionP1.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<TorresJ_EvaluacionP1.Models.Reserva> Reserva { get; set; } = default!;
        public DbSet<TorresJ_EvaluacionP1.Models.Recompensas> Recompensas { get; set; } = default!;
    }
}

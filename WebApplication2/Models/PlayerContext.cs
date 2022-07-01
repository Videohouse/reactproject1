using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication2.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Player { get; set; } = null!;
    }
}
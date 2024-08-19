using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticeSwagger.Models
{
	[Table("GameTable")]
	public class GameTable
    {
        [Key]
        public int GameId { get; set; }

        public string GameName { get; set; } = null!;

        public double GamePrice { get; set; }
    }

	public class GameDbContext : DbContext
	{
		public DbSet<GameTable> Games { get; set; }

		public GameDbContext(DbContextOptions options) : base(options)
		{

		}

	}

}

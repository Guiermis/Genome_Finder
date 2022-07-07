using Genome_Finder.Models;
using Microsoft.EntityFrameworkCore;

namespace Genome_Finder.DataLibrary
{
    public class GenomeContext : DbContext
    {
        public DbSet<Base_Nitrogen> Base_Nitrogen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Genome_Finder;Data Source=PC-DE-GUILHERME");
        }
    }
}

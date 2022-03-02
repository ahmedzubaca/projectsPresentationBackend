using Microsoft.EntityFrameworkCore;
using projectsPresentationBackend.Models;

namespace ArchitecturalProjectsBackend.Models
{
    public class ProjectsDbContext : DbContext
    {
        public ProjectsDbContext(DbContextOptions<ProjectsDbContext> options) : base (options)
        {

        }

        public DbSet<Project> ProjectsDb { get; set; }         

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.PopulateTable();
        //}
    }
}

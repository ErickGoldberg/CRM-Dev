using CRM_Dev.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CRM_Dev.Infraestructure.Persistence
{
    public class CRMDevDbContext : DbContext
    {
        public CRMDevDbContext(DbContextOptions<CRMDevDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

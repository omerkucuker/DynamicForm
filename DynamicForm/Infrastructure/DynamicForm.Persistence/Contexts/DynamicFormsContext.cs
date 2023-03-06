using DynamicForm.Domain.Entities;
using DynamicForm.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace DynamicForm.Persistence.Context
{
    public partial class DynamicFormsContext : DbContext
    {
        public DynamicFormsContext(DbContextOptions options) : base(options)
        { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        //}

        public DbSet<Element> Elements { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormElement> Forms_Elements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormElement>()
                .HasKey(bc => new { bc.FormId, bc.ElementId });
            modelBuilder.Entity<FormElement>()
                .HasOne(bc => bc.Form)
                .WithMany(b => b.FormElements)
                .HasForeignKey(bc => bc.FormId);
            modelBuilder.Entity<FormElement>()
                .HasOne(bc => bc.Element)
                .WithMany(c => c.FormElements)
                .HasForeignKey(bc => bc.ElementId);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                 .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.InsertDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

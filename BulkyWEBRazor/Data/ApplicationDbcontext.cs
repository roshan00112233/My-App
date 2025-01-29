using Microsoft.EntityFrameworkCore;

namespace BulkyWEBRazor.Data
{
    public class ApplicationDbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
         new Category { ID = 1, Name = "Action", Displayorder = 1 },
         new Category { ID = 2, Name = "SCifi", Displayorder = 2 },
         new Category { ID = 3, Name = "History", Displayorder = 3 }
         );
        }
}

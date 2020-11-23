namespace ShopServices.Author.Api.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options)
            :base(options)
        {            
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
    }
}
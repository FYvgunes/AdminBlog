using Microsoft.EntityFrameworkCore;

namespace AdminBlog.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            
        }
        public  DbSet<Author> Authors { set; get; }
        public  DbSet<Category> Categories { set; get; }
        public  DbSet<Blog> Blogs { set; get; }

    }
}
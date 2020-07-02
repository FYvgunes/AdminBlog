namespace AdminBlog.Models
{
    public class Blog
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public Author Author { get; set; }
        public int Authorid { get; set; }
        public bool IsPublish { get; set; }
        public Category Category { get; set; }
        public int Categoryid { get; set; }
    
        
        
    }
}
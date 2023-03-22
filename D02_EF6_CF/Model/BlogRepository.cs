using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF.Model
{
    public static class BlogRepository
    {
        

        public static void CreateBlog(BlogContext db) 
        {
            var blog = new Blog { Name = "EF6" };
            db.Blog.Add(blog);
            db.SaveChanges();
        }

        public static void CreatePost(BlogContext db)
        {
            var posts = new List<Post>
              {
            new Post { BlogId = 1, Title = "Title 1", Content = "Content 1" },
            new Post { BlogId = 1, Title = "Title 2", Content = "Content 2" },
            new Post { BlogId = 1, Title = "Title 3", Content = "Content 3" },
              };
            db.Post.AddRange(posts);
            db.SaveChanges();
        }

        public static void ListBlog(BlogContext db)
        {
            var queryBlog = db.Blog.Select(b => b).OrderBy(b => b.Name);
            // linq foreach
            queryBlog.ToList().ForEach(item => Console.WriteLine($"{item.BlogId} - {item.Name}"));
        }

        public static void ListPost(BlogContext db)
        {
            var queryPost = db.Post.Select(b => b).OrderBy(b => b.Title);
            // linq foreach
            queryPost.ToList().ForEach(item => Console.WriteLine($"{item.BlogId} - {item.Title}  - {item.Content}"));
        }

    }
}

using D00_Utility;
using D02_EF6_CF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            var db = new BlogContext(); 

            using (db)
            {
                
                //criar e gravar um novo blog
                Blog blog01 = new Blog();

                //blog01.BlogId = 1; não é preciso pq usando pk o ef sabe que é identity
                blog01.Name = "EF6";
                db.Blog.Add(blog01);
                db.SaveChanges();

                var queryBlog = db.Blog.Select(b => b).OrderBy(b => b.Name);
                // linq foreach
                queryBlog.ToList().ForEach(item => Console.WriteLine($"{item.BlogId} - {item.Name}"));
                
                //criar e gravar um novo post
                Post post01 = new Post();
                Post post02 = new Post();
                Post post03 = new Post();

                //post01.BlogId = 1; não é preciso pq usando pk o ef sabe que é identity
                post01.BlogId = 1;
                post01.Title = "Title 1";
                post01.Content = "Content 1";

                post02.BlogId = 1;
                post02.Title = "Title 1";
                post02.Content = "Content 1";

                post03.BlogId = 1;
                post03.Title = "Title 1";
                post03.Content = "Content 1";

                db.Post.Add(post01);
                db.Post.Add(post02);
                db.Post.Add(post03);
                db.SaveChanges();

                var queryPost = db.Post.Select(b => b).OrderBy(b => b.Title);
                // linq foreach
                queryPost.ToList().ForEach(item => Console.WriteLine($"{item.BlogId} - {item.Title}  - {item.Content}"));

            }

            Utility.TerminateConsole();
        }
    }
}

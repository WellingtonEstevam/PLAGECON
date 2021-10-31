using Plagecon.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plagecon.Models.Repo
{
    public class BlogRepository : IBlogRepository
    {
        private List<BlogPosts> _posts;

        public BlogRepository() => _posts = new List<BlogPosts>()
            {
                new BlogPosts
                {
                    PostId=1,
                    Title = "My First Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                },
                new BlogPosts
                {
                    PostId=2,
                    Title="My Second Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                },
                new BlogPosts
                {
                    PostId=2,
                    Title="My Second Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                }
            };


        public BlogPosts GetPostByID(int postId)
        {
            return _posts.FirstOrDefault(x => x.PostId == postId);
        }
    }
}

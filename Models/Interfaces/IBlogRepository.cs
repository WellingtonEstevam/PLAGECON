using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plagecon.Models.Interfaces
{
    public interface IBlogRepository
    {
        public BlogPosts GetPostByID(int postId);
    }
}

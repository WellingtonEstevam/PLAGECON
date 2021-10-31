using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plagecon.Models
{
    public class BlogPosts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}

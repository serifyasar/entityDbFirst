using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace entityCodeFirst.Models
{
    public class Post
    {

        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
    
        public string Text { get; set; }
        public string Title { get; set; }
        public virtual ICollection<File> Files { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

}
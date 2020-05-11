using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class File
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreatedOn { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public int Size { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu{get; set;}
    }
}

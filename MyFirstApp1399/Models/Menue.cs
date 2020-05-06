using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class Menue
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
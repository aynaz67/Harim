using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class FileTb
    {
        public int Id { get; set; }
        public string TTL { get; set; }
        public string tTX { get; set; }
        public DateTime? RegDte { get; set; }
        public string FileName { get; set; }
        public string FileTyp { get; set; }
        public int? Size { get; set; }    
        public int MenueId { get; set; }
    }
}
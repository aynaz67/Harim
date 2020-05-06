using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class MenueTb
    {
        public int Id { get; set; }
        public int prnt { get; set; }
        public string Ttl { get; set; }
        public string Txt { get; set; }
        public DateTime? RegDte { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.DAL
{
    public class Context : DbContext
    {
        public Context():base()
        {
        }

        public IDbSet<Models.Menu> Menus { get; set; }
        public IDbSet<Models.File> Files { get; set; }
        public IDbSet<Models.Comment> comments { get; set; }
        public IDbSet<Models.Post> Posts { get; set; }

    }
}
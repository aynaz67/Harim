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

        public IDbSet<Models.Menue> Menues { get; set; }
        public IDbSet<Models.File> Files { get; set; }

        public IDbSet<Models.Comment> Comments { get; set; }
    }
}
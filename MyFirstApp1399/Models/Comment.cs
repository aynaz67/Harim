﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp1399.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int MenueId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Opinion { get; set; }

        public virtual Menue Menue { get; set; }
    }
}
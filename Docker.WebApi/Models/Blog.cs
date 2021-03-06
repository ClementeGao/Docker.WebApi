﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.WebApi.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}

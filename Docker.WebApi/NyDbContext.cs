using Docker.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.WebApi
{
    public class NyDbContext:DbContext
    {
        public NyDbContext(DbContextOptions<NyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

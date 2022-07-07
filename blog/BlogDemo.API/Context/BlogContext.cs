using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogDemo.API.Models;

namespace BlogDemo.API.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext (DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<BlogDemo.API.Models.BlogPost>? BlogPost { get; set; }
    }

}
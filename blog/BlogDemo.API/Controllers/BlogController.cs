using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogDemo.API.Models;
using BlogDemo.API.Context;

namespace BlogDemo.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return _context.BlogPost!;
        }

        [HttpGet("{id}")]
        public BlogPost GetOne(int? id)
        {
            if (id == null || _context.BlogPost == null)
                return new BlogPost();

            return _context.BlogPost.Where(c => c.Id == id).SingleOrDefault()!;
        }
    }
}

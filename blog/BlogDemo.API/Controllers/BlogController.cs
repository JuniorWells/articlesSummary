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

        // GET: Blog

        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return _context.BlogPost;
        }

        [HttpGet("{id}")]
        public BlogPost GetOne(int? id)
        {
            if (id == null || _context.BlogPost == null)
                return null;

            return _context.BlogPost.Where(c => c.Id == id).SingleOrDefault();
        }
    }

    //     // POST: Blog/Create
    //     // To protect from overposting attacks, enable the specific properties you want to bind to.
    //     // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //     [HttpPost]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> Create([Bind("Id,Title,Category,Subcategory,Description,AuthorName,AuthorAvatar,CreatedAt,Cover")] BlogPost blogPost)
    //     {
    //         if (ModelState.IsValid)
    //         {
    //             _context.Add(blogPost);
    //             await _context.SaveChangesAsync();
    //             return RedirectToAction(nameof(Index));
    //         }
    //         return View(blogPost);
    //     }
   
    //     // GET: Blog/Delete/5
    //     public async Task<IActionResult> Delete(int? id)
    //     {
    //         if (id == null || _context.BlogPost == null)
    //         {
    //             return NotFound();
    //         }

    //         var blogPost = await _context.BlogPost
    //             .FirstOrDefaultAsync(m => m.Id == id);
    //         if (blogPost == null)
    //         {
    //             return NotFound();
    //         }

    //         return View(blogPost);
    //     }

    //     // POST: Blog/Delete/5
    //     [HttpPost, ActionName("Delete")]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> DeleteConfirmed(int id)
    //     {
    //         if (_context.BlogPost == null)
    //         {
    //             return Problem("Entity set 'BlogContext.BlogPost'  is null.");
    //         }
    //         var blogPost = await _context.BlogPost.FindAsync(id);
    //         if (blogPost != null)
    //         {
    //             _context.BlogPost.Remove(blogPost);
    //         }
            
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(Index));
    //     }

    //     private bool BlogPostExists(int id)
    //     {
    //       return (_context.BlogPost?.Any(e => e.Id == id)).GetValueOrDefault();
    //     }
    // }
}

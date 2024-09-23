using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZingM3p.Models;

namespace ZingM3p.Controllers
{
    public class MusicController : Controller
    {
        private readonly MusicDbContext _context;

        public MusicController(MusicDbContext context)
        {
            _context = context;
        }

        // GET: Music
        public async Task<IActionResult> Index()
        {
            return View(await _context.Music.ToListAsync());
        }

        // GET: Music/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicModel = await _context.Music
                .FirstOrDefaultAsync(m => m.MusicId == id);
            if (musicModel == null)
            {
                return NotFound();
            }

            return View(musicModel);
        }

        // GET: Music/AddOrEdit
        // GET: Music/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new MusicModel());
            else
            {
                var musicModel = await _context.Music.FindAsync(id);
                if (musicModel == null)
                {
                    return NotFound();
                }
                return View(musicModel);
            }
        }

        // POST: Music/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("MusicId,MusicName,ArtistName,Type,Date,Duration,Views")] MusicModel musicModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    musicModel.Date = DateTime.Now;
                    _context.Add(musicModel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(musicModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MusicModelExists(musicModel.MusicId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Music.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", musicModel) });
        }

        // POST: Music/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musicModel = await _context.Music.FindAsync(id);
            _context.Music.Remove(musicModel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Music.ToList()) });
        }

        private bool MusicModelExists(int id)
        {
            return _context.Music.Any(e => e.MusicId == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playlists.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlists.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly MusicDataContext _context;

        public PlaylistController(MusicDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var music = await _context.PlayList.Where(p => p.Removed == false).ToListAsync();
            return View(music);
        }

        [HttpPost]
        public async Task<ActionResult> IncrementPlayList(int id)
        {
            await Task.Delay(750);
            var song = await _context.PlayList.SingleOrDefaultAsync(p => p.Id == id);
            if(song == null)
            {
                return NotFound();
            } else
            {
                song.PlayCount += 1;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }


    }
}

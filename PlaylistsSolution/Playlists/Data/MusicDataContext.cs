using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlists.Data
{
    public class MusicDataContext : DbContext
    {
        public MusicDataContext(DbContextOptions<MusicDataContext> options):base(options)
        {

        }

        public DbSet<PlayListItem> PlayList { get; set; }

       
    }
}

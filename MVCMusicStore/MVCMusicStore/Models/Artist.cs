using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public int Name { get; set; }
        public virtual List<Album> Albums { get; set; }


    }
}
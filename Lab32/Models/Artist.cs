using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab32.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public virtual ICollection<Cd> Cd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab32.Models
{
    public class Cd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}

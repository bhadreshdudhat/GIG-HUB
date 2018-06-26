using GIG_HUB.Models;
using System.Collections.Generic;

namespace GIG_HUB.ViewModels
{
    public class GigsFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}
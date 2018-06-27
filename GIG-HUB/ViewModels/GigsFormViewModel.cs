using GIG_HUB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GIG_HUB.ViewModels
{
    public class GigsFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        //reflection will check all fields & properties so, DateTime will give FormateException 
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}
﻿using GIG_HUB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GIG_HUB.ViewModels
{
    public class GigsFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string Heading { get; set; }

        public string Action
        {
            get
            {
                return (Id != 0) ? "Update" : "Create";
            }

        }

        //reflection will check all fields & properties so, DateTime will give FormateException 
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}
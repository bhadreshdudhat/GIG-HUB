﻿using GIG_HUB.Models;
using GIG_HUB.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GIG_HUB.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigsFormViewModel() { Genres = _context.Genres.ToList() };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigsFormViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == artistId);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);
            var gig = new Gig
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venue = viewModel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
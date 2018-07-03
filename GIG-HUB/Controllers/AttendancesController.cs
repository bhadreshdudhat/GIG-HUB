﻿using GIG_HUB.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GIG_HUB.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int gigId)
        {
            var userId = User.Identity.GetUserId();

            //if attandance is already present
            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == gigId))
                return BadRequest("Attendance is already exists.");

            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return Ok();
        }
    }
}

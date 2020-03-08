using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelBookingPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly WdaContext _context;

        public HomeController (WdaContext context)
        {
            this._context = context;
        }



        public IActionResult Index()
        {
            var allCities = _context.Room.Select(room => room.City).Distinct().ToArray();
            var allRoomTypes = _context.RoomType
                .Select(x => Tuple.Create(x.Id, x.RoomType1)).ToArray();

            var model = new HotelBookingPlatform.Models.SearchFiltersModel
            {
                Cities = allCities,
                RoomTypes = allRoomTypes
            };

            return View(model);
        }

        public IActionResult Details(int roomId)
        {
            var result = _context.Room.Find(roomId);
            return View(result);
        }

        public IActionResult List()
        {

            return View(_context.Room.ToArray());
        }


        [HttpGet("{city}/")]
        public IActionResult List(string city)
        {
            return View(_context.Room.Where(room => room.City == city).ToArray());
        }
  
        public IActionResult Profile()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

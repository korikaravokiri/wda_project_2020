using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingPlatform.Models

{
    public class SearchFiltersModel
    {
        public string[] Cities { get; set; }
        public Tuple<int, string>[] RoomTypes { get; set; }
    }
}
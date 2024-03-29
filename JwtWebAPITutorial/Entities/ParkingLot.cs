﻿using System;
using System.Collections.Generic;

namespace JwtWebAPITutorial.Entities
{
    public partial class ParkingLot
    {
        public ParkingLot()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? ManagerName { get; set; }
        public string? ParkingLotImg { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}

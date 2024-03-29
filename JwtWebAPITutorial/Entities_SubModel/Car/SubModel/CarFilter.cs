﻿using System.Diagnostics.CodeAnalysis;

namespace JwtWebAPITutorial.Entities_SubModel.Car.SubModel
{
    public class CarFilter
    {
        [AllowNull]
        public int? CarStatusId { get; set; }

        [AllowNull]
        public string? CarLicensePlates { get; set; }

        [AllowNull]
        public int? SeatNumber { get; set; }

        [AllowNull]
        public string? CarMakeName { get; set; }
        [AllowNull]
        public string? CarModelId { get; set; }
        [AllowNull]
        public string? CarColor { get; set;}
    }
}

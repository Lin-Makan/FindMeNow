using System;
using System.Collections.Generic;
using System.Text;

namespace FindMeNow.Models
{
    public class Location
    {
        public Location() { }
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public int IdPrimaryKeyAttributeAutoIncrementAttribute { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

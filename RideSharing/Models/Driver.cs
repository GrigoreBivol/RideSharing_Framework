﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RideSharing.Models
{
    public class Driver
    {
        public Driver()
        {
            Online = false;
            OnRide = false;
        }


        [Key]
        public int DriverId { get; set; }
        public string DriverIdentity { get; set; }
        public string Name { get; set; }
        public bool Online { get; set; }
        public bool OnRide { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }

    }
}
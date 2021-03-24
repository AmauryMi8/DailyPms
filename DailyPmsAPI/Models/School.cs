﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DailyPmsAPI.Models
{
    public class School
    {
        public string SchoolId { get; set; }

        public string Name { get; set; }

        public string Moniker { get; set; }

        public string Street { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string DirectorName { get; set; }

        public string PmsCenterID { get; set; }

        public List<string> ClasseIDs { get; set; }

        public List<string> StudentIDs { get; set; }
    }
}

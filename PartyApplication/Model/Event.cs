﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyApplication.Model
{
    public class Event
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty(PropertyName = "timecreated")]
        public DateTime TimeCreated { get; set; }

        [JsonProperty(PropertyName = "hostusername")]
        public string HostUsername { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; }

        [JsonProperty(PropertyName = "numratings")]

        public int NumRatings { get; set; }

        [JsonProperty(PropertyName ="totalratings")]

        public double TotalRatings { get; set; }
    }
}

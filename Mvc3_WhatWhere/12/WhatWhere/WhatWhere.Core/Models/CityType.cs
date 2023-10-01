using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatWhere.Core.Models
{
    public class CityType
    {
        [JsonPropertyName("il")]
        public string Il { get; set; }

        [JsonPropertyName("plaka")]
        public int Plaka { get; set; }

        [JsonPropertyName("ilceleri")]
        public List<string> Ilceleri { get; set; }

    }
}

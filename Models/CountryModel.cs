﻿using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Models
{
    public class CountryModel
    {
        
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
    }
}

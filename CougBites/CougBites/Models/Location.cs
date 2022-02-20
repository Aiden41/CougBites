using System;
using System.Collections.Generic;
using System.Text;

namespace CougBites.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //Picture
        //Hours of Operation
        public FoodItem[] FoodItems { get; set; }
        public string Menu { get; set; }
    }
}

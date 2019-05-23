using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CognitiveTask.Models
{
    public class campaign
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public int budget { get; set; }
        public string goal { get; set; }
        public string category { get; set; }

    }
}
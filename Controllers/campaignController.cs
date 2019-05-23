using CognitiveTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
//using System.Web.Mvc;
using System.Web.Helpers;

namespace CognitiveTask.Controllers
{
    [Route("api/campaign")]
    public class campaignController : ApiController
    {        
        private List<campaign> _campinfo;
        // GET api/<controller>
        public campaignController()
        {
            Initializedata();
        }

        private void Initializedata()
        {
            //providing the example, remove when adding the database
            _campinfo = new List<campaign>();
            var camp1 = new campaign();
            camp1.id = 1;
            camp1.name = "n1";
            camp1.country = "USA";
            camp1.budget = 149;
            camp1.goal = "Awareness";
            camp1.category = "Technology";
            
            var camp2 = new campaign();
            camp1.name = "n1";
            camp2.id = 2;
            camp2.country = "USA";
            camp2.budget = 149;
            camp2.goal = "Awareness";
            camp2.category = "Sports";

            var camp3 = new campaign();
            camp3.name = "n3";
            camp3.id = 3;
            camp3.country = "EGY";
            camp3.budget = 149;
            camp3.goal = "Awareness";
            camp3.category = "Technology";

            var camp4 = new campaign();
            camp4.name = "n4";
            camp4.id = 4;
            camp4.country = "USA";
            camp4.budget = 149;
            camp4.goal = "Awareness";
            camp4.category = "Sports";

            var camp5 = new campaign();
            camp5.name = "n5";
            camp5.id = 5;
            camp5.country = "USA";
            camp5.budget = 149;
            camp5.goal = "Conversion";
            camp5.category = "Sports";

            _campinfo.Add(camp5);
            _campinfo.Add(camp4);
            _campinfo.Add(camp3);
            _campinfo.Add(camp2);
            _campinfo.Add(camp1);

        }

        [HttpGet]
        public IEnumerable<campaign> GetAll()
        {
            return _campinfo;
        }

        
        [HttpPost]
        public IHttpActionResult Post(campaign campost)
        {
            _campinfo.Add(campost);
            return Ok();
        }

        public IHttpActionResult CharterHelp()

        {
            var countries = _campinfo.Select(o => o.country);
            var categories = _campinfo.Select(o => o.category);
            new Chart(width: 500, height: 300)

            .AddTitle("Analysis By country and Category")

                 .AddSeries(chartType: "column",

                   xValue: new[] { countries },

                     yValues: new[] { categories })

                   .Write("bmp");

            return null;
        }

        }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CognitiveTask.Models
{   
        public interface Icampaignrepo
        {
            IEnumerable<campaign> GetAll();
            void Add(campaign info);
        }    
}
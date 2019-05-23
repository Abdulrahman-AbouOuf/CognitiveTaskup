using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CognitiveTask.Models
{
    public class campaignrepo : Icampaignrepo
    {
        private static ConcurrentDictionary<string, campaign> campinfo = new ConcurrentDictionary<string, campaign>();
        public void Add(campaign info)
        {
            campinfo[info.id.ToString()] = info;
        }

        public IEnumerable<campaign> GetAll()
        {
            return campinfo.Values;
        }
    }
}
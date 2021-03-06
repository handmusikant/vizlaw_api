﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VizLaw_api.Data;
using VizLaw_api.DataAccess;

namespace VizLaw_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SearchController : ApiController
    {
        // GET api/values
        
       

        // GET api/values/5
        [HttpGet]
        public IEnumerable<CourtDecision> searchDecisions(string searchQuery)
        {
            //if (CitationNetwork.Citations == null || CitationNetwork.Citations.Count() == 0)
            //    CitationNetwork.LoadCitationNetwork();
            //82520

            //return CitationNetwork.Citations.Where(c => c.to_id==id.ToString());
            return             new List<CourtDecision> { OpenLegalDb.getCourtDecision("82520") };

        }

        public CourtDecision getCourtDecision(string DecisionId)
        {
            //if (CitationNetwork.Citations == null || CitationNetwork.Citations.Count() == 0)
            //    CitationNetwork.LoadCitationNetwork();

            return OpenLegalDb.getCourtDecision(DecisionId);
        }


    }
}

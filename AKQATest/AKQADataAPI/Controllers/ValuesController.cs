using AKQADataAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AKQADataAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        WordConverter wordConverter = new WordConverter();
       
        [HttpGet]
        [Route("api/Values/Get")]
        public  IHttpActionResult Get(string number)
        {
            return  Ok(new { Word = wordConverter.ValidateNumber(number) });
        }

       
    }
}

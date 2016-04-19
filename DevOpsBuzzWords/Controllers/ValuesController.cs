using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using DevOpsBuzzWords.Models;

namespace DevOpsBuzzWords.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        public SlackResponse Get()
        {
            var words = new string[] { "We need more Big data", "Containers!!!", "Scale more", "We need Innovation", "What about Quantum Computing?", "Agile it", "Lean Enterprise", "Innovate", "You only fail when you fail to learn", "Do the right thing it is as important as doing the thing right", "Microservices!", "Woman in code", "What is devops?" };
            var rand = new Random();

            var word = words[rand.Next(0, words.Length)];

            var result = new SlackResponse()
            {
                response_type = "in_channel",
                text = word
            };

            return result;
        }

        //// GET api/values/5
        //[SwaggerOperation("GetById")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[SwaggerOperation("Create")]
        //[SwaggerResponse(HttpStatusCode.Created)]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[SwaggerOperation("Update")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[SwaggerOperation("Delete")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public void Delete(int id)
        //{
        //}
    }
}

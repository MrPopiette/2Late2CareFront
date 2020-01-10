using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;

namespace _2Late2CareFront.Controllers
{
    public class TicketController : ApiController
    {
        // GET api/<controller>

        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("<div>Hello World</div>");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            StringBuilder sbr = new StringBuilder();
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("fr-FR");
            sbr.Append("ticket  : ");
            sbr.Append(id);
            sbr.AppendLine();
            sbr.Append(culture.NativeName);
            sbr.AppendLine();
            sbr.Append(localDate.ToString(culture));
            return sbr.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
using AirVinyl.DataAccessLayer;
using AirVinyl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;
using AirVinyl.API.Helpers;
using System.Web.Http.Cors;

namespace AirVinyl.API.Controllers
{
    /* 63342 */
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class TicketController : ODataController
    {

        private OracleDbContext _ctx = new OracleDbContext();

        [EnableQuery]
        public IHttpActionResult Get()
        {
            return Ok(_ctx.Ticket);
        }


        [HttpGet]
        [ODataRoute("Ticket({key})/Received_By")]
        [ODataRoute("Ticket({key})/Assigned_To")]
        public IHttpActionResult GetPersonPropery([FromODataUri] int key)
        {
            var ticket = _ctx.Ticket.FirstOrDefault(p => p.Ticket_Key == key);

            if (ticket == null)
            {
                return NotFound();
            }

            var propertyToGet = Url.Request.RequestUri.Segments.Last();

            if (!ticket.HasProperty(propertyToGet))
            {
                return NotFound();
            }

            var propertyValue = ticket.GetValue(propertyToGet);

            if (propertyValue == null)
            {
                return StatusCode(System.Net.HttpStatusCode.NoContent);
            }

            return this.CreateOKHttpActionResult(propertyValue);

        }

        [EnableQuery]
        public IHttpActionResult Get([FromODataUri] int key)
        {
            //var ticket = _ctx.Ticket.FirstOrDefault(r => r.Ticket_Key == key);

            //if (ticket == null)
            //{
            //    return NotFound();
            //}
            //return Ok(ticket);


            var ticket = _ctx.Ticket.Where(r => r.Ticket_Key == key);
            if (!ticket.Any())
            {
                return NotFound();
            }

            return Ok(SingleResult.Create(ticket));

        }



        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }
    }


}

using AirVinyl.DataAccessLayer;
using AirVinyl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using System.Web.Http.Cors;

namespace AirVinyl.API.Controllers
{
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*" )]
    public class ConfigController : ODataController
    {
        private OracleDbContext _ctx = new OracleDbContext();

        public IHttpActionResult Get()
        {
            return Ok(_ctx.Config);
        }


        public IHttpActionResult Get([FromODataUri] int key)
        {
            var flag = _ctx.Config.FirstOrDefault(r => r.KEY == key);

            if (flag == null)
            {
                return NotFound();
            }

            return Ok(flag);
        }

        public IHttpActionResult Post(CONFIG c)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _ctx.Config.Add(c);
            _ctx.SaveChanges();


            return Created(c);

        }


        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }

    }
}
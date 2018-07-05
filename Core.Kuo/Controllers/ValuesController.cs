using System.Collections.Generic;
using System.Data;
using Core.Kuo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core.Kuo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        public List<Country> Get()
        {
            //var a = HttpContext.RequestServices.GetService(typeof(Connection));
            var aaa = new BaseService();
            var bbb = aaa.Query("select * from country");
            var list = new List<Country>();
            foreach (DataRow dr in bbb.Rows)
            {
                list.Add(new Country
                {
                    Id = (string)dr["id"],
                    Name = (string)dr["name"],
                    Land = (string)dr["land"],
                    Area = (string)dr["area"]
                });
            }
            return list;
            //return new string[] { "value1", "value2", Connection.GetConnectionString().ConnectionString };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

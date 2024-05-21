using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test2WebAPI_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        // GET: api/<ReportController>
        [HttpGet]
        public string Get()
        {
            var api = new APITest();
            var result = api.GetData();
            
            return JsonConvert.SerializeObject(result);
        }

            // GET api/<ReportController>/5
            [HttpGet("{id}")]
        public string Get(int id)
        {
            var api = new APITest();
            var result = api.GetData();
            //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            //Dictionary<string, object> obj;
            //foreach (DataRow dr in result.Rows)
            //{
            //    obj = new Dictionary<string, object>();
            //    foreach (DataColumn col in result.Columns)
            //    {
            //        obj.Add(col.ColumnName, dr[col]);
            //    }
            //    rows.Add(obj);
            //}
            //return serializer.Serialize(rows);
            return JsonConvert.SerializeObject(result);
        }

        // POST api/<ReportController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReportController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReportController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOVA.Controllers
{
    [Route("Framework")]
    public class FrameworkController : Controller
    {
        [HttpGet]
        public String  Get()
        {
            NpgsqlConnection connection = new NpgsqlConnection(DBConnect.connectionString);
            connection.Open();

            NpgsqlCommand test = new NpgsqlCommand("SELECT * FROM words;");
            test.Connection = connection;
            var result = test.ExecuteScalar().ToString();

            connection.Close();
            return result;
        }

      /*  // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}

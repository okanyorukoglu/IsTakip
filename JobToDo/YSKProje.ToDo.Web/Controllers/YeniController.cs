using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using YSKProje.ToDo.Web.Models;

namespace YSKProje.ToDo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YeniController : ControllerBase
    {
        public YeniController()
        {
        }

        // GET api/yeni
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> { };
        }

        // GET api/yeni/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/yeni
        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        // PUT api/yeni/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/yeni/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}
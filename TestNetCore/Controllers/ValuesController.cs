using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.Model;


namespace TestNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //public interface ICategoryService
        //{
        //    Task<IEnumerable<pgUser>> ListAsync();
        //}

        //private readonly ICategoryService _userService;

        //public ValuesController(ICategoryService userService)
        //{
        //    _userService = userService;
        //}

        //[HttpGet]
        //public async Task<IEnumerable<pgUser>> GetAllUserAsync()
        //{
        //    var dataUser = await _userService.ListAsync();
        //    return dataUser;
        //}


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "" };
            //var dataUser = await _userService.ListAsync();
            //return dataUser;
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

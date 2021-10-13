using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.Model;
using Microsoft.EntityFrameworkCore;
 
namespace TestNetCore.Controllers
{
    
    [Route("/api/[controller]")]
    public class userController : ControllerBase
    {
        private readonly MyWebApi _context;

        public userController(MyWebApi context)
        {
            _context = context;
           
        }
       

        
        [HttpGet]
        public ActionResult<IEnumerable<pgUser>> Get()
        {
            List<pgUser> list = new List<pgUser>() {
                 new pgUser {
                     page = 1,
                     pageSize  = 2,
                     totalPage =3,
                     totalApa ="Ga tau nih",
                     data = _context.mfnuser.ToList()
                 }
            };
            return list;
        }
        

    }
}

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
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<pgUser>> Get()
        {
            List<pgUser> list = new List<pgUser>() {
                 new pgUser {
                     page = 1,
                     pageSize  = 2,
                     totalPage =3,
                     totalApa ="Ga tau nih",
                     data = new List<ModUser>()
                        {
                            new ModUser
                            {
                                username = "Member1",
                                password = "******"
                            },
                            new ModUser{
                                username = "Member2",
                                password = "********"
                            }
                        }


                }
            };
            return list;
        }
    }
}

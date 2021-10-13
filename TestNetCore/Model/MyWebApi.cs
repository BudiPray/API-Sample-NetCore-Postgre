using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace TestNetCore.Model
{
    public class MyWebApi : DbContext
    {
        public MyWebApi(DbContextOptions<MyWebApi> options) : base(options) { }
        public DbSet<mfn_user> mfnuser { get; set; }
    }

  

}

using blogging.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace blogging.models
{
    public static class ModelBuilderExtension
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<story>().HasData(

               new story
               {
                   Id = 1,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               },
               new story
               {
                   Id = 2,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               },
               new story
               {
                   Id = 3,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               },
               new story
               {
                   Id = 4,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               },
               new story
               {
                   Id = 5,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               },
               new story
               {
                   Id = 6,
                   title = "blogging",
                   body = "cdsgrsdg",
                   status = stat.@public,
                   userId = "vfg@gmial.com",
                   createdat = DateTime.Now,
               }


             );
        }
    }
}

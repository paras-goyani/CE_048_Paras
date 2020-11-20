using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace blogging.Models
{
    public class user
    {
        public int Id { get; set; }

        public string displayname { get; set; }

        public string firstname { get; set; }

        public  string lastname { get; set; }

        public  IFormFile image { get; set; }

        public DateTime createdat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public class Users
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        [Key]
        public string email { get; set; }
        public string password { get; set; }
        public string photopath { get; set; }
    }
}

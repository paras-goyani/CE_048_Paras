using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.viewmodels
{
    public class UserCreateViewModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        [Key]
        public string email { get; set; }
        public string password { get; set; }
        public string repassword { get; set; }
        public IFormFile photo { get; set; }
    }
}

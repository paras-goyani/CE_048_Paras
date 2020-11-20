using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models.viewmodel
{
    public class loginviewmodel
    {
        public string returnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogin { get; set; }
    }
}

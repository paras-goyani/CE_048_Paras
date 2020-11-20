using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public interface Iuserreposetory
    {
        public void add(Users model);
        public Users fetch(string email);

        IEnumerable<Users> GetUsers();
    }
}

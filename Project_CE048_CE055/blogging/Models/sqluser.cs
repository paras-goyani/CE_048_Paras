using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public class sqluser : Iuserreposetory
    {
        public AppDbContext context;
        public sqluser(AppDbContext cont)
        {
            context = cont;
        }
        public void add(Users model)
        {
            context.users.Add(model);
            context.SaveChanges();
        }

        public Users fetch(string email)
        {
            return context.users.Find(email);
        }

        public IEnumerable<Users> GetUsers()
        {
            return context.users;
        }
    }
}

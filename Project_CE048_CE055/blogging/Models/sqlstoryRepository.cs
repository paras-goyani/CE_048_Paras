using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public class sqlstoryRepository : IstoryRepository
    {
        private AppDbContext context;

        public sqlstoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public story Add(story st)
        {
            context.stories.Add(st);
            context.SaveChanges();
            return st;
        }

        public story Delete(int id)
        {

            story st = context.stories.Find(id);

            if (st != null)
            {
                context.stories.Remove(st);
                context.SaveChanges();
            }

            return st;
        }

        public IEnumerable<story> GetAllstory()
        {
            return context.stories;
        }


        public IEnumerable<story> GetAllstorybyuser(string email)
        {
            var stories = from s in context.stories
                           select s;
            stories = stories.Where(s => s.userId == email);
            return stories;
        }
        public story Getstory(int Id)
        {
            return context.stories.Find(Id);
        }

        public story Update(story stchanges)
        {
            var sto = context.stories.FirstOrDefault(s => s.Id == stchanges.Id);

            sto.title = stchanges.title;
            sto.body = stchanges.body;
            sto.status = stchanges.status;


            context.SaveChanges();
            return stchanges;
        }
    }
}

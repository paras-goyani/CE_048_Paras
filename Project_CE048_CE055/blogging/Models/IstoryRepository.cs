using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public interface IstoryRepository
    {
        story Getstory(int Id);

        IEnumerable<story> GetAllstory();

        IEnumerable<story> GetAllstorybyuser(string email);

        story Add(story st);

        story Delete(int id);

        story Update(story st);
    }
}

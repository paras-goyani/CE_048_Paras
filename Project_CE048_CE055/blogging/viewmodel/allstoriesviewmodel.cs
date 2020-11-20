using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models.viewmodel
{
    public class allstoriesviewmodel
    {
        public IEnumerable<story> allstories { get; set; }

        public string title { get; set; }
    }
}

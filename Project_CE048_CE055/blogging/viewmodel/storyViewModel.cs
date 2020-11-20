using blogging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.viewmodel
{
    public class storyViewModel : story
    {
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }
        public string photopath { get; set; }

        public string st { get; set; }
        public IEnumerable<story> stories { get; set; }
    }
}

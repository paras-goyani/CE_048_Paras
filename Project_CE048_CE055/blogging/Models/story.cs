using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blogging.Models
{
    public class story
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string title { get; set; }

        public string body { get; set; }

        public stat status { get; set; }

        public string userId { get; set; }

        public DateTime createdat { get; set; }
    }
}

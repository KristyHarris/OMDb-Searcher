using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMDb_Searcher.Models
{
    public class Search
    {
        [Required]
        public string SearchTerm { get; set; }

       
        public string Type { get; set; }

        public IEnumerable<Movie> Results { get; set; }

    }
}

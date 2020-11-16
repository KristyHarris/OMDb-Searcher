using OMDb_Searcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMDb_Searcher.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<Movie>> Get(string searchTerm, string type);

    }
}

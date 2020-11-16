using OMDb_Searcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace OMDb_Searcher.Services
{
    public class ApiSearchService : ISearchService
    {
        private readonly HttpClient _client;

        public ApiSearchService(HttpClient client)
        {
            _client = client;

        }

        public async Task<IEnumerable<Movie>> Get(string searchTerm, string type)
        {
            string query;

            if(type == "Movie")
            {
                query = $"?s={searchTerm}&type=movie&apikey=1928d26";
            }

            if(type == "TV Series")
            {
                query = $"?s={searchTerm}&type=series&apikey=1928d26";
            }
            else
            {
                query = $"?s={searchTerm}&apikey=1928d26";
            }
            var response = await _client.GetFromJsonAsync<Search>($"{query}");
            return response.Results;
        }
    }

}





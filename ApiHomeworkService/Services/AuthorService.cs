using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkService.Interfaces;

namespace ApiHomeworkService.Services
{
    public class AuthorService : IAuthor
    {
        private IAuthorRepo _authorRepo;
        public AuthorService(IAuthorRepo authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public Task CreateAuthor(string fullName, string country)
        {
            if(country == "Great Britain")
            {
                Console.WriteLine("This section doesn't contain Britith authors' books");
                return Task.CompletedTask;
            }
            else
            {
                return _authorRepo.CreateAuthor(fullName, country);

            }
        }

        public List<Author> GetAuthors()
        {
            return _authorRepo.GetAuthors();    
        }
    }
}

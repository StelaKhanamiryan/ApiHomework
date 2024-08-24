using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkService.Interfaces;

namespace ApiHomeworkService.Services
{
    public class BookService : IBook
    {
        IBookRepo _bookRepo;
        public BookService(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }
        public Task CreateBook(string title, string genre)
        {
            if(genre == "Detective")
            {
                Console.WriteLine("This section doesn't contain detective books");
                return Task.CompletedTask;
            }
            else
            { 
                return _bookRepo.CreateBook(title, genre);
            }         
        }

        public List<Book> GetBooks()
        {
            return _bookRepo.GetBooks();
        }
    }
}

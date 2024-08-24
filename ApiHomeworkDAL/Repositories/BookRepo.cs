using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;

namespace ApiHomeworkDAL.Repositories;

public class BookRepo : IBookRepo
{
    private BookDbContext _context;
    public BookRepo(BookDbContext bookDbContext)
    {
        _context = bookDbContext;
    }
    public Task CreateBook(string title, string genre)
    {
        Book newBook = new Book()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Genre = genre
        };
        _context.Add(newBook);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public List<Book> GetBooks()
    {
        return _context.Books.ToList();
    }
}


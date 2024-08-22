using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;

namespace ApiHomeworkDAL.Repositories;

public class AuthorRepo : IAuthorRepo
{
    private BookDbContext _context;
    public AuthorRepo(BookDbContext bookDbContext)
    {
        _context = bookDbContext;
    }

    public void CreateAuthor(string fullName, string country)
    {
        Author newAuthor = new Author()
        {
            Id = Guid.NewGuid(),
            FullName = fullName,
            Country = country
        };
        _context.Add(newAuthor);
        _context.SaveChanges();
    }

    public List<Author> GetAuthors()
    {
        return _context.Authors.ToList();
    }
}

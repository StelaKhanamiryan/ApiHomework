using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;

namespace ApiHomeworkDAL.Repositories;

public class GenreRepo : IGenreRepo
{
    private BookDbContext _context;
    public GenreRepo(BookDbContext bookDbContext)
    {
        _context = bookDbContext;
    }
    public void CreateGenre(string genreName, string description)
    {
        Genre newGenre = new Genre()
        {
            Id = Guid.NewGuid(),
            GenreName = genreName,
            Description = description
        };
        _context.Add(newGenre);
        _context.SaveChanges();
    }

    public List<Genre> GetGenres()
    {
        return _context.Genres.ToList();
    }
}

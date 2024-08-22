using ApiHomeworkDAL.Interfaces;
using ApiHomeworkDAL;
using Microsoft.AspNetCore.Mvc;
using ApiHomeworkDAL.Entities;

namespace ApiHomework.Controllers;
[ApiController]
[Route("[Controller]")]
public class GenreController : Controller
{
    private BookDbContext dbContext;
    private IGenreRepo _genreRepo;
    public GenreController(BookDbContext bookDbContext, IGenreRepo genreRepo)
    {
        dbContext = bookDbContext;
        _genreRepo = genreRepo;
    }
    [HttpGet("GetGenres")]
    public List<Genre> GetGenres()
    {
        return _genreRepo.GetGenres();
    }
    [HttpPost("CreateGenre")]
    public void CreateGenre(string genreName, string description)
    {
        _genreRepo.CreateGenre(genreName, description);
    }
}

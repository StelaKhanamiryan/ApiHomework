using ApiHomeworkDAL;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHomework.Controllers;
[ApiController]
[Route("[Controller]")]
public class AuthorController : Controller
{
    private BookDbContext dbContext;
    private IAuthorRepo _authorRepo;
    public AuthorController(BookDbContext bookDbContext, IAuthorRepo authorRepo)
    {
        dbContext = bookDbContext;
        _authorRepo = authorRepo;
    }
    [HttpGet("GetAuthor")]
    public List<Author> GetAuthors()
    {
        return _authorRepo.GetAuthors();
    }
    [HttpPost("CreateAuthor")]
    public void CreateAuthor(string fullName, string country)
    {
        _authorRepo.CreateAuthor(fullName, country);
    }
}

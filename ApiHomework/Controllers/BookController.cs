using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkDAL;
using Microsoft.AspNetCore.Mvc;

namespace ApiHomework.Controllers;

[ApiController]
[Route("[Controller]")]
public class BookController : Controller
{
    private BookDbContext dbContext;
    private IBookRepo _bookRepo;
    public BookController(BookDbContext bookDbContext, IBookRepo bookRepo)
    {
        dbContext = bookDbContext;
        _bookRepo = bookRepo;
    }
    [HttpGet("GetBooks")]
    public List<Book> GetBooks()
    {
        return _bookRepo.GetBooks();
    }
    [HttpPost("CreateBook")]
    public Task CreateBook(string title, string genre)
    {
        _bookRepo.CreateBook(title, genre);
        return Task.CompletedTask;
    }
}


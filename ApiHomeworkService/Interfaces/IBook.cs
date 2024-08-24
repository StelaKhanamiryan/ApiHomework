using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkService.Interfaces;

public interface IBook
{
    public List<Book> GetBooks();
    public Task CreateBook(string title, string genre);
}

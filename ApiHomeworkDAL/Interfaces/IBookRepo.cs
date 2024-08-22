using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkDAL.Interfaces;

public interface IBookRepo
{
    public List<Book> GetBooks();
    public string CreateBook(string title, string genre);
}


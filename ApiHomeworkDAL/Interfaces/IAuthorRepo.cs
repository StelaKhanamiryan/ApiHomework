using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkDAL.Interfaces;

public interface IAuthorRepo
{
    public List<Author> GetAuthors();
    public Task CreateAuthor(string fullName, string country);
}


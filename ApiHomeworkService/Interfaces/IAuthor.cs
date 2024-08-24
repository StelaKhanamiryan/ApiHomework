using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkService.Interfaces;


public interface IAuthor
{
    public List<Author> GetAuthors();
    public Task CreateAuthor(string fullName, string country);
}
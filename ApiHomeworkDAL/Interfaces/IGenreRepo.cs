using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkDAL.Interfaces;

public interface IGenreRepo
{
    public List<Genre> GetGenres();
    public void CreateGenre(string genreName, string description);
}

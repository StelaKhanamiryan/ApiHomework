using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHomeworkDAL.Entities;

public class Author
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Country { get; set; }
}


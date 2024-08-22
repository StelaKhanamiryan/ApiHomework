using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiHomeworkDAL;

public class BookDbContext :DbContext
{
    public BookDbContext()
    {
        
    }
    public BookDbContext(DbContextOptions<BookDbContext> contextOptions)
        :base(contextOptions)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@" Server = (localdb)\MSSQLLocalDB; Database = BookDb");
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }

}

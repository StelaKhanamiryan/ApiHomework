using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiHomeworkDAL;

public class PersonalDbContext : DbContext
{
    public PersonalDbContext()
    {
        
    }
    public PersonalDbContext(DbContextOptions<PersonalDbContext> contextOptions)
        :base(contextOptions)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = PersonalInfoDb");
    }
    public DbSet<Address> Addresses { get; set; }
}

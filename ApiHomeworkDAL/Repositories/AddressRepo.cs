using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;

namespace ApiHomeworkDAL.Repositories;

public class AddressRepo : IAddressRepo
{
    private PersonalDbContext _context;
    public AddressRepo(PersonalDbContext personalDbContext)
    {
        _context = personalDbContext;
    }
    public Task CreateAddress(string country, string city, string street, string homeNumber)
    {
        Address newAddress = new Address()
        {
            Country = country,
            City = city,
            Street = street,  
            HomeNumber = homeNumber
        };
        _context.Addresses.Add(newAddress);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public List<Address> GetAddress()
    {
        return _context.Addresses.ToList();
    }

    public Task UpdateAddress(string street)
    {
        var updatedData = _context.Addresses.FirstOrDefault();
        updatedData.Street = street;
        _context.Addresses.Update(updatedData);
        _context.SaveChanges();
        return Task.CompletedTask;
    }
}

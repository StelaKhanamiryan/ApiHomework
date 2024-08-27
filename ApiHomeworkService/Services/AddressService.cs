using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkService.Interfaces;

namespace ApiHomeworkService.Services;

public class AddressService : IAddressService
{
    IAddressRepo _addressRepo;
    public AddressService(IAddressRepo addressRepo)
    {
        _addressRepo = addressRepo;
    }
    public Task CreateAddress(string country, string city, string street, string homeNumber)
    {
        _addressRepo.CreateAddress(country, city, street, homeNumber);
        return Task.CompletedTask;
    }

    public List<Address> GetAddress()
    {
        return _addressRepo.GetAddress();
    }

    public Task UpdateAddress(string street)
    {
        _addressRepo.UpdateAddress(street);
        return Task.CompletedTask;
    }
}

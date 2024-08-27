using ApiHomework.Models;
using ApiHomeworkDAL;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHomework.Controllers;

[ApiController]
[Route("API")]
public class AddressController : Controller
{
    private PersonalDbContext _context;
    private AddressRepo _addressRepo;
    public AddressController(PersonalDbContext personalDbContext, AddressRepo addressRepo)
    {
        _context = personalDbContext;
        _addressRepo = addressRepo;
    }
    [HttpGet("Api/Address/GetAddress")]
    public List<Address> GetAddress()
    {
        return _addressRepo.GetAddress();
    }

    [HttpPost("Api/Address/CreateAddress")]
    public Task CreateAddress(CreateAddressModel createAddress)
    {
        _addressRepo.CreateAddress(createAddress.Country, createAddress.City, createAddress.Street, createAddress.HomeNumber);
        return Task.CompletedTask;
    }
    [HttpPut("Api/Address/UpdateAddress")]
    public Task UpdateAddress(UpdateAddressModel updateAddress)
    {
        _addressRepo.UpdateAddress(updateAddress.Street);
        return Task.CompletedTask;
    }
}

using ApiHomework.Models;
using ApiHomeworkDAL;
using ApiHomeworkDAL.Entities;
using ApiHomeworkDAL.Interfaces;
using ApiHomeworkDAL.Repositories;
using ApiHomeworkService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiHomework.Controllers;

[ApiController]
[Route("API")]
public class AddressController : Controller
{
    private PersonalDbContext _context;
    private IAddressService _addressService;
    public AddressController(PersonalDbContext personalDbContext, IAddressService addressRepo)
    {
        _context = personalDbContext;
        _addressService = addressRepo;
    }
    [HttpGet("Api/Address/GetAddress")]
    public List<Address> GetAddress()
    {
        return _addressService.GetAddress();
    }

    [HttpPost("Api/Address/CreateAddress")]
    public Task CreateAddress(CreateAddressModel createAddress)
    {
        _addressService.CreateAddress(createAddress.Country, createAddress.City, createAddress.Street, createAddress.HomeNumber);
        return Task.CompletedTask;
    }
    [HttpPut("Api/Address/UpdateAddress")]
    public Task UpdateAddress(UpdateAddressModel updateAddress)
    {
        _addressService.UpdateAddress(updateAddress.Street);
        return Task.CompletedTask;
    }
}

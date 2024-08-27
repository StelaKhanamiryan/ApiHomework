using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHomeworkDAL.Entities;

namespace ApiHomeworkDAL.Interfaces;

public interface IAddressRepo
{
    public Task CreateAddress(string country, string city, string street, string homeNumber);
    public Task UpdateAddress(string street);
    public List<Address> GetAddress();

}

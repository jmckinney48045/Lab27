using Lab27API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27API.Services
{
    public interface IWeatherService
    {
        Task<Rootobject> GetAllRoots();
        Task<IEnumerable<Weather>> GetAll();
    }
}

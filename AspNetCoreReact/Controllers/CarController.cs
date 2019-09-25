using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DbRepository;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace AspNetCoreReact.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        [Route("cars")]
        public async Task<IList<Car>> GetCars()
        {
            return await _carRepository.GetCars();
        }
    }
}
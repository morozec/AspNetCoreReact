using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace DbRepository
{
    public interface ICarRepository
    {
        Task<IList<Car>> GetCars();
    }
}
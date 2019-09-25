using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DbRepository
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory)
        {
        }

        public async Task<IList<Car>> GetCars()
        {
            //var cars = new List<Car>()
            //    {new Car() {CarId = 0, Name = "Kalina", Price = 1000}, new Car() {CarId = 1, Name = "Bentley", Price = 2000}};
            //return cars;
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Cars.ToListAsync();
            }
        }
    }
}
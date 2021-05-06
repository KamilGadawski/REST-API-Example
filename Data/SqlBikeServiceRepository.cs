using SimpleBikeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Data
{
    public class SqlBikeServiceRepository : IBikeRepository
    {
        private readonly BikeServeceContext _context;

        public SqlBikeServiceRepository(BikeServeceContext context)
        {
            _context = context;

        }

        public void AddBike(BikeModel bike)
        {
            if (bike is null)
            {
                throw new ArgumentNullException(nameof(bike));
            }

            _context.Bikes.Add(bike);
        }

        public void DeleteBike(BikeModel bikeModel)
        {
            if (bikeModel is null)
            {
                throw new ArgumentNullException(nameof(bikeModel));
            }

            _context.Bikes.Remove(bikeModel);

        }

        public IEnumerable<BikeModel> GetAllBike()
        {
            return _context.Bikes.ToList();
        }

        public BikeModel GetBikeById(int id)
        {
            return _context.Bikes.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void UpdateBike(BikeModel bike)
        {
            
        }
    }
}

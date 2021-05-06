using SimpleBikeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Data
{
    public class MockBikeRepo : IBikeRepository
    {
        public void AddBike(BikeModel bike)
        {
            throw new NotImplementedException();
        }

        public void DeleteBike(BikeModel bikeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BikeModel> GetAllBike()
        {
            var bike = new List<BikeModel>
            {
                new BikeModel { Id = 0, Brand = "Giant", Model = "TCR", Size = 54, Price = 6999.99F },
                new BikeModel { Id = 1, Brand = "Cube", Model = "Attain", Size = 52, Price = 8000.99F },
                new BikeModel { Id = 2, Brand = "Kross", Model = "Vento", Size = 50, Price = 4499.99F },
                new BikeModel { Id = 3, Brand = "Cannondale", Model = "Caad12", Size = 48, Price = 12000.99F },
                new BikeModel { Id = 4, Brand = "Specialized", Model = "Tramac", Size = 60, Price = 10000.99F }
        };

            return bike;
        }

        public BikeModel GetBikeById(int id)
        {
            return new BikeModel { Id = 0, Brand = "Giant", Model = "TCR", Size = 54, Price = 6999.99F };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateBike(BikeModel bike)
        {
            throw new NotImplementedException();
        }
    }
}

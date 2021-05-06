using SimpleBikeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Data
{
    public interface IBikeRepository
    {
        IEnumerable<BikeModel> GetAllBike();
        BikeModel GetBikeById(int id);
        void DeleteBike(BikeModel bikeModel);
        void AddBike(BikeModel bike);
        void UpdateBike(BikeModel bike);

        bool SaveChanges();
    }
}

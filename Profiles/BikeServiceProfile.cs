using AutoMapper;
using SimpleBikeService.DTO;
using SimpleBikeService.Models;

namespace SimpleBikeService.Profiles
{
    public class BikeServiceProfile : Profile
    {
        public BikeServiceProfile()
        {
            CreateMap<BikeModel, BikeModelDto>();
            CreateMap<BikeAddDto, BikeModel>();
            CreateMap<BikeUpdateDto, BikeModel>();
            CreateMap<BikeModel, BikeUpdateDto>();
        }
    }
}

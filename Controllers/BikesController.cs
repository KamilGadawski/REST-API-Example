using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SimpleBikeService.Data;
using SimpleBikeService.DTO;
using SimpleBikeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBikeService.Controllers
{
    //api/Bikes
    [Route("api/bikes")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly IBikeRepository _bikeRepo;
        private readonly IMapper _mapper;

        public BikesController(IBikeRepository bikeRepo, IMapper mapper)
        {
            _bikeRepo = bikeRepo;
            _mapper = mapper;
        }

        //GET api/bikes
        [HttpGet]
        public ActionResult<IEnumerable<BikeModelDto>> GetAllBike()
        {
            var bikeItems = _bikeRepo.GetAllBike();

            return Ok(_mapper.Map<IEnumerable<BikeModelDto>>(bikeItems));
        }

        //GET api/bikes/{id}
        [HttpGet("{id}", Name = "GetBikeById")]
        public ActionResult<BikeModelDto> GetBikeById(int id)
        {
            var bike = _bikeRepo.GetBikeById(id);

            if (bike is not null)
            {
                return Ok(_mapper.Map<BikeModelDto>(bike));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<BikeModelDto> AddBike(BikeAddDto bikeAddDto)
        {
            var bikeModel = _mapper.Map<BikeModel>(bikeAddDto);

            _bikeRepo.AddBike(bikeModel);
            _bikeRepo.SaveChanges();

            var bikeModelDto = _mapper.Map<BikeModelDto>(bikeModel);

            return CreatedAtRoute(nameof(GetBikeById), new { Id = bikeModelDto.Id }, bikeModelDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBike(int id, BikeUpdateDto bikeUpdateDto)
        {
            var bikeModel = _bikeRepo.GetBikeById(id);

            if (bikeModel is null)
            {
                return NotFound();
            }

            _mapper.Map(bikeUpdateDto, bikeModel);
            _bikeRepo.UpdateBike(bikeModel);
            _bikeRepo.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveBike(int id)
        {
            var bike = _bikeRepo.GetBikeById(id);

            if (bike is null)
            {
                return NotFound();
            }

            _bikeRepo.DeleteBike(bike);
            _bikeRepo.SaveChanges();

            return NoContent();
        }
    }
}

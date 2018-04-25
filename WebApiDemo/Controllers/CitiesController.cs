using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class CitiesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<CityDto> Get()
        {
            return CityRepository.Instance.GetAllCities();
        }

        // GET api/<controller>/5
        public CityDto Get(int id)
        {
            return CityRepository.Instance.GetById(id);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]CityDto city)
        {
            
            CityRepository.Instance.CreateNewCity(city);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put([FromBody]CityDto city)
        {
            CityRepository.Instance.Update(city);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            CityRepository.Instance.Delete(id);
            return Ok();
        }
    }
}
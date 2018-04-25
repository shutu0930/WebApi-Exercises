using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Index(string person) { return Ok(); }
        public IHttpActionResult Documents( int id) { return Ok(); }

        //public HttpResponseMessage Get(int id)
        //{
        //    //throw new Exception("test exception");
        //    try
        //    {
        //        //throw new Exception("test exception");
        //        CarDto car = Cars.Instance.GetById(id);
        //        //if (car == null)
        //        //{
        //        //    return Request.CreateResponse(HttpStatusCode.NotFound);
        //        //}
        //        var response = Request.CreateResponse(car);
        //        // add more code for caching and other custom response headers...
        //        // for example: 
        //        //response.Headers.CacheControl = new CacheControlHeaderValue { MaxAge = TimeSpan.FromMinutes(1) };
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError);
        //    }
        //}

        public IHttpActionResult Get(int id)
        {
            //throw new Exception("test exception");
            try
            {
                //throw new Exception("test exception");
                CarDto car = CarRepository.Instance.GetById(id);
                if (car == null)
                {
                    return NotFound();
                }
                return Ok(car);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

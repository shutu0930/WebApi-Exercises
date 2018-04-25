using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class CarRepository
    {

        private static CarRepository _instance;
        public static CarRepository Instance {
            get {
                if (_instance == null)
                {
                    _instance = new CarRepository();
                }
                return _instance;
            }
        }

        private List<CarDto> _cars;
        private CarRepository()
        {
            
            _cars = ProcessCars();
        }
        private List<CarDto> ProcessCars()
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/fuel.csv");
            var query =

                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(l => l.Length > 1)
                    .ToCarDto();

            return query.ToList();
        }

        public List<CarDto> GetAllCars()
        {
            return _cars; 
        }

        public CarDto GetById(int id)
        {
            return _cars.FirstOrDefault(x=>x.Id == id);
        }
    }
}
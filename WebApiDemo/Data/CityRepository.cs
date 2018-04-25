using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class CityRepository
    {
        private static CityRepository _instance;

        public static CityRepository Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new CityRepository();
                }
                return _instance;
            }
        }

        private List<CityDto> _cities;

        

        private CityRepository()
        {
            _cities = new List<CityDto>();
            _cities.Add(new CityDto
            {
                Id = 1,
                Name = "Brisbane",
                Description = "Brisbaneis the capital of and most populous city in the Australian state of Queensland, and the third most populous city in Australia. Brisbane's metropolitan area has a population of 2.4 million."
            });
            _cities.Add(new CityDto
            {
                Id = 2,
                Name = "Melbourne",
                Description = "Melbourne is the capital and most populous city of the Australian state of Victoria, and the second-most populous city in Australia and Oceania The name Melbourne covers an urban agglomeration spanning 2,664 km2 (1,029 sq mi), which comprises the broader metropolitan area, as well as being the common name for its city centre. "
            });
            _cities.Add(new CityDto
            {
                Id = 3,
                Name = "Sydney",
                Description = "Sydney is the state capital of New South Wales and the most populous city in Australia and Oceania. Located on Australia's east coast, the metropolis surrounds the world's largest natural harbour and sprawls about 70 km (43.5 mi) on its periphery towards the Blue Mountains to the west, Hawkesbury to the north and Macarthur to the south. Sydney is made up of 658 suburbs, 40 local government areas and 15 contiguous regions. Residents of the city are known as Sydneysiders"
            });
        }


        public List<CityDto> GetAllCities()
        {
            return _cities;
        }

        public CityDto GetById(int id)
        {
            return _cities.FirstOrDefault(x => x.Id == id);
        }
        public void  CreateNewCity(CityDto city)
        {
            _cities.Add(city);
        }

        public void Update(CityDto city)
        {
            var c = _cities.FirstOrDefault(x => x.Id == city.Id);
            //c.Id = city.Id;
            c.Name = city.Name;
            c.Description = city.Description;
        }

        public void Delete(int id)
        {
            _cities.Remove(_cities.FirstOrDefault(x => x.Id == id));
        }

    }
}
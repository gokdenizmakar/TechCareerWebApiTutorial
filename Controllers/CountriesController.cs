using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            return new string[] {"Afghanistan","Albania","Algeria","Andorra","Angola","Antigua and Barbuda",
                "Argentina","Armenia","Australia","Austria","Austrian Empire","Azerbaijan","Bangladesh","Barbados","Bavaria",
                "Belarus","Belgium","Belize","Benin","Bolivia"};
        }

        [HttpGet("{id}")]
        public string[] GetCountries(int id)
        {
            string[] countries = {"Afghanistan","Albania","Algeria","Andorra","Angola","Antigua and Barbuda",
        "Argentina","Armenia","Australia","Austria","Austrian Empire","Azerbaijan","Bangladesh","Barbados","Bavaria",
        "Belarus","Belgium","Belize","Benin","Bolivia"};

            if (id <= 0 || id > countries.Length)
            {
                // Hatalı id değeri için boş dizi döndür
                return new string[0];
            }

            string[] selectedCountries = new string[id];
            for (int i = 0; i < id; i++)
            {
                selectedCountries[i] = countries[i];
            }

            return selectedCountries;
        }
    }
}

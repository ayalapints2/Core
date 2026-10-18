using Microsoft.AspNetCore.Mvc;
//using _2026_10_06.Models;

namespace webApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private static readonly string[] CountryName = new[]
    {
        "italy", "franc", "kanady", "ingland", "isreal"
    };

    private readonly ILogger<CountryController> _logger;

    public CountryController(ILogger<CountryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCountry")]
    public IEnumerable<NutCantry> Get()
    {
        return Enumerable.Range(1, 5).Select(_ => new NutCantry
        {
            id = Random.Shared.Next(1, 1000),
            size = Random.Shared.Next(10000, 1000000),
            countPupale = Random.Shared.Next(120, 1000000),
            name = CountryName[Random.Shared.Next(CountryName.Length)]
        }).ToArray();
    }
    
    [HttpPost(Name = "PostCountry")]
    public NutCantry Post(NutCantry country)
    {
        country.id = Random.Shared.Next(1, 1000);
        // Here you can add logic to save the country data to a database or perform other actions.
        // For demonstration purposes, we will just return the received country object.
        return country;
    }

    [HttpPut("{id}", Name = "PutCountry")]
    public NutCantry Put(int id, NutCantry country)
    {
        // Here you can add logic to update the country data in a database or perform other actions.
        // For demonstration purposes, we will just return the received country object.
        return country;
    }
    [HttpDelete("{id}", Name = "DeleteCountry")]
    public IActionResult Delete(int id)
    {
        // Here you can add logic to delete the country data from a database or perform other actions.
        // For demonstration purposes, we will just return NoContent.
        return NoContent();
    }
}

using Microsoft.AspNetCore.Mvc;
//using _2026_10_06.Models;

namespace webApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CantryController : ControllerBase
{
    private static readonly string[] CantryName = new[]
    {
        "italy","franc","kanady","ingland","isreal"
    };

    //private static List<NutCantry>? arr;
    private readonly ILogger<CantryController> _logger;

    public CantryController(ILogger<CantryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCantry")]
    public IEnumerable<NutCantry> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new NutCantry
        {
            size=Random.Shared.Next(10000, 1000000),
            countPupale = Random.Shared.Next(120, 1000000),
          name =CantryName[Random.Shared.Next(CantryName.Length)]
        })
        .ToArray();
    }
}

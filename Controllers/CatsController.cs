using System;
using System.Collections.Generic;
using cats.DB;
using cats.Models;
using cats.Services;
using Microsoft.AspNetCore.Mvc;

namespace cats.Controllers
{
  // This attribute tells dotnet that this class should be registered with the controllers
  [ApiController]
  // the [controller] names the route with whatever the name before the word 'controller' in the class is, in this case 'cats'
  [Route("api/[controller]")]
  public class CatsController : ControllerBase
  {
    private readonly CatsService _service;

    // Dependency Injection
    public CatsController(CatsService service)
    {
      _service = service;
    }


    // this attribute defines the method to follow is a GET request
    [HttpGet]
    // IEnumerable takes the place of any collection type (List, Array, etc.)
    public ActionResult<IEnumerable<Cat>> getAll()
    {
      try
      {
        return Ok(FakeDB.Cats);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}
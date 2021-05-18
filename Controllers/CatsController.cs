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
    public ActionResult<IEnumerable<Cat>> GetAll()
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


    // GETById
    [HttpGet("{id}")] // same as :id
    public ActionResult<Cat> GetById(string id)
    {
      try
      {
        Cat found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST
    [HttpPost]
    // NOTE From the body, create a Cat type object called newCat
    public ActionResult<Cat> Create([FromBody] Cat newCat)
    {
      try
      {
        Cat cat = _service.Create(newCat);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // PUT
    [HttpPut("{id}")]
    public ActionResult<Cat> Edit([FromBody] Cat editCat, string id)
    {
      try
      {
        editCat.Id = id;
        Cat cat = _service.Edit(editCat);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // DELETE
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCat(string id)
    {
      try
      {
        _service.DeleteCat(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}
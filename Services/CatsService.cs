using System.Collections.Generic;
using cats.DB;
using cats.Models;

namespace cats.Services
{
  public class CatsService
  {
    public IEnumerable<Cat> GetAll()
    {
      // NOTE this is the temporary before a real db
      return FakeDB.Cats;
    }
  }
}
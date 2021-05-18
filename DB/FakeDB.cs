using System.Collections.Generic;
using cats.Models;

namespace cats.DB
{
  public static class FakeDB
  {
    public static List<Cat> Cats { get; set; } = new List<Cat>(){
        new Cat("Mr. Snibbley", 119, true)
    };
  }
}
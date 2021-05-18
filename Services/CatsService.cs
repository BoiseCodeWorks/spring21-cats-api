using System;
using System.Collections.Generic;
using cats.DB;
using cats.Models;

namespace cats.Services
{
  public class CatsService
  {
    internal IEnumerable<Cat> GetAll()
    {
      // NOTE this is the temporary before a real db
      return FakeDB.Cats;
    }

    internal Cat GetById(string id)
    {
      Cat found = FakeDB.Cats.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Cat Create(Cat newCat)
    {
      FakeDB.Cats.Add(newCat);
      return newCat;
    }

    internal Cat Edit(Cat editCat)
    {
      Cat oldCat = GetById(editCat.Id);
      oldCat.Name = editCat.Name;
      oldCat.Age = editCat.Age;
      oldCat.IsHungry = editCat.IsHungry;

      return oldCat;
    }

    internal void DeleteCat(string id)
    {
      Cat found = GetById(id);
      FakeDB.Cats.Remove(found);
    }
  }
}
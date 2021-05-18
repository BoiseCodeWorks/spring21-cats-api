using System;
using System.ComponentModel.DataAnnotations;

namespace cats.Models
{
  public class Cat
  {
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0, int.MaxValue)]
    public int Age { get; set; }
    public bool IsHungry { get; set; }
    public Cat(string name, int age, bool isHungry)
    {
      // this is temporary, the db will establish the id later
      Id = Guid.NewGuid().ToString();
      Name = name;
      Age = age;
      IsHungry = isHungry;
    }
  }
}
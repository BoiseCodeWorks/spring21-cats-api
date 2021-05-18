namespace cats.Models
{
  public class Cat
  {

    public string Name { get; set; }
    private int _age;
    public int Age { get; set; }
    public bool IsHungry { get; set; }
    public Cat(string name, int age, bool isHungry)
    {
      Name = name;
      Age = age;
      IsHungry = isHungry;
    }
  }
}
using System;

class Octopus
{
  public readonly string Name;
  public int Age = 10;
  public static readonly int legs = 8, eyes = 1;

  

  
  public Octopus (string name)
  {
    Name = name;
  }
}
class Program
{
    static void Main()
    {
        //New octopus variable with my name
        var oct = new Octopus("Wes");
        //displays the name,age, amount of legs, and eyes
        Console.WriteLine("Octopus Name: " + oct.Name);
        Console.WriteLine("Octopus Age: " + oct.Age);
        Console.WriteLine("Octopus Legs: " + Octopus.legs);
        Console.WriteLine("Octopus Eyes: " + Octopus.eyes);


    }
}
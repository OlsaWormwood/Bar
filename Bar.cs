using System;
using System.Collections.Generic;
using System.Text;
 
namespace Homework_Hyena
{
  public class Bar
  {
    public string Name { get; }
    public List<Drink> Drinks { get; set; } = new List <Drink>();
    public List<Visitor> Visitors { get; set; } = new List <Visitor>();  

    public Bar(string name) 
    {
      Name = name;
    }

    public void ShowDrinks() 
    {
      Console.WriteLine("\n=== Drinks ===");
      foreach (var drink in Drinks)
      {
         Console.WriteLine($" - {drink.Name.ToUpper()} ({drink.Volume} - {drink.Strength}°) ");
      }
    }

    public void ShowVisitors() 
    {
      Console.WriteLine("\n\t\t=== Our guests today ===");
      foreach (var visitor in Visitors)
      {
        Console.WriteLine($"\t - {visitor.Name.ToUpper()} (type: {visitor.Type}, endurance: {visitor.Endurance}) ");
      }
    }
    
    public Drink GetRandomDrink()
    {
      Random rnd = new Random();
      return Drinks[rnd.Next(Drinks.Count)];
    }    
  }
}
 
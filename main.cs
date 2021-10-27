using Homework_Hyena;
using System;

public class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("== ! Welcome to Hyena bar ! ==");
    Console.WriteLine("Today in the menu:");
  
    var MyBar = new Bar("Hyena");
    var Beer = new Drink("Beer", 4, 0.5);
    var Vodka = new Drink("Vodka", 40, 0.1);
    var Cocktail = new Drink("Bluemoon", 20, 0.4);    
    
    MyBar.Drinks.Add(Beer);
    MyBar.Drinks.Add(Vodka);    
    MyBar.Drinks.Add(Cocktail);   
    MyBar.ShowDrinks();
    
    Group group1 = new Group();
    Group group2 = new Group();    

    int maxMembers = 10;
    for(var i = 0; i < maxMembers; i++) 
    {
      var visitor = Visitor.CreateVisitor();
      group1.AddMember(visitor);
      MyBar.Visitors.Add(visitor);   
    }

    for(var i = 0; i < maxMembers; i++) 
    {
      var visitor = Visitor.CreateVisitor();      
      group2.AddMember(visitor);
      MyBar.Visitors.Add(visitor);   
    }

    Console.WriteLine("\n== Let the game begin ==");

    Console.WriteLine($"-----------------------------------------------------------------");               
    Console.WriteLine($"Group-1 endurance: {group1.Endurance}, Group-2 endurance: {group2.Endurance}");
    Console.WriteLine($"-----------------------------------------------------------------");             

    int j = 0;

    while (group1.Endurance > 0 && group2.Endurance > 0)
    {
      j++;
      Console.WriteLine($"Round {j}: ");
      for(var i = 0; i < maxMembers; i++) 
      {               
        var drink = MyBar.GetRandomDrink();
        group1.Endurance -= group1.Members[i].Drink(drink);    

        drink = MyBar.GetRandomDrink();
        group2.Endurance -= group2.Members[i].Drink(drink);         
      }    
      Console.WriteLine($"---------------------------------------------------------------");               
      Console.WriteLine($"Group-1 endurance: {group1.Endurance}, Group-2 endurance: {group2.Endurance}");
      Console.WriteLine($"---------------------------------------------------------------");         
    }    

    if (group1.Endurance > 0) {
      Console.WriteLine($"Group 1 won!!! Congratulations!");
    } 
    else 
    {
      Console.WriteLine($"Group 2 won!!! Congratulations!");      
    }
  }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Hyena
{
  public class Visitor
  {
    public string Name { get; set; }
    public virtual string Type { get; set; } = "Civil";
    public int Endurance { get; set; }
  
    public void PrintInfo() 
    {
    }

    public int Drink(Drink drink) {  
      int DestructiveForce = 0;     
      
      if (Endurance > 0) 
      { 
        DestructiveForce = (int)Math.Round(drink.DestructiveForce);

        if (DestructiveForce > Endurance) 
        {
          DestructiveForce = Endurance;
        }

        Endurance -= DestructiveForce;

        Console.WriteLine($"\t - {Name.ToUpper()} drinks {drink.Name} (type: {Type}, endurance: {Endurance}) ");
      }

      return DestructiveForce;
    }

    public static Visitor CreateVisitor() 
    {
      string[] names = { "Baka", "Loki", "Nika", "Psih", "Helga", "Ruslan", "Alan", "Kosha", "Nastya" };
      
      Random rnd = new Random();            

      var name = names[rnd.Next(names.Length)];
      int endurance = rnd.Next(20, 61);    

      int index = rnd.Next(0, 4);

      if (index == 1)
      {
        return new Tolchok() { Name = name, Endurance = endurance };
      } 
      else if (index == 2)
      {
        return new Biker() { Name = name, Endurance = endurance };
      } 
      else if (index == 3)      
      {
        return new Stalker() { Name = name, Endurance = endurance };      
      } 
      else 
      {   
        return new Visitor() { Name = name, Endurance = endurance };    
      }
    }
  }  
}



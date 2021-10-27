using System;
using System.Collections.Generic;
using System.Text;
 
namespace Homework_Hyena
{
  public class Drink
  {
    public string Name { get; }
    public int Strength { get; }
    public double Volume { get; }    
    public double DestructiveForce { get; }

    public Drink(string name, int strength, double volume) 
    {
      Name = name;
      Strength = strength;
      Volume = volume;
      DestructiveForce = Strength * Volume;
    }
  }
}
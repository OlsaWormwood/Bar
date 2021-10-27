using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Hyena
{
  public class Group
  {
    public List<Visitor> Members { get; } = new List <Visitor>();  
    public int Endurance { get; set; }     
    
    public void AddMember(Visitor member) {
      Endurance += member.Endurance;
      Members.Add(member);
    }   
  }
}

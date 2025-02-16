using System;

namespace CorporatePolymorphism
{
  // Placeholder for Manager class implementation
  public class Manager : Employee {
    
    public override void Work(){
      Console.WriteLine("Manager oversees the project.");
    }
    public override void SubmitDailyReport(){
      Console.WriteLine("Manager submits daily report.");
    }
  }
}

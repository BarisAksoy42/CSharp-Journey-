using System;
public class UserLogin {
  static void Main(){
    Console.Write("Name: ");
    string name=Console.ReadLine();
    Console.WriteLine("Hı!"+name+" how are you today?");
    string situation=Console.ReadLine();
    if (situation.ToLower()=="i'm good"){
      Console.WriteLine("Great!");
    } else if (situation.ToLower()=="i'm bad"){
      Console.WriteLine("I'm sorry to hear that");
    } else {
      Console.WriteLine("I didn't understand you.");
    }
  }
}
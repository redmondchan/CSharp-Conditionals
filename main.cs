using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("How old are you?");
    var yourAge = Convert.ToInt32(Console.ReadLine());
    if(yourAge < 27){
      Console.WriteLine("You are younger than me.");
    } else {
      Console.WriteLine("I'm older than you.");
    };

  }
}
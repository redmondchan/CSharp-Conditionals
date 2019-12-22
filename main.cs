using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("How old are you?");
    var yourAge = Convert.ToInt32(Console.ReadLine());
    if(yourAge < 27){
      Console.WriteLine("You are younger than me.");
    } else if (yourAge > 27) {
      Console.WriteLine("You are older than me.");
    } else {
      Console.WriteLine("You are NOT younger than me.");
    };

    // else if example
    // Console.WriteLine ("How old are you?");
    // var yourAge = Convert.ToInt32(Console.ReadLine());
    // if(yourAge < 27){
    //   Console.WriteLine("You are younger than me.");
    // } else if (yourAge > 27) {
    //   Console.WriteLine("You are older than me.");
    // } else {
    //   Console.WriteLine("You are NOT younger than me.");
    // };

    // else example
    // Console.WriteLine ("How old are you?");
    // var yourAge = Convert.ToInt32(Console.ReadLine());
    // if(yourAge < 27){
    //   Console.WriteLine("You are younger than me.");
    // } else {
    //   Console.WriteLine("You are NOT younger than me.");
    // };

    // if statement example
    // Console.WriteLine ("How old are you?");
    // var yourAge = Convert.ToInt32(Console.ReadLine());
    // if(yourAge < 27){
    //   Console.WriteLine("You are younger than me.");
    // };

  }
}
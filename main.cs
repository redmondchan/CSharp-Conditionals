using System;

class MainClass {
  public static void Main (string[] args) {

    // nested example
    Console.WriteLine ("How old are you?");
    int yourAge;
    var input = Int32.TryParse(Console.ReadLine(), out yourAge);

    if (input){
      if(yourAge < 27){
        Console.WriteLine("You are younger than me.");
        if (yourAge == 22) {
          Console.WriteLine("To be exact, you're 5 years younger than me.");
        };
      } else if (yourAge > 27) {
        Console.WriteLine("You are older than me.");
      }
    } else {
      Console.WriteLine("Invalid Input. Please enter a valid number.");
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
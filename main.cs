using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter your first number (Whole numbers only please)");
    var x = Console.ReadLine();
    Console.WriteLine("Please enter your second number (Whole numbers only please)");
    var y = Console.ReadLine();
    int x1 = Convert.ToInt32(x);
    int y1 = Convert.ToInt32(y);
    var sum = x1+y1;
    var diff = x1-y1;
    var product = x1*y1;
    var quotient = x1/y1;
    var remainder = x1%y1;
    Console.WriteLine("The sum of those two numbers is " + sum);
    Console.WriteLine("The difference of those two numbers is " + diff);
    Console.WriteLine("The product of those two numbers are " + product);
    Console.WriteLine("The quotient of those two numbers is " + quotient);
    Console.WriteLine("The remainder of those two numbers is " + remainder);
  }
}
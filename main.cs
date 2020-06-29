using System;

class MainClass {
  public static void Main (string[] args) {

    int counter = 1;
    double total = 0;

    Console.WriteLine("How many cars are there in this race?");
    int numberofcars = Convert.ToInt32(Console.ReadLine());

    while(counter <= numberofcars) 
{
    Console.WriteLine("Enter distance in miles covered by car #" + counter);
    int distance = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter time in hours covered by car #" + counter);
    int time = Convert.ToInt32(Console.ReadLine());
    double speed = distance / time;
    Console.WriteLine("Speed of car #" + counter + " is " + speed + " mph");
    total = total + speed;
    counter++;
}
    double average = total / numberofcars;
    Console.WriteLine("The average speed of the cars is " + average);
  }
}
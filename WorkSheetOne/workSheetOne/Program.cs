using System;

namespace workSheetOne
{
  class Program
  {
    static void Main(string[] args)
    {

      // create two different person objects
    Person person1 = new Person(1);
    Person person2 = new Person(2);

    // display the names of the persons on screen
    Console.WriteLine(person1.GetName());
    Console.WriteLine(person2.GetName());


      // create an instance of the class RandomNumbers
      RandomNumbers randomNumbers = new RandomNumbers();

      // call the method GenerateNumbers()
      randomNumbers.GenerateNumbers();

      // call the method FindSum()
      int sum = randomNumbers.FindSum();

      // ask the user to input the sum of the two numbers
      Console.WriteLine("Please enter the sum of the two numbers: ");
      int userSum = int.Parse(Console.ReadLine());

      // call the method IsEqual() to compare the user’s input with the sum of the numbers
      if (randomNumbers.IsEqual(userSum))
      {
        Console.WriteLine("Well done correct answer");
      }
      else
      {
        Console.WriteLine("Sorry wrong answer");
      }
    }
  }
}

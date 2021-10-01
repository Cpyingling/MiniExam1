/*
The program should calculate the BMI and provides health status based on BMI for 10 people
*/
using System;

class Program {
  public static void Main (string[] args) {


for (int people = 0; people < 10; people++) {
        Console.WriteLine ("Please enter name");
      string name = Console.ReadLine();
        Console.WriteLine ("Please enter height(in inches)");
      int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Please enter weight(in pounds)");
      int weight = Convert.ToInt32(Console.ReadLine());
int bmi = 703 * weight / height * height;

  if (bmi < 18.5) {
  Console.WriteLine ("you are Underweight");
  } else if (bmi > 25 && bmi < 29.9) {
  Console.WriteLine ("you are  Healthy Weight");
  } else if (bmi > 25 && bmi < 29.9) {
  Console.WriteLine ("you are  Overweight");
  } else if (bmi > 30) {
  Console.WriteLine ("You are Obese");
   }
  }
}
}
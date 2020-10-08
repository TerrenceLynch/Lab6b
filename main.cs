using System;



class MainClass {





  public static void Main (string[] args) {


double height;
double weight;

    for (double counter = 0; counter < 10; counter++)
    {
      Console.WriteLine("Enter weight.");
      weight = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter height.");
      height = Convert.ToDouble(Console.ReadLine());
      CalculateBMI(weight: weight, height: height);
      
    }


  }

  static void CalculateBMI(double weight, double height) 
    { 
      double bmi = (weight * 703)/(height * height);
      BMIResults(bmi: bmi);
    }
    static void BMIResults(double bmi)
    {
      if (bmi < 0)
      {
        Console.WriteLine("How you do dis?");
      }

      else if (bmi < 18.5)
      {
      Console.WriteLine("Underweight");
      }
      else if (bmi > 18.5 && bmi < 24.9)
      {
      Console.WriteLine("Normal");
      }
      else if (bmi > 25 && bmi < 29.9)
      {
      Console.WriteLine("OverWeight");
      }
      else if (bmi > 30)
      {
      Console.WriteLine("Obese");
      }

      }
    

}
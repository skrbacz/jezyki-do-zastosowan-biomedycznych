// 14. Celsius to Kelvin and Fahrenheit -> https://www.w3resource.com/csharp-exercises/basic/index.php#editorr

namespace BasicExercises
{
  class Task1
{
   static void Main(){
    Console.WriteLine("Witaj w programie, który przelicza temperature Celsjusza na Kelviny oraz Fahrenheita.");

    Console.WriteLine("Podaj temperature w stopniach Celsjusza:");
 
    double celciusz = Double.Parse(Console.ReadLine()!);

   
    double farenheit = CalculateFarenheit(celciusz);
    double kelvin = CalculateKelvin(celciusz);

    Console.WriteLine("Temperatura " + celciusz + "°C, to " + kelvin + "K");
    Console.WriteLine("Temperatura " + celciusz + "°C, to " + farenheit + "°F");
  }

  // wzór: https://www.calculatorsoup.com/calculators/conversions/celsius-to-fahrenheit.php
  internal static double CalculateFarenheit(double c)
    {
    return (c * 9/5) +32;
    }

  internal static double CalculateKelvin(double c)
    {
      return c + 273.15;
    }
  
}
}

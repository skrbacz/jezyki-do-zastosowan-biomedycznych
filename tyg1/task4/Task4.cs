// 5. Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle. -> https://www.w3resource.com/csharp-exercises/data-types/index.php
namespace DataTypes
{
  class Task4
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Proszę podaj promień koła: ");
      double radius = Double.Parse(Console.ReadLine()!);
      
      double[] premiterAndArea = CalculatePremiterAndArea(radius);
      Console.WriteLine($"Obwód: {premiterAndArea[0]}, pole: {premiterAndArea[1]}.");
       
    }
    catch (FormatException e2)
    {
      Console.WriteLine($"Błąd: {e2.Message} Proszę podaj liczbę."); 
    }
  }

 internal static double[] CalculatePremiterAndArea(double r)
  {
    double premiter = 2*Math.PI*r;
    double area = Math.PI*r*r;

    double[] result = [Math.Round(premiter,2),Math.Round(area,2)];
    return result;
  }
}
}

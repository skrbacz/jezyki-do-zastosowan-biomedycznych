// 10. Multiple of 3 or 7 -> https://www.w3resource.com/csharp-exercises/basic-algo/index.php 
namespace BasicAlgorithm
{
  class Task2
{
  static void Main()
  {
    int input = 17;
    bool isit = IsItMultiplyOf3Or7(input);

    //https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-10.0
    Console.WriteLine($"Liczba jest mnożnikiem 3 lub 7: {isit}" );
  }

 // Operator reminder % https://learn.microsoft.com/pl-pl/dotnet/csharp/language-reference/operators/arithmetic-operators
   internal static Boolean IsItMultiplyOf3Or7(int i)
  {
    return i%3 == 0 || i%7 == 0;
  }
}
}

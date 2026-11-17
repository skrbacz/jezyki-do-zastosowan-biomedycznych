// 4. Write a C# program that prompts the user to input a numeric integer and throws an exception if the number is less than 0 or greater than 1000. -> https://www.w3resource.com/csharp-exercises/exception-handling/index.php
namespace ExceptionHandlingEx
{
class Task3
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Proszę podaj jakąkolwiek liczbę całkowitą: ");
      int number = Int32.Parse(Console.ReadLine()!);
      int l = IsItLessThan0OrGreater1000(number);
      Console.WriteLine($"Liczba {l} mieści się w przedziale 1-1000.");
       
    }// https://learn.microsoft.com/pl-pl/dotnet/csharp/fundamentals/exceptions/exception-handling
    catch (ArgumentOutOfRangeException e1)
    {
      Console.WriteLine($"Błąd: {e1.Message}");
    }
    catch (FormatException e2)
    {
      Console.WriteLine($"Błąd: {e2.Message} Proszę podaj liczbę."); 
    }
  }

 internal static int IsItLessThan0OrGreater1000(int i)
  {
    if (i >= 0 && i <= 1000 )
    {
      return i;
    } 
    else
    {
      // https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception?view=net-10.0
      throw new ArgumentOutOfRangeException(nameof(i), "Liczba musi być w przedziale 0-1000.");
    }
  }
}
}

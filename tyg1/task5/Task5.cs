// 20. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word. -> https://www.w3resource.com/csharp-exercises/conditional-statement/index.php
namespace ConditionalStatement
{
  class Task5
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Podaj numer miesiąca, a ja podam ile ma dni: ");
      int liczba = Int32.Parse(Console.ReadLine()!);
      
      string nazwaDnia = NameOfDay(liczba);
      Console.WriteLine($"Nazwa dnia tygodnia o numerze {liczba}, to {nazwaDnia}.");
       
    } // https://learn.microsoft.com/pl-pl/dotnet/csharp/fundamentals/exceptions/exception-handling
    catch (ArgumentOutOfRangeException e1)
    {
      Console.WriteLine($"Błąd: {e1.Message}");
    }
    catch (FormatException e2)
    {
      Console.WriteLine($"Błąd: {e2.Message} Proszę podaj liczbę."); 
    }
  }

 internal static string NameOfDay(int liczba)
  {
    if (liczba == 1)
    {
      return "Poniedziałek";
    }
    else if (liczba == 2)
    {
      return "Wtorek";
    }
    else if (liczba == 3)
    {
      return "Środa";
    } 
    else if (liczba == 4)
    {
      return "Czwartek";
    }
    else if (liczba == 5)
    {
      return "Piątek";
    }
    else if (liczba == 6)
    {
      return "Sobota";
    }
    else if (liczba == 7)
    {
      return "Niedziela";
    }
    else 
    {
     throw new ArgumentOutOfRangeException(nameof(liczba), "Tydzień ma 7 dni!");
    }
  }
}
}


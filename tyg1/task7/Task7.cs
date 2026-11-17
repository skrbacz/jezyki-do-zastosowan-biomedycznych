// 16. Write a C# Sharp program to find the second largest element in an array. -> https://www.w3resource.com/csharp-exercises/array/index.php
namespace ArrayExercises
{
  class Task7
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Podaj wielkość tablicy: ");
      int wielkość = Int32.Parse(Console.ReadLine()!);
      if (wielkość < 0)
      {
        throw new ArgumentOutOfRangeException(nameof(wielkość), $"Tablica nie może mieć ujemnej wielkośći!");
      }

      int [] tablica = new int[wielkość!];

      for (int i = 0; i < wielkość; i++)
      {
        Console.WriteLine($"Podaj wartość {i} elementu:");
        tablica[i] = Int32.Parse(Console.ReadLine()!);
      }
      
      Array.Sort(tablica);
      int drugaNajwiększa = SecondHighestNumber(tablica);
      Console.WriteLine($"Druga największa liczba w tablicy to {drugaNajwiększa}.");
       

    } // https://learn.microsoft.com/pl-pl/dotnet/csharp/fundamentals/exceptions/exception-handling
    catch (ArgumentOutOfRangeException e1)
    {
      Console.WriteLine($"Błąd: {e1.Message}");
    }
    catch (FormatException e2)
    {
      Console.WriteLine($"Błąd: {e2.Message} Proszę podaj liczbę całkowitą."); 
    }
  }

 internal static int SecondHighestNumber(int [] uzupełnionaTablica)
  // sortowanie: https://www.w3schools.com/cs/cs_arrays_sort.php
  {
  // sposób z "daszkiem" do wyciągnięcia z tabeli przedostatniego elementu zainsppirowany tym wpisem na stackoverflow: 
  // https://stackoverflow.com/questions/1056749/finding-the-last-index-of-an-array
  if (uzupełnionaTablica.Length < 2)
    {
      throw new ArgumentOutOfRangeException(nameof(uzupełnionaTablica.Length), $"Twoja tablica jest krótsza niż 2 elementy - brak przedostatniego elementu!");
    }
    else
    {
      return uzupełnionaTablica[^2];
    }
  
  }
}
}

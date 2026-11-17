// 12. Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1. -> https://www.w3resource.com/csharp-exercises/for-loop/index.php
namespace ForLoop
{
  class Task6
{
  static void Main()
  {
    int liczba = 1;
    int wiersze = 4;
    for (int i = 1; i <= wiersze; i++) 
    {
      for (int j = 1; j <= i; j++) 
      {  
             Console.Write($"{liczba} ");
             liczba++;
      }
       
      Console.WriteLine("");
    }    
    
  }
}
}


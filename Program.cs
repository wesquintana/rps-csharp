using System;
using System.Collections.Generic;

namespace rock_paper_scissors_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      int[] choices = new int[3] { 1, 2, 3 };
      Random rand = new Random();
      int i = rand.Next(choices.Length);
      Console.WriteLine("ROCK PAPER SCISSORS");
      Dictionary<string, int> translator = new Dictionary<string, int> { { "rock", 1 }, { "paper", 2 }, { "scissors", 3 } };
      Boolean running = true;
      while (running)
      {
        Console.Write("What do you choose? ");

        String s = Console.ReadLine();
        int translation;
        if (translator.ContainsKey(s.ToLower()))
        {
          running = false;
          translation = translator[s.ToLower()];
          int evaluator = translation - choices[i];
          switch (evaluator % 2)
          {
            case 0:
              Console.WriteLine($"{translation} {choices[i]} Draw");
              break;
            case 1:
            case -2:
              Console.WriteLine($"{translation} {choices[i]} Win");
              break;
            case -1:
            case 2:
              Console.WriteLine($"{translation} {choices[i]} Lose");
              break;
          }
        }
      }
    }
  }
}

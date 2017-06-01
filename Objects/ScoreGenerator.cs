using System;
using System.Collections.Generic;


namespace ScrabbleScore
{
  public class ScoreGenerator
  {
    public static int GenerateScore(string userInput)
    {
      int score = 0;
      string oneScoreLetters = "aeioulnrst";
      // alphabet as list of chars
      // string alphabet = "abcdefghijklmnopqrstuvwxyz";
      // char[] alphabetAsCharArray = alphabet.ToCharArray();
      // user input as string
        // is already the argument of the method
      // convert to char array
      string inputToLower = userInput.ToLower();
      char[] inputAsCharArray = inputToLower.ToCharArray();

      // int for scoring
      int Oneletterscore = 1;
      int Twoletterscore = 2;
      int Threeletterscore = 3;
      int Fourletterscore = 4;
      int Fiveletterscore = 5;
      int Eightletterscore = 8;
      int Tenletterscore = 10;

      // for loop over input array, sum score @ each hit
      for (int i = 0; i < inputAsCharArray.Length ; i++)
      {
        // if (inputAsCharArray[i] == 'a' || inputAsCharArray[i] == 'e' || inputAsCharArray[i] == 'i' || inputAsCharArray[i] == 'o' || inputAsCharArray[i] == 'u' || inputAsCharArray[i] == 'l' || inputAsCharArray[i] == 'n' || inputAsCharArray[i] == 'r' || inputAsCharArray[i] == 's' || inputAsCharArray[i] == 't')
        // {
        //   score += Oneletterscore;
        // }
        if(oneScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += Oneletterscore;
        }
      }
      // produce score
      return score;

    }
  }
}

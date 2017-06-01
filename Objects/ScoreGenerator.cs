using System;
using System.Collections.Generic;


namespace ScrabbleScore
{
  public class ScoreGenerator
  {
    public static int GenerateScore(string userInput)
    {
      int score = 0;

      string inputToLower = userInput.ToLower();
      char[] inputAsCharArray = inputToLower.ToCharArray();

      string oneScoreLetters = "aeioulnrst";
      string twoScoreLetters = "dg";
      string threeScoreLetters = "bcmp";
      string fourScoreLetters = "fhvmy";
      string fiveScoreLetters = "k";
      string eightScoreLetters = "jx";
      string tenScoreLetters = "qz";


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
        if(twoScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += Twoletterscore;
        }
      }
      return score;
    }
  }
}

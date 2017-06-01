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


      int oneletterscore = 1;
      int twoletterscore = 2;
      int threeletterscore = 3;
      int fourletterscore = 4;
      int fiveletterscore = 5;
      int eightletterscore = 8;
      int tenletterscore = 10;

      for (int i = 0; i < inputAsCharArray.Length ; i++)
      {
        if(oneScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += oneletterscore;
        }
        if(twoScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += twoletterscore;
        }
        if(threeScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += threeletterscore;
        }
      }
      return score;
    }
  }
}

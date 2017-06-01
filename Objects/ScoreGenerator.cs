using System;
using System.Collections.Generic;
using System.Linq;


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
      string fourScoreLetters = "fhvwy";
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
        if(fourScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += fourletterscore;
        }
        if(fiveScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += fiveletterscore;
        }
        if(eightScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += eightletterscore;
        }
        if(tenScoreLetters.Contains(inputAsCharArray[i].ToString()))
        {
          score += tenletterscore;
        }
      }
      return score;
    }

    public static bool IsValid(string testWord)
    {
      int wordLength = testWord.Length;
      int alphas = testWord.Count(char.IsLetter) + testWord.Count(char.IsWhiteSpace);
      if(alphas == wordLength)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

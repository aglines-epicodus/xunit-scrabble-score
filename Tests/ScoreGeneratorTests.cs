using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class ScoreGeneratorTests
  {
    [Fact]
    public void GenerateScore_CountsLetterScore_1PointLetters()
    {
      //Arrange
      string testInput = "aeioulnrst";
      int  testScore = 10;
      //Act
      int result = ScoreGenerator.GenerateScore(testInput);
      //Assert
      Assert.Equal(testScore, result);
    }

    [Fact]
    public void GenerateScore_CountsLetterScore_2PointLetters()
    {
      string testInput = "dg";
      int testScore = 4;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }
  }
}

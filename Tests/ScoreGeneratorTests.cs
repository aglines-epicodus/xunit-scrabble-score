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
      string testInput = "abcdefghijklmnopqrstuvwxyz";
      int  testScore = 10;
      //Act
      int result = ScoreGenerator.GenerateScore(testInput);
      //Assert
      Assert.Equal(testScore, result);
    }
  }


}

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

    [Fact]
    public void GenerateScore_CountsLetterScore_3PointLetters()
    {
      string testInput = "bcmp";
      int testScore =  12;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }

    [Fact]
    public void GenerateScore_CountsLetterScore_4PointLetters()
    {
      string testInput = "fhvwy";
      int testScore =  20;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }

    [Fact]
    public void GenerateScore_CountsLetterScore_5PointLetters()
    {
      string testInput = "k";
      int testScore = 5;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }

    [Fact]
    public void GenerateScore_CountsLetterScore_8PointLetters()
    {
      string testInput = "jx";
      int testScore = 16;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }

    [Fact]
    public void GenerateScore_CountsLetterScore_10PointLetters()
    {
      string testInput = "qz";
      int testScore = 20;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }

// Cat-like typing detected
    [Fact]
    public void GenerateScore_CountsLetterScore_FullWord()
    {
      string testInput = "rdasgfjk,sjkgl snlfka";
      int testScore = 54;
      int result = ScoreGenerator.GenerateScore(testInput);
      Assert.Equal(testScore, result);
    }


  }
}

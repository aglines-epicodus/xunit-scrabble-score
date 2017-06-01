using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      //code
      Get["/"] = _ => View["index.cshtml"];

      Post["/"] = _ => {
        string userInput = Request.Form["user-input"];
        int score = ScoreGenerator.GenerateScore(userInput);
        string scoreAsString = score.ToString();
        // bool isValidWord = Object.Method(userInput);

        Dictionary<string, string> model = new Dictionary<string, string>{};

        model.Add("input", userInput);
        model.Add("score", scoreAsString);
        return View["index.cshtml", model];
      };
    }
  }
}

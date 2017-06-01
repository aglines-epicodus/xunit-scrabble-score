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
      Get["/"] = _ => "hello world!";
    }
  }
}

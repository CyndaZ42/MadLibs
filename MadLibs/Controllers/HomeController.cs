using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult InsertNameHere() { return View(); }

    [Route("/libs")]
    public ActionResult Libs(string verbing, string verbing2, string verbing3, string verbing4, string adjective, string adjective2, string adjective3, string pluralNoun, string pluralNoun2, string pluralNoun3, string pluralNoun4, string noun, string noun2, string noun3, string game, string plant, string bodyPart, string place, string number)
    {
      PageVariable myPageVariable = new PageVariable();
      myPageVariable.Verbing = verbing;
      myPageVariable.Verbing2 = verbing2;
      myPageVariable.Verbing3 = verbing3;
      myPageVariable.Verbing4 = verbing4;
      myPageVariable.Adjective = adjective;
      myPageVariable.Adjective2 = adjective2;
      myPageVariable.Adjective3 = adjective3;
      myPageVariable.PluralNoun = pluralNoun;
      myPageVariable.PluralNoun2 = pluralNoun2;
      myPageVariable.PluralNoun3 = pluralNoun3;
      myPageVariable.PluralNoun4 = pluralNoun4;
      myPageVariable.Noun = noun;
      myPageVariable.Noun2 = noun2;
      myPageVariable.Noun3 = noun3;
      myPageVariable.Game = game;
      myPageVariable.Plant = plant;
      myPageVariable.BodyPart = bodyPart;
      myPageVariable.Place = place;
      myPageVariable.Number = number;
      return View(myPageVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}
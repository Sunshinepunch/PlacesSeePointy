using Microsoft.AspNetCore.Mvc;

namespace Places.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
    public ActionResult Index() 
    {
      Diary newDiary = new Diary();
      newDiary.CityName = "Phoenix";
      return View(newDiary);
      }

      [Route("/diary")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/diary")]
    public ActionResult Create(string description)
    {
    }

     [HttpPost("/diary/delete")]
    public ActionResult DeleteAll()
    {
      NEEDSHARDCODINGDOESNTEXIST.ClearAll();
      return View();
    }
  }
}
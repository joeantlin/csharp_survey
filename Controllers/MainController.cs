using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers     //be sure to use your own project's namespace!
{
    public class MainController : Controller   //remember inheritance??
    {

        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("method")]
        public RedirectToActionResult Method(string Name, string Location, string Language, string Comment)
        {
            var myobject = new {
                name = Name,
                location = Location,
                language = Language,
                comment = Comment
            };
            return RedirectToAction("Result", myobject);
        }
        [HttpGet]       //type of request
        [Route("result")]     //associated route string (exclude the leading /)
        public ViewResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}
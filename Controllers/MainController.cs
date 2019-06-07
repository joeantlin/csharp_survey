using Microsoft.AspNetCore.Mvc;
using Survey.Models;

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
        public RedirectToActionResult Method(SurveyInfo survey)
        {
            return RedirectToAction("Result", survey);
        }

        [HttpGet]       //type of request
        [Route("result")]     //associated route string (exclude the leading /)
        public IActionResult Result(SurveyInfo survey)
        {
            return View(survey);
        }
    }
}
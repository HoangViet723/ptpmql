using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh2002.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index()(String FullName)

        {
            string strReturn = "Hello" + FullName;
            viewBag.xyz = strReturn;
            return View();

        }


        public IActionResult About()
        {
            return View();
        }
    }
}
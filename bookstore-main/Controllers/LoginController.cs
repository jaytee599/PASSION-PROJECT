using Microsoft.AspNetCore.Mvc;

namespace system.Controllers;
public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
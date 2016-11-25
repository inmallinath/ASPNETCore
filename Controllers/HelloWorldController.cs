using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Index Action";
        }

        public string Welcome()
        {
            return "Welcome Action";
        }
    }
}
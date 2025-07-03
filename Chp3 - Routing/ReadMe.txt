Routing
Routing in ASP.NET Core is the mechanism that maps incoming URLs to controller actions, Razor pages, or endpoints.

Two Types of Routing
1. Conventional Routing (MVC)
Common in controller-based apps.
Uses route patterns like:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
Example URL: /Products/Details/5 → ProductsController.Details(5)

2. Attribute Routing
Routes defined directly on controller methods using [Route] attributes:
[Route("products/{id}")]
public IActionResult GetProduct(int id) { ... }

Comparison:             Convention-Based                    Attribute-Based Routing
Feature	                Convention-Based        	        Attribute-Based
Defined in	            MapControllerRoute in Program.cs	[Route], [HttpGet], [HttpPost] on controller/action
Centralized routing	    ✅ Yes	                            ❌ No
Per-action 
customization           ❌ Limited	                        ✅Full control per action
Example URL	            /Home/Index	                        /home/index or /submit (customizable)

******************************************* Attribute Based Routing Example *****************************************************
public class HelloController : Controller{
    [Route ("")]
    [Route ("Home" )]
    [Route ("Home/Index")]
    public IActionResult Data(){
        return View("~/Views/Home/Index.cshtm]");
    }
}
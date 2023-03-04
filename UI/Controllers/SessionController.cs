using Microsoft.AspNetCore.Mvc;
using UI.Extensions;

namespace UI.Controllers
{
	public class SessionController : Controller
	{
		public int Id { get; set; } = 55;
		public string Demo { get; set; } = "Use Session";


		public string Index1()
		{

			Customer customer = new Customer { Id = 1, Name = "Taha" };
			HttpContext.Session.SetObject("object", customer);
			return "Obje oluştu";

			//HttpContext.Session.SetString("Session", "Demo");
			//return Demo;
		}

		public IActionResult Index2()
		{
			var customer = HttpContext.Session.GetObject<Customer>("object");
			return View (customer);
			//return HttpContext.Session.GetString("Session");
		}

	}
}

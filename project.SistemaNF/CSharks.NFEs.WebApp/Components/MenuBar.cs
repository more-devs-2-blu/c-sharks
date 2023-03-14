using CSharks.NFEs.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CSharks.NFEs.WebApp.Components
{
    public class MenuBar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string userSession = HttpContext.Session.GetString("userSession")!;

            if (string.IsNullOrEmpty(userSession))
            {
                return null;
            }

            User user = JsonConvert.DeserializeObject<User>(userSession)!;

            return View(user);
        }
    }
}

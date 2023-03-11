using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Newtonsoft.Json;

namespace CSharks.NFEs.WebApp.Services
{
    public class UserSession : ISessionService
    {
        
        private readonly IHttpContextAccessor _httpContext;

        public UserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor;
        }
        
        public void CreateSession(User user)
        {
            string json = JsonConvert.SerializeObject(user);
            _httpContext.HttpContext.Session.SetString("userSession", json);
            
        }

        public User GetSession()
        {
            //string userSession = _httpContext.HttpContext.Session.GetString("userSession");
            //if (string.IsNullOrEmpty(userSession)) return null;
            // return JsonConvert.DeserializeObject<UsuarioModel>(userSession);

            throw new NotImplementedException();

        }

        public void RemoveSession()
        {
            _httpContext.HttpContext.Session.Remove("userSession");
        }
    }
}

using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;

namespace CSharks.NFEs.Services.Services
{
    public class Session : ISessionService
    {


        /*
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor;
        }
        
        public void CreateSession(User user)
        {
            string json = JsonConvert.SerializeObject(user);
            _httpContext.HttpContext.Session.SetString("userSession", json);
            
        }
        */
        public void CreateSession(User user)
        {
            throw new NotImplementedException();

        }


        public User GetSession()
        {
            throw new NotImplementedException();
        }

        public void RemoveSession()
        {
            throw new NotImplementedException();
        }
    }
}

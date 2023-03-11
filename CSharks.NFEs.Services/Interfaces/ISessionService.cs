using CSharks.NFEs.Domain.Models;

namespace CSharks.NFEs.Services.Interfaces
{
    public interface ISessionService
    {
        void CreateSession(User user);
        void RemoveSession();
        User GetSession();
    }
}

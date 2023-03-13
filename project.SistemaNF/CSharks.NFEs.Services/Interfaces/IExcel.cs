using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF_UTILS;

namespace CSharks.NFEs.Services.Interfaces
{
    public interface IExcel
    {
        List<ISQN> ReadISQNFromExcel(string pathFile);
        List<TOM> ReadTOMFromExcel(string pathFile);
    }
}

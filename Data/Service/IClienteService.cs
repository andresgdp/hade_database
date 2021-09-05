using hade_database.Data.Model;
using System.Threading.Tasks;

namespace hade_database.Data.Service
{
    public interface IClienteService
    {
        Task<bool> ClienteInsert(Cliente cliente);
        Task<bool> ClienteUpdate(Cliente cliente);
    }
}
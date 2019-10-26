using Parking.Domain;
using System.Threading.Tasks;
namespace Parking.Service
{
    public interface IUserService
    {
         Task<bool> Create(User user);
         Task<bool> Update(User entity);
    }
}
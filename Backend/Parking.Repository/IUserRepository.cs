using System.Threading.Tasks;
using Parking.Domain;

namespace Parking.Repository
{
    public interface IUserRepository
    {
         Task<bool> Create(User user);
         Task<bool> Update(User entity);
       
    }
}
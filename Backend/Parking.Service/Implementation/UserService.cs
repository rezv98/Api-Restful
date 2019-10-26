
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Repository;

namespace Parking.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository){
                this.userRepository=userRepository;
        }
        public Task<bool> Create(User user)
        {
            return userRepository.Create(user);
        }

        public Task<bool> Update(User entity)
        {
           return  userRepository.Update(entity);
        }
    }
}
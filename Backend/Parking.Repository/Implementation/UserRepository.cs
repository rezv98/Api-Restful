using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Parking.Domain;

namespace Parking.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<IdentityUser> userManager;
        public UserRepository(UserManager<IdentityUser> userManager)
        {
            this.userManager=userManager;
        }

        public async Task<bool> Create(User user)
        {
            var flag=false;

            var newUser =new IdentityUser{
                UserName=user.Email,
                Email=user.Email
            };
            var result=await userManager.CreateAsync(newUser,user.Password);
            if (result.Succeeded){
                flag=true;
            }
            return flag;
           
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(User entity)
        {
            
            
        throw new System.NotImplementedException();

        }

        public async Task<bool> Update(User entity)
        {
            var flag=false;
            var user= await userManager.FindByEmailAsync(entity.Email);
            var result= await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                flag=true;
            }
           
            return flag;
        }
        
    }
}
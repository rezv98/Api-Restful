using Parking.Domain;
using Parking.Service;
using Microsoft.AspNetCore.Mvc;


namespace Parking.Api.Controllers
{
    [Route("api/accounts")]
    public class AccountController:ControllerBase
    {
        private readonly IUserService userService;
        public AccountController(IUserService userService){
            this.userService=userService;
        }
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            return Ok(
                this.userService.Create(user)
            );
        }

    }
}
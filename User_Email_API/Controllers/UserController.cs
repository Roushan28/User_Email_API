using Microsoft.AspNetCore.Mvc;

namespace User_Email_API.Controllers
{
    [ApiController]
   // [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;        
        public UserController( IUserService userService)
        {            
            _userService = userService;
        }

        [HttpGet("users/{id}")]
        public string GetUserEmailByID(int id)
        {
           return  _userService.GetUserEmailByID(id);
        }

    }
}

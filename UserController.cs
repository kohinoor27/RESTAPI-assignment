using Microsoft.AspNetCore.Mvc;
using WebApplication1.Managers;

namespace WebApplication1.Controllers


{
    [ApiController]
    [Route("[controller]")]

    public class UserController : Controller
    {
        IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;

        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var responce = _userManager.GetAllUser();
            return Ok(responce);
        }

        [HttpGet("users/get")]

        public IActionResult GetUserById(int id)
        {
            var res = _userManager.GetUserById(id);
            return Ok(res);
        }

        [HttpPost("users/add")]

        public IActionResult AddUser([FromBody] User user)
        {
            var res = _userManager.AddUser(user);
            return Ok(res);
        }

        [HttpPut("users/update")]

        public IActionResult UpdateUser(int id)
        {
            var res = _userManager.UpdateUser(id);
            return Ok(res);
        }

        [HttpDelete("users/delete")]

        public IActionResult DeleteUser(int id)
        {
            var res = _userManager.DeleteUser(id);
            return Ok(res);
        }




    }
    public class User
    {
        public int Id { get; set; }
        public int phone { get; set; }

    }
}


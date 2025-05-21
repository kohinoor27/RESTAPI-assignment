using WebApplication1.Controllers;

namespace WebApplication1.Managers
{
    public class UserManager : IUserManager

    {
      
        public string AddUser(User user)
        {
            return "User Added";
        }
        public string GetAllUser()
        {
            return "All User recieved";
        }
        public string GetUserById(int id)
        {
            return "User of the Id given";

        }
        public string UpdateUser(int id)
        {
            return "User Updated";
        }
        public string DeleteUser(int id)
        {
            return "User Deleted";
        }
    }
}

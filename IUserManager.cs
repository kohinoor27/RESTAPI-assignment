using WebApplication1.Controllers;

namespace WebApplication1.Managers
{
    public interface IUserManager
    {
        
        public string GetAllUser();
        public string GetUserById(int id);

        public string AddUser(User user);
        public string UpdateUser(int id);
        public string DeleteUser(int id);

    }
}

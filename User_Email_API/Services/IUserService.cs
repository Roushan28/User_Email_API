using System.Collections.Generic;
using System.Threading.Tasks;

namespace User_Email_API.Controllers
{
    public interface IUserService
    {
         string GetUserEmailByID(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace User_Email_API.Controllers
{
    public class UserService : IUserService
    {        

        public string GetUserEmailByID(int id)
        {

            List<User> aSingleObj = new();
            aSingleObj.Add(new User { Id = 1, Name = "TestUser1", EmailID = "george.bluth@reqres.in" });
            aSingleObj.Add(new User { Id = 3, Name = "TestUser1", EmailID = "emma.wong@reqres.in" });
            aSingleObj.Add(new User { Id = 10, Name = "TestUser1", EmailID = "byron.fields@reqres.in" });

            return aSingleObj.Where(c => c.Id == id).Select(c => c.EmailID).FirstOrDefault();

        }



        

      

    }
}
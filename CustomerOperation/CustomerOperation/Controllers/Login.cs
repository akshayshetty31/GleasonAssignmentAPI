using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOperation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [EnableCors(PolicyName ="CorsPolicy")]
    public class Login : Controller
    {
        public List<Users> usersList = new List<Users>() { new Users() { userName = "akshay", password ="akshay123"},
        new Users() { userName="venkat", password="venkat@123"} };
        
        [HttpGet("{userName}/{pwd}")]
        [DisableCors]
        public bool Get(string userName, string pwd)
        {
            //ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Origin", "http://localhost:4200");
            int index = usersList.FindIndex(x=>  x.userName == userName && x.password == pwd);
            if(index >=0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}

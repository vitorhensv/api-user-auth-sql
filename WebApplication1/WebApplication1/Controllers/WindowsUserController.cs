using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowsUserController : ControllerBase
    {

        [HttpGet]
        public string GetUser()
        {

            return "Nome do usuário atual: " + Environment.UserName;

        }
    }
}

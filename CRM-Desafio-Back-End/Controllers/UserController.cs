using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;
using CRM_Desafio_Back_End.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Desafio_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface _userInterface;
        public UserController(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> ListarUsers()
        {
            var users = await _userInterface.listarUsers();
            return Ok(users);
        }
    }
}

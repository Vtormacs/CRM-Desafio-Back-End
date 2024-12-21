using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;
using CRM_Desafio_Back_End.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Desafio_Back_End.Controllers
{
    [Route("api/v1/users")]
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

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseModel<UserModel>>> BuscarUserPorId(int id)
        {
            var user = await _userInterface.buscarUserPorId(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> CriarUser([FromBody] UserCriacaoDto userCriacaoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var users = await _userInterface.criarUser(userCriacaoDto);
            return Ok(users);
        }
    }
}
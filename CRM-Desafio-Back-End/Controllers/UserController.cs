using CRM_Desafio_Back_End.Dtos.User;
using CRM_Desafio_Back_End.Model;
using CRM_Desafio_Back_End.Models;
using CRM_Desafio_Back_End.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Desafio_Back_End.Controllers
{
    /// <summary>
    /// Controlador para gerenciar operações relacionadas a usuários.
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userInterface;

        /// <summary>
        /// Construtor para injetar dependências.
        /// </summary>
        /// <param name="userInterface">Interface de serviço de usuário.</param>
        public UserController(IUserService userInterface)
        {
            _userInterface = userInterface;
        }

        /// <summary>
        /// Lista todos os usuários.
        /// </summary>
        /// <returns>Modelo de resposta contendo a lista de usuários.</returns>
        [HttpGet]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> ListarUsers()
        {
            var users = await _userInterface.listarUsers();
            return Ok(users);
        }

        /// <summary>
        /// Busca um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo de resposta contendo o usuário.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseModel<UserModel>>> BuscarUserPorId(int id)
        {
            var user = await _userInterface.buscarUserPorId(id);
            return Ok(user);
        }

        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        /// <param name="userCriacaoDto">Objeto DTO contendo as informações do usuário a ser criado.</param>
        /// <returns>Modelo de resposta contendo a lista de usuários atualizada.</returns>
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

        /// <summary>
        /// Exclui um usuário pelo ID.
        /// </summary>
        /// <param name="id">ID do usuário.</param>
        /// <returns>Modelo de resposta contendo o usuário excluído.</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseModel<UserModel>>> ExcluirUser(int id)
        {
            var user = await _userInterface.excluirUser(id);
            return Ok(user);
        }
    }
}

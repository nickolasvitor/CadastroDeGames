using Microsoft.AspNetCore.Mvc;
using CadastroGames.Models.Games.GamesImput;
using CadastroGames.GameAppServices;
using CadastrarGames.BD.GamesBD;
namespace CadastroGames.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarGames(GameImput gameImput)
        {
            var obj = Services.inserirDados(gameImput);
            return Created("",obj);
        }

        [HttpGet]
        [Route ("listar")]
        public IActionResult ListarGames()
        {
            var obj=  Consulta.listar();
            return Ok(obj);
        }





    } 
    
    
    
      
}
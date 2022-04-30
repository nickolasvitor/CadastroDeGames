using Microsoft.AspNetCore.Mvc;
using CadastroGames.Models.Games.GamesImput;
using CadastroGames.GameAppServices;
using CadastrarGames.BD.GamesBD;
using CadastroGames.Models.Games.Games;
namespace CadastroGames.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController : ControllerBase
    {
        [HttpPost]
        public IActionResult POST(GameImput gameImput)
        {
            var obj = Services.inserirDados(gameImput);
            return Created("",obj);
        }

        [HttpPost]
        [Route ("alterar/")]
        public IActionResult POST(Games game)
        {
            var obj = Services.alterarDados(game);
            return Created("",obj);
        }
        

        [HttpGet]
        public IActionResult GET()
        {
            var obj=  Consulta.ListarTodos();
            return Ok(obj);
        }

        [HttpGet]
        [Route ("nome/{nome}")] //Por algum motivo as chaves estão entrando na consulta, duas soluções.. Ou manda no Front sem as aspas ou tira as aspas no backend
        public IActionResult GETBYNAME([FromRoute]string nome)
        {
            var obj=  Consulta.ListarPorNome(nome);
            return Ok(obj);
        }

        [HttpGet]
        [Route ("id/{id}")]
        public IActionResult GETBYID([FromRoute]Guid id)
        {
            var obj=  Consulta.ListarPorId(id);
            return Ok(obj);
        }
         [HttpDelete]
        [Route ("{id}")]
        public IActionResult DELETE([FromRoute]Guid id)
        {   
            Consulta.DeletarByID(id);
            return Ok();
        }





    } 
    
    
    
      
}
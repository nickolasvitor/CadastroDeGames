using CadastroGames.Models.Games.GamesImput;
using CadastroGames.Models.Games.Games;
using CadastroGames.Models.Games.GamesString;
using CadastrarGames.BD.GamesBD;
using System.Text.Json;



namespace CadastroGames.GameAppServices
{
    public class Services
    {
        
        

        //Recebe um post da API e preenche com base no imput, a variavel Game
        public static object inserirDados(GameImput imput)
        {
            Games Game = new Games(imput.nome,Guid.NewGuid().ToString(),imput.anolancamento,imput.multiplayer,imput?.genero,1);
            Consulta consulta = new Consulta();
            consulta.PostInserir(Game.id,Game.nome,Game.anolancamento,Game.multiplayer,Game.genero,Game.existe);
            return Game;
        }
        public static List<GamesString> GetAll()
        {
            string JsonString = Consulta.GetListarAll();
            List<GamesString> gamesString = JsonSerializer.Deserialize<List<GamesString>>(JsonString);
           
           /* foreach (var item in gamesString)
            {
            Console.WriteLine($"Nome: {item.NOME}");
            Console.WriteLine($"ID: {item.}");
            Console.WriteLine($"ANOLANCAMENTO: {item.ANOLANCAMENTO}");
            Console.WriteLine($"GENERO: {item.GENERO}"); 
            }*/
            
           
        
            return gamesString;
        }

        public static object alterarDados(Games Game)
        {
        
            Consulta consulta = new Consulta();
            consulta.PostAlterar(Game.id,Game.nome,Game.anolancamento,Game.multiplayer,Game.genero,Game.existe);
            return Game;
        }
      
    }
}
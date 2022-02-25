
using System.ComponentModel.DataAnnotations;
namespace CadastroGames.Models.Games.GamesImput
{
    public class GameImput
    {
       
        [Required(ErrorMessage="O nome é obrigatório")]
        public string? nome {get;set;} 
        [Required(ErrorMessage="O ano de lançamento é obrigatório")]
        public int anolancamento{get;set;}
        [Required(ErrorMessage="O item multiplayer é obrigatório")]
        public int multiplayer{get;set;}
        [Required(ErrorMessage="O gênero é obrigatório")]
        public string? genero{get;set;}


       /*  public GameImput(string nome, string id, int anolancamento, int multiplayer, string genero, int existe)
        {
            this.nome = nome;
            this.anolancamento= anolancamento;
            this.multiplayer=multiplayer;
            this.genero=genero;
            
        }*/
    }
}
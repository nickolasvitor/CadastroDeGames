

namespace CadastroGames.Models.Games.Games
{
    public class Games
    {
        public string nome {get;set;}
        public string id{get;set;}
        public int anolancamento{get;set;}
        public int multiplayer{get;set;}
        public string genero{get;set;}
        public int existe{get;set;}

        public Games(string nome, string id, int anolancamento, int multiplayer, string genero, int existe)
        {
            this.nome = nome;
            this.id =id;
            this.anolancamento= anolancamento;
            this.multiplayer=multiplayer;
            this.genero=genero;
            this.existe=existe;
        }
    }
}
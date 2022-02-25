

namespace CadastroGames.Models.Games.GamesString
{
    public class GamesString
    {
        //Os atributos estão em maiúsculo porque assim foi declarado no banco de dados, quando mudo aqui para de funcionar//
        public string? ID{get;set;}
        public string?  NOME {get;set;}
        public string? ANOLANCAMENTO{get;set;}
        public string? MULTIPLAYER{get;set;}
        public string? GENERO{get;set;}
        public string? EXISTE{get;set;}

        /*public GamesString(string nome, string id, string anolancamento, string multiplayer, string genero, string existe)
        {
            this.nome = nome;
            this.id =id;
            this.anolancamento= anolancamento;
            this.multiplayer=multiplayer;
            this.genero=genero;
            this.existe=existe;
        }*/
    }
}
using System.Data.SqlClient; //dotnet add package System.Data.SqlClient --version 4.8.3
using System.Data;
using System.Text;
using CadastroGames.BD;
using System.Collections.Generic;
using CadastroGames.Models.Games.GamesString;
using System.Text.Json;
using Newtonsoft.Json.Linq;//dotnet add package Newtonsoft.Json --version 12.0.3
using System.Threading.Tasks;





namespace CadastrarGames.BD.GamesBD
{

    public  class Consulta 
    {
        
      
        
        public void PostInserir(string id,string nome,int anolancamento,int multiplayer,string genero,int existe)
        {
        
             
            
           
            
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ("INSERT INTO CAD_GAMES (ID,NOME,ANOLANCAMENTO,MULTIPLAYER,GENERO,EXISTE) VALUES(@ID,@NOME,@ANOLANCAMENTO,@MULTIPLAYER,@GENERO,@EXISTE)");

            SqlCommand comando =new SqlCommand(strSQL,conexao);
            comando.Parameters.AddWithValue("@ID",id);
            comando.Parameters.AddWithValue("@NOME",nome);
            comando.Parameters.AddWithValue("@ANOLANCAMENTO",anolancamento);
            comando.Parameters.AddWithValue("@MULTIPLAYER",multiplayer);
            comando.Parameters.AddWithValue("@GENERO",genero);
            comando.Parameters.AddWithValue("@EXISTE",existe);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
           
            
         }
         public static string GetListarAll()
        {
            
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ("SELECT* FROM CAD_GAMES");
            DataTable dt = new DataTable();

            SqlDataAdapter da= new SqlDataAdapter(strSQL,conexao);
            da.Fill(dt);
            string resultado = JsonConverter.DataTable_JSON_StringBuilder(dt);
            
          
            
            //string teste = @"[{""ID"":""d9980726-e818-4739-91b2-5258313f2e3e"",""NOME"":""Dota 2"",""ANOLANCAMENTO"":""2013"",""MULTIPLAYER"":""1"",""GENERO"":""MOBA"",""EXISTE"":""1""},{""ID"":""7b38e34a-8d69-4c6c-a4ca-0a1798e31c15"",""NOME"":""League of Legends"",""ANOLANCAMENTO"":""2009"",""MULTIPLAYER"":""1"",""GENERO"":""MOBA"",""EXISTE"":""1""}]";
            
           
            conexao.Close();
  

        
            return resultado;
        
        }
         public static string GetListarByName(string nome)
        {   
            // SqlDataReader leitor;
            DataTable dt = new DataTable();
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ($"SELECT* FROM CAD_GAMES WHERE NOME LIKE '%{nome}%'");
            Console.WriteLine(strSQL);
            SqlDataAdapter da= new SqlDataAdapter(strSQL,conexao);
            da.Fill(dt);
            string resultado = JsonConverter.DataTable_JSON_StringBuilder(dt);

            conexao.Close();
           
            return resultado;
        
        }
          public static string GetListarByID(Guid id)
        {
            Console.WriteLine(id);
            // SqlDataReader leitor;
            DataTable dt = new DataTable();
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ($"SELECT* FROM CAD_GAMES WHERE ID LIKE '%{id}%'");
            Console.WriteLine(strSQL);
            SqlDataAdapter da= new SqlDataAdapter(strSQL,conexao);
            da.Fill(dt);
            string resultado = JsonConverter.DataTable_JSON_StringBuilder(dt);

            conexao.Close();
           
            return resultado;
        
        }
        public static void DeletarByID(Guid id)
        {
            // SqlDataReader leitor;
            
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ($"DELETE FROM CAD_GAMES WHERE ID = '{id}'");
            
            SqlCommand comando =new SqlCommand(strSQL,conexao);
            

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
           
        }
        public void  PostAlterar(string id,string nome,int anolancamento,int multiplayer,string genero,int existe)
        {
            Console.WriteLine(nome);
            SqlConnection conexao = new SqlConnection(@"Password=games123;Persist Security Info=True;User ID=sa;Initial Catalog=games;Data Source=DESKTOP-F2DE4L4\SQLEXPRESS");
            string strSQL  = ($"UPDATE CAD_GAMES SET NOME='{nome}',ANOLANCAMENTO={anolancamento},MULTIPLAYER={multiplayer},GENERO='{genero}', EXISTE={existe} WHERE ID = '{id}'");
            Console.WriteLine(strSQL);
            SqlCommand comando =new SqlCommand(strSQL,conexao);
          

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
           
            
         }
       
        public static object ListarTodos()
        {
            var obj= GetListarAll();
            return obj;
        }
        public static object ListarPorNome(string nome)
        {
            var obj= GetListarByName(nome);
            return obj;
        }
        public static object ListarPorId(Guid  id)
        {
            var obj= GetListarByID(id);
            return obj;
        }
         
         
    }
}
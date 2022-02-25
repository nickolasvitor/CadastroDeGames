using System.Data;
using System.Text;






namespace CadastroGames.BD
{
    public class JsonConverter
    {
        

        //Essa função lê tabelas e transforma em JSON, mas os valores são todos salvos como string
        public static string DataTable_JSON_StringBuilder(DataTable tabela)
        {
            var JSONString = new StringBuilder();
            if (tabela.Rows.Count > 0)
            {
                JSONString.Append(@"[");
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < tabela.Columns.Count; j++)
                    {
                        if (j < tabela.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + tabela.Columns[j].ColumnName.ToString() + "\":" + "\"" + tabela.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == tabela.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + tabela.Columns[j].ColumnName.ToString() + "\":" + "\"" + tabela.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == tabela.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }
        
        
    }
    
}
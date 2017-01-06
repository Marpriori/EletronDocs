using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electron.Docs.Tables
{
    public class DBhelperClass
    {
        string dbConnection = "Data Source=" + ConfigurationManager.AppSettings["database"];
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {

                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public void ValidarBaseDados(string tabela, string[] colunas)
        {
            string sql = string.Format("PRAGMA table_info({0})", tabela);
            DataTable retorno = GetDataTable(sql);

            if (retorno.Rows.Count == 0)
            {
                //não existe tabela - Criar tabela inteira

                return;
            }
            //existe tabela - verificar campos
            List<string> colunasTabela = retorno.Rows.Cast<DataRow>().Select(c=>c["name"] as string).ToList();

            foreach (var coluna in colunas)
            {
                if (colunasTabela.Contains(coluna))
                    continue;

                //aqui deve incluir coluna na tabela
            }


        }
    }
}

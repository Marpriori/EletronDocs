using Electron.Docs.Tables.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Electron.Docs.Tables.Designer.Atributos;
using Electron.Docs.Tables.Entidades.Configuracao;

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

        public void ExecuteQuery(string sql)
        {
            try
            {

                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                int linhasAfetadas = mycommand.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ValidarBaseDados()
        {
            var entidades = ListaEntidades();
            foreach (var entidade in entidades)
            {
                ValidarTabela(entidade.Name, CamposTabela(entidade));
            }
        }

        public void ValidarTabela(string tabela, PropertyInfo[] colunas)
        {
            tabela = tabela.ToUpperInvariant();
            string sql = string.Format("PRAGMA table_info({0})", tabela);
            DataTable retorno = GetDataTable(sql);

            if (retorno.Rows.Count == 0)
            {
                //não existe tabela - Criar tabela somente com ID
                var sqlCreateTable = string.Format("CREATE  TABLE \"main\".\"{0}\" (\"ID\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL )",tabela);
                ExecuteQuery(sqlCreateTable);
                retorno = GetDataTable(sql);
            }
            //existe tabela - verificar campos
            List<string> colunasTabela = retorno.Rows.Cast<DataRow>().Select(c => c["name"] as string).ToList();

            foreach (var coluna in colunas)
            {
                var nomeCampo = coluna.Name.ToUpperInvariant();
                if (colunasTabela.Contains(nomeCampo))
                    continue;

                //aqui deve incluir coluna na tabela
                var sqlIncluirCampoTabela = "ALTER TABLE \"main\".\"{0}\" ADD COLUMN \"{1}\" TEXT";
                sqlIncluirCampoTabela = string.Format(sqlIncluirCampoTabela,tabela, nomeCampo);
                
                ExecuteQuery(sqlIncluirCampoTabela);
            }

        }

        public IList<Type> ListaEntidades()
        {
            var type = typeof(ITabela);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsClass && type.IsAssignableFrom(p));
            return types.ToList();
        }

        public PropertyInfo[] CamposTabela(Type entidade)
        {
            var propriedades = new List<PropertyInfo>();
            foreach (var propertyInfo in entidade.GetProperties())
            {
                var ehPropriedadeBanco = propertyInfo.GetCustomAttributes(true).Any(a => a is CampoTabelaAttribute);
                if (ehPropriedadeBanco)
                    propriedades.Add(propertyInfo);
            }

            return propriedades.ToArray();
        }


    }
}

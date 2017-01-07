namespace Electron.Docs.Tables.Designer.Atributos
{
    public class CampoTabelaAttribute : System.Attribute
    {
        public readonly string Default;
        public readonly string Nome;

        public CampoTabelaAttribute()
            :this(null, null)
            {
        }

        public CampoTabelaAttribute(string nome)
            :this(nome, null)
        {
            
        }
        public CampoTabelaAttribute(string nome, string _default)
        {
            Default = _default;
            Nome = nome;
        }
    }
}

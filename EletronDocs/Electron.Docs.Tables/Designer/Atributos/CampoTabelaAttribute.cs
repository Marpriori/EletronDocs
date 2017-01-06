namespace Electron.Docs.Tables.Designer.Atributos
{
    public class CampoTabelaAttribute : System.Attribute
    {
        public readonly string Default;

        public CampoTabelaAttribute()
            :this(null)
        {
            
        }
        public CampoTabelaAttribute(string _default)
        {
            Default = _default;
        }
    }
}

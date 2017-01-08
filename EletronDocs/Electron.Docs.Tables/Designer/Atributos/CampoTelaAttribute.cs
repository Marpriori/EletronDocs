
using System;
namespace Electron.Docs.Tables.Designer.Atributos
{
    public class CampoTelaAttribute : Attribute
    {
        public readonly string Aba;
        public readonly string Rotulo;
        public readonly TipoCampo TipoCampo;
        public TamanhoCampo Tamanho = TamanhoCampo.Tamanho12;

        public CampoTelaAttribute(string aba, string rotulo, TipoCampo tipoCampo)
        {
          
            Aba = aba;
            Rotulo = rotulo;
            TipoCampo = tipoCampo;
        }

        public CampoTelaAttribute(string aba, string rotulo)
            : this(aba, rotulo, TipoCampo.TEXTO)
        {
        }
    }
    public enum TipoCampo
    {
        TEXTO,
        INTEIRO,
        DATA,
        LISTA,
        TABELA
    }
    public enum TamanhoCampo: int
    {
        Tamanho1 = 1 ,
        Tamanho2 = 2 ,
        Tamanho3 = 3 ,
        Tamanho4 = 4 ,
        Tamanho5 = 5 ,
        Tamanho6 = 6 ,
        Tamanho7 = 7 ,
        Tamanho8 = 8 ,
        Tamanho9 = 9 ,
        Tamanho10 =10,
        Tamanho11 =11,
        Tamanho12 =12

    }
}

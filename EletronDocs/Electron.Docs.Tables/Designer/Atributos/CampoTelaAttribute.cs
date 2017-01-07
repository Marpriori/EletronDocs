﻿
using System;
namespace Electron.Docs.Tables.Designer.Atributos
{
    public class CampoTelaAttribute : Attribute
    {
        public readonly string Aba;
        public readonly string Rotulo;
        public readonly TipoCampo TipoCampo;

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
}
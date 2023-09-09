using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_academia";
        public static string caminhoBanco = caminho + "\\banco\\";
    }
}

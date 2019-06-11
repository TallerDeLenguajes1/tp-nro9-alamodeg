using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    static public class HelperMorse
    {
        public static string Codificar(string cadena)
        {
            int i;
            string codificado = "";
            for (i = 0; i < cadena.Length; i++)
            {
                switch (cadena[i])
                {
                    case ' ':
                        codificado = string.Concat(codificado, "   "); break;
                    case 'a':
                        codificado = string.Concat(codificado, "._|"); break;
                    case 'b':
                        codificado = string.Concat(codificado, "—···|"); break;
                    case 'c':
                        codificado = string.Concat(codificado, "—·—·|"); break;
                    case 'd':
                        codificado = string.Concat(codificado, "—··|"); break;
                    case 'e':
                        codificado = string.Concat(codificado, "·|"); break;
                    case 'f':
                        codificado = string.Concat(codificado, ".._.|"); break;
                    case 'g':
                        codificado = string.Concat(codificado, "__.|"); break;
                    case 'h':
                        codificado = string.Concat(codificado, "....|"); break;
                    case 'i':
                        codificado = string.Concat(codificado, "..|"); break;
                    case 'j':
                        codificado = string.Concat(codificado, ".___|"); break;
                    case 'k':
                        codificado = string.Concat(codificado, "_._|"); break;
                    case 'l':
                        codificado = string.Concat(codificado, "._..|"); break;
                    case 'm':
                        codificado = string.Concat(codificado, "__|"); break;
                    case 'n':
                        codificado = string.Concat(codificado, "—.|"); break;
                    case 'o':
                        codificado = string.Concat(codificado, "___|"); break;
                    case 'p':
                        codificado = string.Concat(codificado, ".__.|"); break;
                    case 'q':
                        codificado = string.Concat(codificado, "__._|"); break;
                    case 'r':
                        codificado = string.Concat(codificado, "._.|"); break;
                    case 's':
                        codificado = string.Concat(codificado, "...|"); break;
                    case 't':
                        codificado = string.Concat(codificado, "_|"); break;
                    case 'u':
                        codificado = string.Concat(codificado, ".._|"); break;
                    case 'v':
                        codificado = string.Concat(codificado, "..._|"); break;
                    case 'w':
                        codificado = string.Concat(codificado, ".__|"); break;
                    case 'x':
                        codificado = string.Concat(codificado, "_.._|"); break;
                    case 'y':
                        codificado = string.Concat(codificado, "_.__|"); break;
                    case 'z':
                        codificado = string.Concat(codificado, "__..|"); break;
                    case '0':
                        codificado = string.Concat(codificado, "_____|"); break;
                    case '1':
                        codificado = string.Concat(codificado, ".____|"); break;
                    case '2':
                        codificado = string.Concat(codificado, "..___|"); break;
                    case '3':
                        codificado = string.Concat(codificado, "...__|"); break;
                    case '4':
                        codificado = string.Concat(codificado, "...._|"); break;
                    case '5':
                        codificado = string.Concat(codificado, ".....|"); break;
                    case '6':
                        codificado = string.Concat(codificado, "_....|"); break;
                    case '7':
                        codificado = string.Concat(codificado, "__...|"); break;
                    case '8':
                        codificado = string.Concat(codificado, "___..|"); break;
                    case '9':
                        codificado = string.Concat(codificado, "____.|"); break;
                    default:
                        codificado = string.Concat(codificado, "@@@|"); break;
                }
            }
            //Console.WriteLine("{0}", codificado);
            cadena = codificado;
            return cadena;
            Console.ReadKey();

        }
        public static void Decodificador(string cadena)
        {
            int i;
            string codificado = "";
            for (i = 0; i < cadena.Length; i++)
            {
                switch (cadena[i])
                {
                    case ' ':
                        codificado = string.Concat(codificado, " "); break;
                    case 'a':
                        codificado = string.Concat(codificado, "._"); break;
                    case 'b':
                        codificado = string.Concat(codificado, ""); break;
                    case 'c':
                        codificado = string.Concat(codificado, ""); break;
                    case 'd':
                        codificado = string.Concat(codificado, ""); break;
                    case 'e':
                        codificado = string.Concat(codificado, ""); break;
                    case 'f':
                        codificado = string.Concat(codificado, ""); break;
                    case 'g':
                        codificado = string.Concat(codificado, ""); break;
                    case 'h':
                        codificado = string.Concat(codificado, ""); break;
                    case 'i':
                        codificado = string.Concat(codificado, ""); break;
                    case 'j':
                        codificado = string.Concat(codificado, ""); break;
                    case 'k':
                        codificado = string.Concat(codificado, ""); break;
                    case 'l':
                        codificado = string.Concat(codificado, ""); break;
                    case 'm':
                        codificado = string.Concat(codificado, ""); break;
                    case 'n':
                        codificado = string.Concat(codificado, ""); break;
                    case 'o':
                        codificado = string.Concat(codificado, ""); break;
                    case 'p':
                        codificado = string.Concat(codificado, ""); break;
                    case 'q':
                        codificado = string.Concat(codificado, ""); break;
                    case 'r':
                        codificado = string.Concat(codificado, ""); break;
                    case 's':
                        codificado = string.Concat(codificado, ""); break;
                    case 't':
                        codificado = string.Concat(codificado, ""); break;
                    case 'u':
                        codificado = string.Concat(codificado, ""); break;
                    case 'v':
                        codificado = string.Concat(codificado, ""); break;
                    case 'w':
                        codificado = string.Concat(codificado, ""); break;
                    case 'x':
                        codificado = string.Concat(codificado, ""); break;
                    case 'y':
                        codificado = string.Concat(codificado, ""); break;
                    case 'z':
                        codificado = string.Concat(codificado, ""); break;
                    case '0':
                        codificado = string.Concat(codificado, ""); break;
                    case '1':
                        codificado = string.Concat(codificado, ""); break;
                    case '2':
                        codificado = string.Concat(codificado, ""); break;
                    case '3':
                        codificado = string.Concat(codificado, ""); break;
                    case '4':
                        codificado = string.Concat(codificado, ""); break;
                    case '5':
                        codificado = string.Concat(codificado, ""); break;
                    case '6':
                        codificado = string.Concat(codificado, ""); break;
                    case '7':
                        codificado = string.Concat(codificado, ""); break;
                    case '8':
                        codificado = string.Concat(codificado, ""); break;
                    case '9':
                        codificado = string.Concat(codificado, ""); break;
                    default:
                        codificado = "@@@"; string.Concat(codificado, " "); break;
                }
            }
        }
    }
}
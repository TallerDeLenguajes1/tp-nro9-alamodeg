using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Helper;

namespace tp9
{
    class conversorDeMorse
    {
       
        
        static void Main(string[] args)
        {
            string cadena,morsa;
            Console.WriteLine("Ingrese texto");
            cadena=Console.ReadLine();
            //string cadenafea = ".-/.-"
            morsa=HelperMorse.Codificar(cadena);
            Console.WriteLine(morsa);
            Console.ReadKey();

            
        }
    }
}

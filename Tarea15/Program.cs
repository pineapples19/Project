using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas l = new Listas();
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            Console.WriteLine("\n\n La lista de nodos ingresada es: ");
            l.desplegarListas();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15
{
    internal class Listas
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Listas()
        {
            Primero = null;
            Ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Ingrese el dato que contendra el nuevo Nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;


            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;

            }
            Console.WriteLine("\n Nodo Ingresado\n ");
        }
        

            public void desplegarListas()
            {
                Nodo Actual = new Nodo();
                Actual = Primero;
                if (Primero!=null) 
                {
                while(Actual != null)
                {
                    Console.WriteLine(" {0} ", Actual.Dato);
                    Actual = Actual.Siguiente;

                }
            }
                else 
            {
                Console.WriteLine("\n La lista se encuentra vacia\n");
            }
            }
        }
    }

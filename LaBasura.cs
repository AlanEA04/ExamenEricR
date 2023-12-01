using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExamenEricR
//{
//    internal class LaBasura
//    {


//        using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Nodo
//    {
//        public string Nombre { get; set; }
//        public int Edad { get; set; }
//        public Nodo Siguiente { get; set; }
//    }

//    public class ListaEnlazada
//    {
//        private Nodo Primero;

//        // Método para insertar al final de la lista
//        public void InsertarAlFinal(string nombre, int edad)
//        {
//            Nodo nuevo = new Nodo
//            {
//                Nombre = nombre,
//                Edad = edad
//            };

//            if (Primero == null)
//            {
//                Primero = nuevo;
//            }
//            else
//            {
//                Nodo actual = Primero;
//                while (actual.Siguiente != null)
//                {
//                    actual = actual.Siguiente;
//                }
//                actual.Siguiente = nuevo;
//            }

//            Console.WriteLine("Nodo Ingresado");
//        }

//        // Método para buscar una persona en la lista por nombre
//        public void BuscarPersona(string nombreBuscado)
//        {
//            Nodo actual = Primero;
//            int posicion = 0;

//            while (actual != null)
//            {
//                if (actual.Nombre == nombreBuscado)
//                {
//                    Console.WriteLine($"La persona {nombreBuscado} se encuentra en la posición {posicion} de la lista.");
//                    return;
//                }

//                actual = actual.Siguiente;
//                posicion++;
//            }

//            Console.WriteLine($"La persona {nombreBuscado} no se encuentra en la lista.");
//        }

//        // Método para imprimir todos los elementos de la lista ordenados por edad
//        public void ImprimirOrdenadoPorEdad()
//        {
//            var listaOrdenada = ObtenerListaOrdenadaPorEdad();

//            Console.WriteLine("\nElementos de la lista ordenados por edad:");
//            foreach (var nodo in listaOrdenada)
//            {
//                Console.WriteLine($"Nombre: {nodo.Nombre}, Edad: {nodo.Edad}");
//            }
//        }

//        // Método privado para obtener la lista ordenada por edad
//        private List<Nodo> ObtenerListaOrdenadaPorEdad()
//        {
//            List<Nodo> lista = new List<Nodo>();
//            Nodo actual = Primero;

//            while (actual != null)
//            {
//                lista.Add(actual);
//                actual = actual.Siguiente;
//            }

//            return lista.OrderBy(nodo => nodo.Edad).ToList();
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            ListaEnlazada lista = new ListaEnlazada();

//            // Permitir al usuario ingresar nombres y edades
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"Ingrese el nombre {i + 1}:");
//                string nombre = Console.ReadLine();

//                Console.WriteLine($"Ingrese la edad {i + 1}:");
//                int edad = int.Parse(Console.ReadLine());

//                lista.InsertarAlFinal(nombre, edad);
//            }

//            // Permitir al usuario ingresar el nombre a buscar
//            Console.WriteLine("Ingrese el nombre a buscar:");
//            string nombreBuscar = Console.ReadLine();
//            lista.BuscarPersona(nombreBuscar);

//            // Imprimir todos los elementos de la lista ordenados por la edad
//            lista.ImprimirOrdenadoPorEdad();
//        }
//    }
//}
//}

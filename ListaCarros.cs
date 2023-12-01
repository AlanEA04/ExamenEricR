using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEricR
{
    public class ListaCarros
    {
        private Nodo Primero;
        private Nodo Ultimo;




        public void Insertar(string marca, string modelo, int año)
        {
            Nodo Nuevo = new Nodo
            {
                Marca = marca,
                Modelo = modelo,
                Año = año,

            };

            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nodo actual = Primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;

                }
                actual.Siguiente = Nuevo;

            }

        }

        public void BuscarModelo(string marcaoBuscado)
       {
            Nodo actual = Primero;          
            int posicion = 0;

            while (actual != null)
                  {
                        if (actual.Marca == marcaoBuscado)
                      {
                          Console.WriteLine($"La persona {marcaoBuscado} se encuentra en la posición {posicion} de la lista.");
                           return;
                      }

                        actual = actual.Siguiente;
                     posicion--;
                    }

                  Console.WriteLine($"La persona {marcaoBuscado} no se encuentra en la lista.");
               }


        public void ImprimirDatos()
        {

        }

        public void ImprimirOrdenoAño()
        {


            Console.WriteLine("ElementosOrdenadosPorAño");
            var listaOrdenada = ObtenerListaOrdenadaPorAño();

            foreach (var nodo in listaOrdenada)
            {

                Console.WriteLine($"Marca {nodo.Marca}, Modelo {nodo.Modelo},  Año {nodo.Año}");
            }


        }

        private List<Nodo> ObtenerListaOrdenadaPorAño()
        {
            List<Nodo> Nuevo = new List<Nodo>();
            Nodo actual = Primero;
            while (actual != null)
            {
                Nuevo.Add(actual);
                actual = actual.Siguiente;
            }
            return Nuevo.OrderBy(nodo => nodo.Año).ToList();




        }
    }
}










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

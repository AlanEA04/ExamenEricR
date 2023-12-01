using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenEricR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaCarros K = new ListaCarros();



            for (int i = 0; i <2; i++ )
            {
                Console.WriteLine($"ingresa la marca  {i + 1}:");
                string Marca = Console.ReadLine();
                Console.WriteLine($"Ingresar Modelo {i + 1}:");
                string Modelo = Console.ReadLine();
                Console.WriteLine($"Ingresa el Año de salida{i + 1}");
                int Año = int .Parse( Console.ReadLine());


                K.Insertar(Marca,Modelo,Año);


              
            }


            K.ImprimirOrdenoAño();


            Console.WriteLine("Ingrese la marca  a buscar:");
            string marcaoBuscado = Console.ReadLine();
            K.BuscarModelo(marcaoBuscado);


        }
    }
}





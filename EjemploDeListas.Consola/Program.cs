using System.ComponentModel;

namespace EjemploDeListas.Consola
{
    internal class Program
    {
        static List<int> numeros=new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists!");
            do
            {
                string opcionSeleccionada;
                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1-Ingresar Número");
                Console.WriteLine("2-Listar Datos");
                Console.WriteLine("3-Borrar Número por valor");
                Console.WriteLine("4-Borrar por Posición");
                Console.WriteLine("5-Modificar Número");
                Console.WriteLine("6-Ordenar Ascendente");
                Console.WriteLine("7-Ordenar Descendente");
                Console.WriteLine("x-Salir");
                Console.Write("Ingrese selección:");
                opcionSeleccionada = Console.ReadLine();
                switch (opcionSeleccionada)
                {
                    case "1":
                        IngresoDeDatos();
                        break;
                    case "2":
                        MostrarDatos();
                        break;
                    case "3":
                        BorrarNumeroPorValor();
                        break;
                    case "4":
                        BorrarNumeroPorPosicion();
                        break;
                    case "5":
                        ModificarDatos();
                        break;
                    case "6":
                        OrdenarAscendente();
                        break;
                    case "7":
                        OrdenarDescendente();
                        break;
                    case "x":
                        break;
                }
                if (opcionSeleccionada=="x")
                {
                    break;
                }
            }while (true);
            Console.WriteLine("Fin del Programa");

        }

        private static void OrdenarDescendente()
        {
            Console.Clear();
            Console.WriteLine("Lista Ordenada Descendente");
            numeros = numeros.OrderByDescending(n => n).ToList();
            ListarDatos();
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

        }

        private static void OrdenarAscendente()
        {
            MostrarTitulo("Lista Ordenada Ascendente");
            numeros = numeros.OrderBy(n => n).ToList();
            ListarDatos();
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

        }

        private static void MostrarTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
        }

        private static void ModificarDatos()
        {
           
            MostrarTitulo("Modificar Número de la Lista");
            ListarDatos();
            Console.Write("Ingrese el valor a buscar:");
            var valorBuscado = int.Parse(Console.ReadLine());
            if (numeros.IndexOf(valorBuscado)==-1)
            {
                Console.WriteLine("Valor inesistente!!!");
            }
            else
            {
                Console.WriteLine($"Valor en la posición:{numeros.IndexOf(valorBuscado)}");
                Console.Write("Ingrese un nuevo valor:");
                var nuevoValor = int.Parse(Console.ReadLine());
                numeros[numeros.IndexOf(valorBuscado)] = nuevoValor;
                Console.WriteLine("Valor modificado!!!");
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();
        }

        private static void BorrarNumeroPorPosicion()
        {
            MostrarTitulo("Borrar  Por posición");
            ListarDatos();
            Console.Write("Ingrese la posición a borrar:");
            var posicionBorrar = int.Parse(Console.ReadLine());
            if (posicionBorrar>=0 && posicionBorrar<numeros.Count)
            {
                numeros.RemoveAt(posicionBorrar);
                Console.WriteLine("Valor removido!!!");
            }
            else
            {
                Console.WriteLine("Índice fuera del rango!!!");
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();
        }

        private static void BorrarNumeroPorValor()
        {
            MostrarTitulo("Borrar Número Por valor");
            ListarDatos();
            Console.Write("Ingrese el valor a borrar:");
            var valorBorrar = int.Parse(Console.ReadLine());
            if (numeros.Remove(valorBorrar))
            {
                Console.WriteLine("Valor removido!!!");
            }
            else
            {
                Console.WriteLine("Valor inesistente!!!");
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

        }

        private static void ListarDatos()
        {
            if (numeros.Count > 0)
            {
                Console.WriteLine("Pos\tNúmero");
                for (int i = 0; i < numeros.Count; i++)
                {
                    Console.WriteLine($"{i}\t{numeros[i]}");
                }
                Console.WriteLine($"Listado finalizado!!!");

            }
            else
            {
                Console.WriteLine("No hay datos!!!");
            }
        }

        private static void MostrarDatos()
        {
            MostrarTitulo("Listar contenido de la lista");
            ListarDatos();
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

        }

        private static void IngresoDeDatos()
        {
            MostrarTitulo("Ingreso de datos a la lista");
            Console.Write("Ingrese un valor entero:");
            var nroIngresado = int.Parse(Console.ReadLine());
            if (!numeros.Contains(nroIngresado))
            {
                numeros.Add(nroIngresado);
                Console.WriteLine($"{nroIngresado} agregado!!!");

            }
            else
            {
                Console.WriteLine("Número repetido!!!");
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();
        }
    }
}

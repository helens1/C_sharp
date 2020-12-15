using System;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacion info = new Informacion();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ventas");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Venta");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Reporte de Ventas");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        info.ListarProductos();
                        break;
                    case "2":
                        info.CrearVenta();
                        break;
                    case "3":
                        info.ListarClientes();
                        break;
                    case "4":
                        info.ListarEmpleados();
                        break;      
                    case "5":
                        info.ListarVenta();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
public class Informacion
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Empleado> ListadeEmpleados { get; set; }
    public List<Venta> ListaVentas { get; set; }

    public Informacion()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeEmpleados = new List<Empleado>();
        cargarEmpleados();

        ListaVentas = new List<Venta>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Sistema de sonido TEKNO", 739.00);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Televisor LG", 8990.00);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Laptop DELL", 16990.00);
        ListadeProductos.Add(p3);
        
        Producto p4 = new Producto(4, "Laptop HP ", 14890.00);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Tablet Amazon Fire 7 OCRE", 1990.00 );
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Tablet Samsung Galaxy", 8990.00);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, " Celular Samsung A51", 8690.00);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "Celular Samsung A11 ", 4190.00);
        ListadeProductos.Add(p8);

    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Pedro", "99999");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Camila", "56208");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Paola", "72594");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Bruno", "01982");
        ListadeClientes.Add(c5);
    }

    private void cargarEmpleados()
    {
        Empleado e1 = new Empleado(1, "Jose", "e001");
        ListadeEmpleados.Add(e1);

        Empleado e2 = new Empleado(2, "Pablo", "e002");
        ListadeEmpleados.Add(e2);

        Empleado e3 = new Empleado(3, "Gabriel", "e003");
        ListadeEmpleados.Add(e3);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarEmpleados()
    {
        Console.Clear();
        Console.WriteLine("Lista de Empleados");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var empleado in ListadeEmpleados)
        {
            Console.WriteLine(empleado.Codigo + " | " + empleado.Nombre + " | " + empleado.CodigoEmpleado);
        }

        Console.ReadLine();
    }

    public void CrearVenta()
    {
        Console.WriteLine("Creando Venta");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del empleado: ");
        string codigoEmpleado = Console.ReadLine();

        Empleado empleado = ListadeEmpleados.Find(e => e.Codigo.ToString() == codigoEmpleado);
        if (empleado == null) 
        {
            Console.WriteLine("Empleado no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Empleado: " + empleado.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaVentas.Count + 1;

        Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, empleado);
        ListaVentas.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Subtotal de la venta es de: " + nuevaVenta.Subtotal);
        Console.WriteLine("Impuesto de la venta es de: " + nuevaVenta.Impuesto);
        Console.WriteLine("Total de la venta es de: " + nuevaVenta.Total);
        Console.ReadLine();
    }

    public void ListarVenta()
    {
        Console.Clear();
        Console.WriteLine("Reporte de Venta");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha y Hora | Subtotal | Impuesto |Total");
        Console.WriteLine("Cliente | Empleado");
        Console.WriteLine("======================");
        Console.WriteLine("");  

        foreach (var venta in ListaVentas)
        {
            Console.WriteLine(venta.Codigo + " | " + venta.Fecha + " | " + venta.Subtotal + " | " + venta.Impuesto + " | " + venta.Total);
            Console.WriteLine(venta.Cliente.Nombre + " | " + venta.Empleado.Nombre);
            
            foreach (var detalle in venta.ListaVentaDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}
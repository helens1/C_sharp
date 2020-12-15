using System;
using System.Collections.Generic;

public class Venta
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeVenta { get; set; }
    public Cliente Cliente { get; set; }
    public Empleado Empleado { get; set; }
    public List<VentaDetalle> ListaVentaDetalle { get; set; }
    public double Total { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }

    public Venta(int codigo, DateTime fecha, string numeroVenta, Cliente cliente, Empleado empleado)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeVenta = numeroVenta;
        Cliente = cliente;
        Empleado = empleado;
        ListaVentaDetalle = new List<VentaDetalle>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaVentaDetalle.Count + 1;
        int cantidad = 1;

        VentaDetalle v = new VentaDetalle(nuevoCodigo, 1, producto);
        ListaVentaDetalle.Add(v);

        Subtotal += cantidad * producto.Precio;

        Impuesto = Subtotal * 0.15;

        Total = Subtotal + Impuesto;
    }
}
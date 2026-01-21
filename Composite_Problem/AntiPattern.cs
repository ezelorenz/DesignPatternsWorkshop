using System;
using System.Collections.Generic;

namespace Composite_Problem
{
	public class Producto
	{
		public string Nombre { get; set; }
		public decimal Precio { get; set; }
		public Producto(string n, decimal p) { Nombre = n; Precio = p; }
	}

	public class Caja
	{
		// Contiene productos o otras cajas -> usa object para favorecer el cast
		public List<object> Items { get; } = new List<object>();
	}

	public class Inventario
	{
		// Rompe la transparencia usando 'is' para diferenciar tipos
		public decimal CalcularPrecioTotal(IEnumerable<object> items)
		{
			decimal total = 0;
			foreach (var item in items)
			{
				if (item is Caja)
				{
					var caja = (Caja)item;
					total += CalcularPrecioTotal(caja.Items);
				}
				else if (item is Producto)
				{
					total += ((Producto)item).Precio;
				}
				else
				{
					// Manejo difuso de tipos
					Console.WriteLine("Tipo desconocido en inventario");
				}
			}
			return total;
		}
	}
}


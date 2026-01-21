using System;
using System.Threading;

namespace Proxy_Problem
{
	// Servicio real que simula una API externa lenta
	public class CotizadorDolarReal
	{
		public decimal ObtenerPrecio()
		{
			// Simula latencia de red y costo por llamada
			Thread.Sleep(2000);
			var rnd = new Random();
			return 750m + (decimal)rnd.NextDouble() * 10m;
		}
	}

	// Cliente que, en vez de usar un proxy/caché, llama al servicio real cada vez
	public class ClienteCotizador
	{
		public void MostrarPrecios()
		{
			var servicio = new CotizadorDolarReal();
			for (int i = 0; i < 3; i++)
			{
				var precio = servicio.ObtenerPrecio();
				Console.WriteLine($"Precio {i}: {precio}");
			}
		}
	}
}


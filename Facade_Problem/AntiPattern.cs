using System;

namespace Facade_Problem
{
	public class BuróCredito { public bool Verificar(string persona) { return true; } }
	public class Banco { public bool RevisarSaldo(string cliente) { return true; } }
	public class Notaria { public bool RevisarDocumentos(string expediente) { return true; } }
	public class AntecedentesPenales { public bool Consultar(string dni) { return true; } }

	// Cliente que instancia y llama a cada servicio uno por uno (sin fachada)
	public static class ProcesoPrestamoCliente
	{
		public static void EjecutarPrestamo(string cliente)
		{
			var buro = new BuróCredito();
			try
			{
				var okBuro = buro.Verificar(cliente);
				if (!okBuro) { Console.WriteLine("Rechazado por buro"); return; }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error buro: " + ex.Message);
				return;
			}

			var banco = new Banco();
			try
			{
				var okBanco = banco.RevisarSaldo(cliente);
				if (!okBanco) { Console.WriteLine("Rechazado por banco"); return; }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error banco: " + ex.Message);
				return;
			}

			var notaria = new Notaria();
			try
			{
				var okNotaria = notaria.RevisarDocumentos(cliente);
				if (!okNotaria) { Console.WriteLine("Rechazado por notaria"); return; }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error notaria: " + ex.Message);
				return;
			}

			var ap = new AntecedentesPenales();
			try
			{
				var okAp = ap.Consultar(cliente);
				if (!okAp) { Console.WriteLine("Rechazado por antecedentes"); return; }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error antecedentes: " + ex.Message);
				return;
			}

			Console.WriteLine("Prestamo aprobado para: " + cliente);
		}
	}
}


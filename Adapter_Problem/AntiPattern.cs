using System;

namespace Adapter_Problem
{
	// Simulación de una librería legacy en español antiguo que recibe XML
	public class LegacyBancoXmlApi
	{
		public string ProcesarCobroDesdeXml(string xml)
		{
			// Responde según contenido del XML (muy frágil)
			if (xml.Contains("<Monto>"))
				return "RESPUESTA: OK";

			return "RESPUESTA: ERROR";
		}

		public string ObtenerEstadoPago(string referenciaXml)
		{
			return "PAGADO";
		}
	}

	// Servicio moderno que, en vez de adaptar, llama DIRECTAMENTE a la API legacy
	public class CobroService
	{
		private readonly LegacyBancoXmlApi _legacy = new LegacyBancoXmlApi();

		// Lógica de negocio incrustada que construye XML manualmente y acopla todo
		public bool CobrarCliente(string clienteId, decimal monto, string ordenId)
		{
			// Construcción manual de XML como string (frágil y propenso a errores)
			var xml = "<Pago>" +
					  "<Orden>" + ordenId + "</Orden>" +
					  "<Cliente>" + clienteId + "</Cliente>" +
					  "<Monto>" + monto + "</Monto>" +
					  "</Pago>";

			// Llamada directa a la librería legacy (sin adapter, sin abstracción)
			var respuesta = _legacy.ProcesarCobroDesdeXml(xml);

			// Lógica de negocio basada en parsing de strings
			if (respuesta.Contains("OK"))
			{
				// Almacena información de pago mezclada aquí (simulada)
				Console.WriteLine("Cobro realizado: " + ordenId);
				return true;
			}

			Console.WriteLine("Cobro fallido: " + ordenId + " -> " + respuesta);
			return false;
		}
	}
}


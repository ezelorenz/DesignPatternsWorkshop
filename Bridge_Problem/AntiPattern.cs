using System;

namespace Bridge_Problem
{
	// Abuso de herencia para combinar tipo y plataforma -> explosión de clases
	public abstract class Mensaje
	{
		public string Contenido;
		protected Mensaje(string contenido) { Contenido = contenido; }
		public abstract void Enviar();
	}

	public class MensajeUrgenteEmail : Mensaje
	{
		public MensajeUrgenteEmail(string c) : base(c) { }
		public override void Enviar() { Console.WriteLine("URGENTE - EMAIL: " + Contenido); }
	}

	public class MensajeInfoEmail : Mensaje
	{
		public MensajeInfoEmail(string c) : base(c) { }
		public override void Enviar() { Console.WriteLine("INFO - EMAIL: " + Contenido); }
	}

	public class MensajeUrgenteSMS : Mensaje
	{
		public MensajeUrgenteSMS(string c) : base(c) { }
		public override void Enviar() { Console.WriteLine("URGENTE - SMS: " + Contenido); }
	}

	public class MensajeInfoSMS : Mensaje
	{
		public MensajeInfoSMS(string c) : base(c) { }
		public override void Enviar() { Console.WriteLine("INFO - SMS: " + Contenido); }
	}
}


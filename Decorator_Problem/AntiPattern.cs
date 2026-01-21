using System;

namespace Decorator_Problem
{
	// Explosión de clases heredadas para combinar características
	public class CuentaAhorro
	{
		public decimal Saldo { get; protected set; }
		public CuentaAhorro(decimal saldoInicial) { Saldo = saldoInicial; }
		public virtual void Depositar(decimal monto) { Saldo += monto; }
		public virtual bool Retirar(decimal monto)
		{
			if (Saldo >= monto) { Saldo -= monto; return true; }
			return false;
		}
	}

	public class CuentaAhorroBlindada : CuentaAhorro
	{
		public CuentaAhorroBlindada(decimal s) : base(s) { }
		public override bool Retirar(decimal monto)
		{
			Console.WriteLine("Verificando blindaje físico y permisos...");
			return base.Retirar(monto);
		}
	}

	public class CuentaAhorroConNotificacion : CuentaAhorro
	{
		public CuentaAhorroConNotificacion(decimal s) : base(s) { }
		public override void Depositar(decimal monto)
		{
			base.Depositar(monto);
			Console.WriteLine("Enviando notificación por depósito.");
		}
	}

	public class CuentaAhorroBlindadaYConNotificacion : CuentaAhorroBlindada
	{
		public CuentaAhorroBlindadaYConNotificacion(decimal s) : base(s) { }
		public override void Depositar(decimal monto)
		{
			base.Depositar(monto);
			Console.WriteLine("Enviando notificación desde clase compuesta.");
		}
	}
}


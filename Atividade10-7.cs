using System;  
using System.Collections.Generic;

 class ContaBancaria
 {
 	double SaldoTotal = 0;
 	
 	public void Deposito()
 	{		
 		Console.WriteLine("Qual valor deseja depositar: ");
 		double valor;
 		bool valido = double.TryParse(Console.ReadLine(), out valor);
 			
 		if (!valido || valor <= 0)
 		{
 			Console.WriteLine("Valor inválido.");
 			return;
 		}
 		
 		Console.Clear();
 		Console.WriteLine("Valor depositado com sucesso.\n\r");
 		SaldoTotal += valor;
 		
 	}
	
 	public void Saque()
 	{	
 		Console.WriteLine("R$ " +SaldoTotal+ ",00");
 		
 		Console.WriteLine("Qual valor deseja sacar?");
 		double ValorSaque = double.Parse(Console.ReadLine());
 		
 		if (ValorSaque > SaldoTotal)
 		{
 			Console.WriteLine("Erro! Valor do saque maior que o saldo.");
 			return;
 		}
 		
 		Console.Clear();
 		SaldoTotal -= ValorSaque;
 		Console.WriteLine("Valor sacado com sucesso. Saldo disponível R$ {0:F2}.",SaldoTotal );
 	}	
 	
 	public void ConferirSaldo()
 	{
 		Console.WriteLine("R$ {0:F2}", SaldoTotal);
 	}
 	
 }

class Program
{	
	static void Main()
	{
		ContaBancaria contaBanc = new ContaBancaria();
	
	while(true)
	{	
		Console.WriteLine("=====================");
		Console.WriteLine("1.Depósito");
		Console.WriteLine("2.Verificar saldo");
		Console.WriteLine("3.Saque");
		Console.WriteLine("4.Sair");
		Console.WriteLine("=====================");
		
		Console.WriteLine("\n\rQual operação deseja realizar?");
		string opcao = Console.ReadLine();
		
		Console.Clear();
		
		switch(opcao)
		{
			case "1":
					
				contaBanc.Deposito();
				break;
				
			case "2":
					
				contaBanc.ConferirSaldo();
				break;
			
			case "3":
			
				contaBanc.Saque();
				break;				
							
			case "4":
				
				Console.WriteLine("Saindo...");
				return;
				
			default:
				Console.WriteLine("Opção inválida. Tente novamente.");
				break;
				
		}
		Console.ReadKey(true);
	  }
	}
	
}

				

using System;
using System.Collections.Generic;

 class Banco
 {
 	string[,] Contas = new string[1, 3];
 	int contador = 0;
 	double SaldoTotal = 0;
 	
 	public string AbrirConta()
 	{
 		if (contador >= 1)
 		{
 			return "Limite de contas atingido!";
 		}
 		
 		Console.WriteLine("\n\rDigite seu CPF: ");
 		string CPF = Console.ReadLine();
 		
 		Console.WriteLine("\n\rNome completo: ");
 		string Nome = Console.ReadLine();
 		
 		Console.WriteLine("\n\rSenha: ");
 		string Senha = Console.ReadLine();
 		
 		Contas[contador, 0] = CPF;
 		Contas[contador, 1] = Nome;
 		Contas[contador, 2] = Senha;
 		
 		contador++;
 		
 		return "Conta criada com êxito.";
 		
 	}
 	
 	public string FecharConta()
 	{
 		
 		if (contador == 0)
 		{
 			return "Nenhuma conta para excluir.";
 		}
 		
 		Console.WriteLine("Digite o CPF da conta que deseja excluir: ");
 		string cpfExcluir = Console.ReadLine().ToLower();
 			
 				if (Contas[0, 0] == cpfExcluir)
 				{
 					Console.WriteLine("Tem certeza que deseja exlcuir essa conta? (sim/não): ");
 					string escolha = Console.ReadLine().ToLower();
 					
 					if (escolha == "sim")
 					{	
 						Contas[0, 0] = null;
 						Contas[0, 1] = null;
 						Contas[0, 2] = null;
 						
 						contador--;		
 						
 						return "Conta excluída com êxito";
 					}
 					
 					else
 					{
 						return "Operação cancelada";
 					}	
 				}
 				
 		return "Conta não encontrada!";
 	}
 	
 	public void Deposito()
 	{
 		if (contador == 0)
 		{
 			Console.WriteLine("Não existe conta para realizar um depósito.");
 			return;
 		}
 		
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
 	
 }

class Program
{	
	static void Main()
	{
		Banco banc = new Banco();
	
	while(true)
	{	
		Console.WriteLine("=====================");
		Console.WriteLine("1.Criar conta");
		Console.WriteLine("2.Fechar conta");
		Console.WriteLine("3.Depósito");
		Console.WriteLine("4.Saque");
		Console.WriteLine("5.Sair");
		Console.WriteLine("=====================");
		
		Console.WriteLine("\n\rQual operação deseja realizar?");
		string opcao = Console.ReadLine();
		
		Console.Clear();
		
		switch(opcao)
		{
			case "1":
					
				string AConta = banc.AbrirConta();
				Console.WriteLine("\n" + AConta);
				Console.Clear();
				break;
				
			case "2":
					
				string FConta = banc.FecharConta();
				Console.WriteLine("\n" + FConta);
				Console.Clear();
				break;
			
			case "3":
			
				banc.Deposito();
				break;				
			
			case "4":
					
				banc.Saque();
				break;	
				
			case "5":
				
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

				

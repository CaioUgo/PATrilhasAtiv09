using System;
using System.Collections.Generic;

 class Aluno
 { 	
 	double[] notas = new double[4];
 	double soma = 0;
 	
 	public void NotasAluno()
 	{
 		for (int i = 0; i < notas.Length; i++)
 		{
 			Console.WriteLine("Nota {0} do aluno: ", i+1);
 			notas[i] = double.Parse(Console.ReadLine());

 			soma += notas;		
 		}
 		return;
 	}
 	
 	public void Media()
 	{
 		mediaNotas = soma / notas.Length;
 		Console.WriteLine("A média das notas do aluno é {0:F1}.", Media);
 		return;
 	}
 	
 	public void MostrarNotas()
 	{
 		for (int i = 0; i < notas.Length; i++)
 		{
 			Console.WriteLine("Nota {0} do aluno: {1}", i+1, notas[i]);
 	}
 		return;
 }

class Program
{	
	static void Main()
	{
		Produto prod = new Produto();
	
	while(true)
	{	
		Console.WriteLine("=====================");
		Console.WriteLine("1.Inserir notas aluno");
		Console.WriteLine("2.Inserir preço unitário");
		Console.WriteLine("3.Ver quantidade de produtos");
		Console.WriteLine("4.Ver preço unitário");
		Console.WriteLine("5.Ver preço total do produto");
		Console.WriteLine("6.Sair");
		Console.WriteLine("=====================");
		
		Console.WriteLine("\n\rQual operação deseja realizar?");
		string opcao = Console.ReadLine();
		
		Console.Clear();
		
		switch(opcao)
		{
			case "1":
					
				prod.QuantidadeProduto();
				break;
				
			case "2":
					
				prod.PrecoUnitario();
				break;
			
			case "3":
			
				prod.MostrarQuantidade();
				break;				
			
			case "4":
					
				prod.MostrarPreçoUnitario();
				break;	
				
			case "5":
					
				prod.ValorTotal();
				break;
				
			case "6":
				
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

				

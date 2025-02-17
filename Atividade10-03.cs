using System;
using System.Collections.Generic;

 class Produto
 { 	
 	int quantidade = 0;
 	double precounitario = 0;
 	
 	public void QuantidadeProduto()
 	{
 		Console.WriteLine("Qual é a quantidade de produtos: ");
 		quantidade = int.Parse(Console.ReadLine());
 		
 		if (quantidade <= 0)
 		    {
 		    	Console.WriteLine("Quantidade de produtos inválida.");
 				return;
 		    }
 		
 		Console.Clear();	
 		Console.WriteLine("Quantidade de produto atualizada com sucesso.\n\r");
 		return;
 	}
 	
 	public void PrecoUnitario()
 	{
 		Console.WriteLine("Qual é o preço unitário do produto: ");
 		precounitario = double.Parse(Console.ReadLine());
 		
 		if (precounitario <= 0)
 		    {
 		    	Console.WriteLine("Preço unitário inválido.");
 				return;
 		    }

 		Console.Clear();
 		Console.WriteLine("Preço unitário atualizado com sucesso.");
 		return;
 	}
 	
 	public void MostrarQuantidade()
 	{
 		Console.WriteLine("A quantidade de produtos é {0}.", quantidade);
 		return;
 	}
	
 	public void MostrarPreçoUnitario()
 	{	
 		Console.WriteLine("O preço unitário dos produtos é R$ {0}.", precounitario);
 		return;
 	}
 	
 	public void ValorTotal()
 	{	
 		double ValorTotal = precounitario * quantidade;
 		Console.WriteLine("O preço total do produto é R$ {0:F2},00", ValorTotal);
 		return;
 	}
 	
 }

class Program
{	
	static void Main()
	{
		Produto prod = new Produto();
	
	while(true)
	{	
		Console.WriteLine("=====================");
		Console.WriteLine("1.Inserir quantidade de produtos");
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

				

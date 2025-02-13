using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<string> palavras = new List<string>();

			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			string entrada = Console.ReadLine();
			palavras.Add(entrada);
			}
			Console.Clear();
		
		string maior = palavras[0];
			
		foreach (string palavra in palavras)
		{
			if (palavra.Length > maior.Length)
			{
				maior = palavra;
			}
		}
		
		Console.WriteLine("\n\rA maior string da lista é {0}.", maior);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				

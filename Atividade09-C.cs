using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<int> inteiros = new List<int>();

			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			int entrada = int.Parse(Console.ReadLine());
			inteiros.Add(entrada);
			}
			Console.Clear();

		int maior = inteiros[0];
			
		foreach (int numero in inteiros)
		{
			if (numero > maior)
			{
				maior = numero;
			}
		}
		
		Console.WriteLine("\n\rO maior número da lista é {0}.", maior);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				

using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho do vetor: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		int[] inteiros = new int[tamanho];

			for (int i = 0; i < inteiros.Length; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			inteiros[i] = int.Parse(Console.ReadLine());
			}
			Console.Clear();

		Console.WriteLine("Os elementos do vetor são: ");
			
		foreach (int numero in inteiros)
		{
			Console.Write(numero + " ");
		}
		Console.WriteLine();
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				

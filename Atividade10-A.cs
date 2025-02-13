using System;
using System.Collections.Generic;

 class Calculadora 
 {
 	public int Somar(int a, int b){
 		return a + b;
 	}
	
 	public int Subtrair(int a, int b){
 		return a - b;
 	}
	
 	public double Dividir(int a, int b){
 		return a / b;
 	}
	
 	public double Multiplicar(int a, int b){
 		return a * b;
 	}
 	
 	public double RaizQuadrada(int a){
 		return Math.Sqrt(a);
 	}

 }

class Program
{
	static void Main()
	{	
		Console.WriteLine("1.Somar");
		Console.WriteLine("2.Subtrair");
		Console.WriteLine("3.Dividir");
		Console.WriteLine("4.Multiplicar");
		Console.WriteLine("5.Elevar");
		
		Console.WriteLine("Qual operação deseja realizar?");
		
		Console.WriteLine("\n\rA média dos números da lista é {0:F2}",media);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				

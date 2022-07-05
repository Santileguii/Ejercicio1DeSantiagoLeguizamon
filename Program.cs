using System;

namespace Ejercicio1DeSantiagoLeguizamon
{
    class Program
    {
        static void Main(string[] args)
        {
			double conversion;
			double distanciarecorrida;
			double tiempo;
			double velocidad;
			Console.WriteLine("Algoritmo para calcular distancia y convertirla a kms");
			Console.Write("Por favor ingresar velocidad en m/s: ");
			velocidad = Double.Parse(Console.ReadLine());
			Console.Write("Por favor ingresar el tiempo en s: ");
			tiempo = Double.Parse(Console.ReadLine());
			distanciarecorrida = velocidad * tiempo;
			conversion = distanciarecorrida * 0.001;
			Console.WriteLine("la distancia recorrida es " + distanciarecorrida + " metros");
			Console.WriteLine("la distancia convertida es de " + conversion + "kms");
		}

	}

}


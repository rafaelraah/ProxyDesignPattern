using System;

namespace ProxyDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criar o math proxy
            MathProxy proxy = new MathProxy();
            
            // Fazer os cálculos
            Console.WriteLine("5 + 2 = " + proxy.Add(5, 2));
            Console.WriteLine("5 - 2 = " + proxy.Sub(5, 2));
            Console.WriteLine("5 * 2 = " + proxy.Mul(5, 2));
            Console.WriteLine("5 / 2 = " + proxy.Div(5, 2));
            
            //Esperar finalização do usuário
            Console.ReadKey();
        }
    }
}

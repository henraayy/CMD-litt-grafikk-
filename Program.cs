using System;
using System.Threading;

namespace NTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = "*";
            bool increasing = true;  //sjekker om det blir lagt til eller fjernes stjerner

            while (true)  //uendelig loop
            {
                Console.WriteLine(symbol);
                
                if (increasing)
                {
                    symbol += "*";  //legger til en stjerne
                    if (symbol.Length >= 10)
                    {
                        increasing = false;  //bytt til å fjerne stjerner når den når 10
                    }
                }
                else
                {
                    symbol = symbol.Remove(symbol.Length - 1);  //fjerner en stjerne
                    if (symbol.Length <= 1)
                    {
                        increasing = true;  //bytt til å legge til stjerner igjen når den er på 1
                    }
                }

                Thread.Sleep(100);
            }
        }
    }
}

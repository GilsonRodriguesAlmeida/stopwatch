using System.Collections.ObjectModel;
using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        //inicia o contador
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                // limpa a contagem anterior
                Console.Clear();
                // incrementa na contagem
                currentTime++;
                Console.WriteLine(currentTime);
                // aguarda por um tempo, no caso 1 segundo, para a contagem aparecer
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado... retornando para o menu");
            Thread.Sleep(2500);
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Qual o tempo para contar?");

            string data = Console.ReadLine().ToLower();

            // separa o tipo 's' ou 'm' do inteiro 
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // separa o tipo inteiro
            int time = int.Parse(data.Substring(0, data.Length - 1));
            // multiplicador começa em segundos
            int multiplier = 1;
            // se for minuto ele multipliac por 60 para virar segundos
            if (type == 'm')
            {
                multiplier = 60;
            }
            // valida se a entrado do usuario for '0' sai da aplicação
            if (time == 0)
            {
                time = 0;
                System.Environment.Exit(0);
            }

            // inicia o contador e converte para o tipo selecionado 's' ou 'm'
            PreStart(time * multiplier);

        }
    }
}

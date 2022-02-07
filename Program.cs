using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu(){

             Console.Clear();
            System.Console.WriteLine("O que desejas?");
            System.Console.WriteLine("1 - Somar");
            System.Console.WriteLine("2 - Subtrair");
            System.Console.WriteLine("3 - Multiplicar");
            System.Console.WriteLine("4 - Dividir");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("Digite uma Opção");
            short res = short.Parse(System.Console.ReadLine());

            switch (res){
                case 1: Soma(); break;
                case 2: Sub(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
            
        }
        static void Soma(){

             Console.Clear();
            
            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(System.Console.ReadLine());
            float result = v1+v2;
            System.Console.WriteLine("");
            System.Console.WriteLine("O resultado da soma é: " + result);
            Console.ReadKey();
            Menu();
        }
    
    static void Div(){
        Console.Clear();

        System.Console.WriteLine("Primeiro Numero: ");
        float v1 = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Segundo Numero: ");
        float v2 = float.Parse(System.Console.ReadLine());
        float result = v1/v2;
        System.Console.WriteLine("");
        System.Console.WriteLine($"O resultado é {result} ");
        Console.ReadKey();
        Menu();

    }
    static void Sub(){
        Console.Clear();

        System.Console.WriteLine("Primeiro Numero: ");
        float v1 = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Segundo Numero: ");
        float v2 = float.Parse(System.Console.ReadLine());
        float result = v1-v2;
        System.Console.WriteLine("");
        System.Console.WriteLine($"O resultado é {result} ");
        Console.ReadKey();
        Menu();

    }
    static void Mult(){
        Console.Clear();

        System.Console.WriteLine("Primeiro Numero: ");
        float v1 = float.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Segundo Numero: ");
        float v2 = float.Parse(System.Console.ReadLine());
        float result = v1*v2;
        System.Console.WriteLine("");
        System.Console.WriteLine($"O resultado é {result} ");
        Console.ReadKey();
        Menu();

    }
    
    }
}

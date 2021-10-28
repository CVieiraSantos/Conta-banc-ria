using System;
using System.Globalization;
using Course.Entities;
using Course.Excecao;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            System.Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            System.Console.Write("Haverá saldo inicial (s/n)? ");
            char caractere = char.Parse(Console.ReadLine());

            if(caractere == 's' || caractere == 'S')
            {
                System.Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine();
                Conta conta = new Conta(numero, nome, saldo);
                System.Console.WriteLine("Dados da conta: ");;
                Console.WriteLine(conta);
                System.Console.WriteLine(); 
                System.Console.Write("Entre um valor para depósito:  ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(deposito);
                System.Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
                System.Console.WriteLine();
                System.Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);                
                System.Console.Write("Dados da conta atualizados: " + Environment.NewLine);
                System.Console.WriteLine(conta);
            }

            else if(caractere == 'n' || caractere == 'N')
            {
                Conta conta = new Conta(numero, nome);
                System.Console.WriteLine();
                System.Console.WriteLine("Dados da conta: ");                
                Console.WriteLine(conta);   
                System.Console.WriteLine();  
                System.Console.Write("Entre um valor para depósito:  ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(deposito);
                System.Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
                System.Console.WriteLine();
                System.Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);                
                System.Console.Write("Dados da conta atualizados: " + Environment.NewLine);
                System.Console.WriteLine(conta);
            }

            }
            
            catch(FormatException)                        
            {
                throw new FormatException("O campo não está com valor correto.");
                
            }

            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        
        }
    }
}

// using MiniBanco.Models;
// using MiniBanco.Exceptions;
// using MiniBanco.Services;

namespace System
{
    class Program
    {
    enum Options
    {
        Sair = 0,
        Sacar = 1,
        Deposito = 2,
        SaudeConta = 3,
        Saldo = 4
    }

    static void Main(string[] args) // Mensagem de boas vindas
  {
    Console.WriteLine("Bem vindo(a) ao MiniBanco!");
    Console.WriteLine("Aqui seu dinheiro vale MUITO mais!");
    Console.WriteLine("Escolha uma das opções para seguir o autoatendimento:");

    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("\n 1-Sacar 2-Depósito 3-Status 4-Saldo 0-Sair");

    }

  }
 }
}


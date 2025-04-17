
using System;

public class Program
{
    static void Main(string[] args)
    {
        ContaBancaria cb1 = new ContaBancaria();
        cb1._id = Convert.ToInt32(Console.ReadLine());
        cb1._agencia = Console.ReadLine();
        cb1._Nconta = Console.ReadLine();
        cb1._nomeCorrentista = Console.ReadLine();
        cb1._saldo = 0;
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

public class Program
{
  
    
    static void Main(string[] args)
    {
        string cpf = "582.631.012 - 04";
        cpf = cpf.Replace(".", "").Replace("-", ""); // como retirar o ponto e o traço
        //int p = Convert.ToInt32(cpf[1].ToString()); //ConsoleModifiers vericar o que esta na posição

        if (cpf.Length > 11)
        {
            int _cpf = Convert.ToInt32(cpf[1*(10),2*(9),3*(8),4*(7),5*(6),6*(5),7*(4),8*(3),9*(2),].ToString());
            Console.WriteLine("Cpf Correto");
        }
        else 
        {
            Console.WriteLine("Cpf Incorreto");
        }


        /*try
        {
            Console.WriteLine("Digite o primeiro numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = a / b;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divisão por Zero!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro!" + ex.Message);
        }






        List<ContaBancaria> lista = new List<ContaBancaria>();
        int cont = 1;

        while (true)
        {
            Console.WriteLine("Digite 1 para cadastrar nova conta e 2 para listar todas");
            int ops = Convert.ToInt32(Console.ReadLine());
            if(ops == 1)
            {
                try
                {
                    ContaBancaria cb2 = new ContaBancaria();
                    cb2.Depositar(-10);
                    Console.WriteLine("Valor depositado errado !!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Vai passar aqui de qualquer forma!");
                }


                ContaBancaria cb1 = new ContaBancaria();
                Console.WriteLine("Digite o id");
                cb1._id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Agencia");
                cb1._agencia = Console.ReadLine();
                Console.WriteLine("Digite o Numero da Conta");
                cb1._Nconta = Console.ReadLine();
                Console.WriteLine("Digite o Nome do Correntista");
                cb1._nomeCorrentista = Console.ReadLine();
                cb1._saldo = 0;
                lista.Add(cb1);
            }
            else if(ops == 2)
            {
                foreach(ContaBancaria cb in lista)
                {
                    Console.WriteLine(cb._agencia + ", "+ cb._Nconta + ", " + cb._nomeCorrentista + ", " + cb._saldo);
                }
            }
        }



        ContaBancaria cb1 = new ContaBancaria();
        Console.WriteLine("Digite o valor do id");
        cb1._id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do Agencia");
        cb1._agencia = Console.ReadLine();
        Console.WriteLine("Digite o valor do Numero da Conta");
        cb1._Nconta = Console.ReadLine();
        Console.WriteLine("Digite o valor do Nome do Correntista");
        cb1._nomeCorrentista = Console.ReadLine();
        cb1._saldo = 0;
        Console.WriteLine("Digite o valor o Valor do deposito");
        cb1.Depositar(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Digite o valor do saque");
        cb1.Sacar(Convert.ToInt32(Console.ReadLine()));


        Console.WriteLine();*/


        

    }
    

}

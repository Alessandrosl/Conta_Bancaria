
using System;

public class ContaBancaria
{
    public int _id;
    public string _agencia;
    public string _Nconta;
    public string _nomeCorrentista;
    public double _saldo;

    public ContaBancaria()


    public void Depositar(double valor)
    {
        if (valor >= 0)
        {
            _saldo += valor;
        }
        else
        {
            throw new Exception("Valor invalido"); // lançar a exceção
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= _saldo )
        {
            _saldo -= valor;
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
        
    }
    
}

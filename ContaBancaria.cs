
using System;

public class ContaBancaria
{
    private int _id;
    private string _agencia;
    private string _Nconta;
    private string _nomeCorrentista;
    private double _saldo;

    public ContaBancaria()
    {

    }

    public ContaBancaria(int id, string agencia, string nconta, string nomeCorrentista, double saldo)
    {
        _id = id;
        _agencia = agencia;
        _Nconta = nconta;
        _nomeCorrentista = nomeCorrentista;
        _saldo = saldo;
    }

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
    public void setSaldo(double valor)
    {
        if (_saldo > 0)
        {
            _saldo = valor;
        }
        else
        {
            throw new Exception("valor invalido !!!");
        }
    }
    public double getSaldo()
    {
        return _saldo;
    }
}

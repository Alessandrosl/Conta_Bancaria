using System;

public class Funcionario
{

    private int _id;
    private string _nome;
    private string _cpf;
    private DateTime _dataNescimento;
    private string _email;
    private DateTime _dataAdmissao;
    private double _salario;


    public Funcionario()
    {

    }
    public Funcionario(int id, string nome, string cpf, DateTime dataNescimento, string email, DateTime dataAdmissao, double salario)
    {
        _id = id;
        _nome = nome;
        _cpf = cpf;
        _dataNescimento = dataNescimento;
        _email = email;
        _dataAdmissao = dataAdmissao;
        _salario = salario;
    }
    
    

    public void setcpf(string cpf)
    {
        if (cpf == null)
        {
            _cpf = _cpf
        }
       
                
         
    }
    public string getcpf()
    {
        return _cpf;
    }
}
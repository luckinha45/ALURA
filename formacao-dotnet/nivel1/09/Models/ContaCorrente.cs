using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09.Models;
internal class ContaCorrente
{
    public int Numero { get; }
    public int Agencia { get; }
    public double Saldo { get; private set; }
    public Cliente? Titular { get; set; }

    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;
        Saldo = 0;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(valor));
        }

        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(valor));
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }

        Saldo += valor;
    }

    public static ContaCorrente StringToCC(string linha)
    {
        var split = linha.Split(',');
        int ag = Convert.ToInt32(split[0]);
        int nconta = Convert.ToInt32(split[1]);
        double saldo = Convert.ToDouble(split[2]);
        string titular = split[3];

        ContaCorrente cc = new(ag, nconta);
        cc.Depositar(saldo);
        cc.Titular = new();
        cc.Titular.Nome = titular;

        return cc;
    }

    public void ExibeDetalhes()
    {
        Console.WriteLine($"{this.Titular?.Nome} - Ag: {this.Agencia}, Conta: {this.Numero}, Saldo: {this.Saldo}");
    }
}

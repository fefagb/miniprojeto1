namespace System;
public abstract class Conta // classe abstrata CONTA
{
    protected string Titular { get; set; }
    protected int IdConta { get; set; }
    protected decimal Saldo { get; } // pode ser lido mas somente a Conta pode alterar
    List<Transacao> Extrato;

    public Conta (string titular, int numero, decimal saldo) // CONSTRUTOR
    {
        Titular = titular;
        IdConta = numero;
        Saldo = saldo;
    }


}
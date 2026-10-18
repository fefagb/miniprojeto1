class Conta() // criar classe abstrata
{
    string Titular;
    int Numero;
    protected decimal Saldo {set} // pode ser lido mas somente a Conta pode alterar
    List<Transacao> Extrato;
}
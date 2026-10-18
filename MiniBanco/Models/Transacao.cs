class Transacao()
{
    string Descricao; 
    string Tipo; // aceita "Depósito", "Saque" ou "Tarifa"
    decimal Valor; // deve ser sempre > 0 ==> valores invalidos geram ArgumentException
}
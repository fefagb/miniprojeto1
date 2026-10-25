namespace MiniBanco.models
{

    public static class TiposTransacao // tipos de transacao que podem ser utilizados
    {
        public const string Deposito = "Depósito";
        public const string Saque = "Saque";
        public const string Tarifa = "Tarifa";
    }

    public class Transacao()
    {
    public string Descricao; 
    public string Tipo {get; set;} // aceita "Depósito", "Saque" ou "Tarifa"
    public decimal Valor {get; set;} // deve ser sempre > 0 ==> valores invalidos geram ArgumentException
    }
}
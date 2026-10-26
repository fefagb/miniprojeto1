namespace MiniBanco.models
{

    public enum TiposTransacao {  // tipos de transacao que podem ser utilizados
        Deposito,
        Saque,
        Tarifa
    }

    public class Transacao()
    {
    public string Descricao; 
    public TiposTransacao Tipo {get; set;} // aceita "Depósito", "Saque" ou "Tarifa"
    public decimal Valor {get; set;} // deve ser sempre > 0 ==> valores invalidos geram ArgumentException
    
    public void DetalhesTransacao()
        {
            Console.WriteLine($"Tipo de operação: {Tipo} | Valor: {Valor}");
        }
    }
}
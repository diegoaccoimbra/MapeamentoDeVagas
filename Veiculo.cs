namespace MapeamentoDeVagas;

public class Veiculo
{
    public string Placa {get; set;}
    public string Tipo {get; set;}
    
    public Veiculo(string placa, string tipo)
    {
        Placa = placa;
        Tipo = tipo;
    }
}
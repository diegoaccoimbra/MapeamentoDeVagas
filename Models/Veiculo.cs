namespace MapeamentoDeVagas.Models;

public class Veiculo(string placa, string tipo)
{
    public string Placa {get; private set;} = placa;
    public string Tipo {get; set;} = tipo;
}
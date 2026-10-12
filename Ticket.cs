namespace MapeamentoDeVagas;

public class Ticket(string placaDoVeiculo, Vaga vagaOcupada, int horaEntrada)
{
    public string PlacaDoVeiculo {get; set;} = placaDoVeiculo;
    public Vaga VagaOcupada {get; set;} = vagaOcupada;
    public int HoraEntrada {get; set;} = horaEntrada;
    public int HoraSaida {get; set;} = horaEntrada;
    public int Valor {get; set;} = 5;
}
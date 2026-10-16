namespace MapeamentoDeVagas.Models;

public class Ticket(string placaDoVeiculo, Vaga vagaOcupada, DateTime horaEntrada)
{
    public string PlacaDoVeiculo {get; set;} = placaDoVeiculo;
    public Vaga VagaOcupada {get; set;} = vagaOcupada;
    public DateTime HoraEntrada {get; set;} = horaEntrada;
    public DateTime HoraSaida {get; set;} = horaEntrada;
    public decimal Tarifa {get; set;} = 5;
}
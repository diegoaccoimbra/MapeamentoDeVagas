namespace MapeamentoDeVagas.Services;
using MapeamentoDeVagas.Models;

public class Estacionamento
{
    Vaga[,] Mapa {get; set;}
    Dictionary<string, Ticket> Tickets {get; set;}
    int Linha {get; set;}
    int Coluna {get; set;}

    // Método construtor
    public Estacionamento(int linha, int coluna)
    {
        Linha = linha;
        Coluna = coluna;
        Mapa = new Vaga[Linha, Coluna];
        Tickets = new Dictionary<string, Ticket>();

        for (int i = 0; i < Linha; i++)
        {
            for (int j = 0; j < Coluna; j++)
            {
                Mapa[i, j] = new Vaga();
            }
        }
    }

    // Estaciona o veículo na vaga mais próxima da entrada
    public bool Estacionar(Veiculo veiculo)
    {
        // Marca a vaga no mapa e adiciona o veículo à vaga
        for (int i = 0; i < Linha; i++)
        {
            for (int j = 0; j < Coluna; j++)
            {
                if (Mapa[i, j].Status == false)
                {   
                    // Adiciona o veículo à vaga (muda status pra true)
                    Mapa[i, j].Ocupar();

                    // Registra o veículo a um ticket. Hora de entrada de 2:15 minutos atrás da hora atual
                    DateTime horaEntrada = DateTime.Now.AddHours(-2).AddMinutes(-15);
                    Ticket ticket = new Ticket(veiculo.Placa, Mapa[i, j], horaEntrada);
                    Tickets.Add(veiculo.Placa, ticket);

                    return true;
                }
            }
        }        
        return false;
    }
    

    // Exibe o mapa do estacionamento com vagas livres (L) e ocupadas (X)
    public void ConsultarVagas()
    {
        for (int i = 0; i < Linha; i++)
        {
            for (int j = 0; j < Coluna; j++)
            {
                if (Mapa[i, j].Status == true)
                {
                    Console.Write($"[X] ");
                }
                else
                {
                    Console.Write($"[L] ");
                }
            }
            Console.Write("\n");
        }
    }

    // Procura o ticket do veículo pela placa via Dicionário, calcula o tempo decorrido e libera a posição na matriz
    public void CheckOut(Veiculo veiculo)
    {
        Ticket? ticketBuscado = BuscarVeiculo(veiculo.Placa);

        if (ticketBuscado != null)
        {
            CalcularValor(ticketBuscado);
            Vaga vagaOcupada = ticketBuscado.VagaOcupada;
            vagaOcupada.Liberar();
        }
        else
        {
            Console.WriteLine("Nenhum carro estacionado possui essa placa");    
        }
    }

    // Procura o veículo pela placa via Dicionário
    public Ticket? BuscarVeiculo(string placa)
    {
        if (Tickets.TryGetValue(placa, out Ticket? ticket))
        {
            return ticket;
        }
        return null;
    }

    public decimal CalcularValor(Ticket ticket)
    {
        // Calcula as horas cobradas a partir do tempo de permanência no estacionamento
        ticket.HoraSaida = DateTime.Now;
        TimeSpan permanencia = ticket.HoraSaida - ticket.HoraEntrada;
        int horasCobradas = (int)Math.Ceiling(permanencia.TotalHours);
        ticket.Valor *= horasCobradas;
        
        Console.WriteLine($"Total a pagar: R$ {ticket.Valor}");
        
        return ticket.Valor;
    }
}
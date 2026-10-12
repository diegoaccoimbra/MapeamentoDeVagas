namespace MapeamentoDeVagas;

public class Estacionamento
{
    string[,] Mapa {get; set;}
    Dictionary<string, Ticket> Tickets {get; set;}
    List<Vaga> VagasOcupadas {get; set;}
    int Linha {get; set;}
    int Coluna {get; set;}

    // Método construtor
    public Estacionamento(int linha, int coluna)
    {
        Linha = linha;
        Coluna = coluna;
        Mapa = new string [Linha, Coluna];
        Tickets = new Dictionary<string, Ticket>();
        VagasOcupadas = new List<Vaga>();

        for (int i = 0; i < Linha; i++)
        {
            for (int j = 0; j < Coluna; j++)
            {
                Mapa[i, j] = "L";
            }
        }
    }

    // Estaciona o veículo na vaga mais próxima da entrada
    public bool Estacionar(Veiculo veiculo)
    {
        int[] localMatriz = new int [2];

        // Marca a vaga no mapa e adiciona o veículo à vaga
        for (int i = 0; i < Linha; i++)
        {
            for (int j = 0; j < Coluna; j++)
            {
                if (Mapa[i, j] == "L")
                {   
                    // Marca a vaga no mapa
                    Mapa[i, j] = "X";

                    // Adiciona o veículo à vaga
                    localMatriz[0] = i;
                    localMatriz[1] = j;
                    Vaga vaga = new Vaga(veiculo, localMatriz);
                    VagasOcupadas.Add(vaga);

                    // Registra o veículo a um ticket. Hora de entrada de 2:15 minutos atrás da hora atual
                    DateTime horaEntrada = DateTime.Now.AddHours(-2).AddMinutes(-15);
                    Ticket ticket = new Ticket(veiculo.Placa, vaga, horaEntrada);
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
                Console.Write($"[{Mapa[i, j]}] ");
            }
            Console.Write("\n");
        }
    }

    // Procura o ticket do veículo pela placa via Dicionário, calcula o tempo decorrido e libera a posição na matriz
    public void Checkout(Veiculo veiculo)
    {
        Ticket? ticketBuscado = BuscarVeiculo(veiculo.Placa);

        if (ticketBuscado != null)
        {
            // Calcula as horas cobradas a partir do tempo de permanência no estacionamento
            ticketBuscado.HoraSaida = DateTime.Now;
            TimeSpan permanencia = ticketBuscado.HoraSaida - ticketBuscado.HoraEntrada;
            int horasCobradas = (int)Math.Ceiling(permanencia.TotalHours);
            ticketBuscado.Valor *= horasCobradas;
            Console.WriteLine($"Total a pagar: R$ {ticketBuscado.Valor}");

            // Busca o veículo na lista de vagas ocupadas para liberar a vaga
            for (int i = 0; i < VagasOcupadas.Count; i++)
            {
                if (VagasOcupadas[i].VeiculoEstacionado.Placa == veiculo.Placa)
                {
                    // Liberando a vaga no mapa
                    int linhaDaVaga = VagasOcupadas[i].LocalNaMatriz[0];
                    int colunaDaVaga = VagasOcupadas[i].LocalNaMatriz[1];
                    Mapa[linhaDaVaga, colunaDaVaga] = "L";

                    //VagasOcupadas[i].Status = false;
                    VagasOcupadas.Remove(VagasOcupadas[i]);
                }
            }
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
}
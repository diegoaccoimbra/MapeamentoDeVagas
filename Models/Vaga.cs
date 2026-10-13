namespace MapeamentoDeVagas.Models;

public class Vaga
{
    public bool Status {get; set;}
    public Veiculo VeiculoEstacionado {get; set;}
    public string Tipo {get; set;}
    public int[] LocalNaMatriz {get; set;}

    public Vaga (Veiculo veiculoEstacionado, int[] localNaMatriz)
    {
        VeiculoEstacionado = veiculoEstacionado;
        LocalNaMatriz = localNaMatriz;
        Tipo = veiculoEstacionado.Tipo;
        Status = true;
    }
}
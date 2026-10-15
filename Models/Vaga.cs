namespace MapeamentoDeVagas.Models;

public class Vaga()
{
    public bool Status {get; set;} = false;

    public void Ocupar()
    {
        Status = true;
    }

    public void Liberar()
    {
        Status = false;
    }
}
namespace MapeamentoDeVagas.Models;

public class Vaga()
{
    public bool Status {get; private set;} = false;

    public void Ocupar()
    {
        Status = true;
    }

    public void Liberar()
    {
        Status = false;
    }
}
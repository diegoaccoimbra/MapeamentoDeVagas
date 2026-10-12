using MapeamentoDeVagas;

Estacionamento MeuEstacionamento = new Estacionamento(5, 6);
Veiculo MeuVeiculo = new Veiculo("ABC123", "carro");
Veiculo MeuChevy = new Veiculo("BRA013", "carro");
Veiculo MeuFord = new Veiculo("XYZ489", "carro");

MeuEstacionamento.ConsultarVagas();
// Estacionando os carros
Console.WriteLine(MeuEstacionamento.Estacionar(MeuVeiculo));
MeuEstacionamento.ConsultarVagas();
Console.WriteLine(MeuEstacionamento.Estacionar(MeuChevy));
MeuEstacionamento.ConsultarVagas();

// Checkout do primeiro carro
MeuEstacionamento.Checkout(MeuVeiculo);
MeuEstacionamento.ConsultarVagas();

// Estacionando mais um
Console.WriteLine(MeuEstacionamento.Estacionar(MeuFord));
MeuEstacionamento.ConsultarVagas();
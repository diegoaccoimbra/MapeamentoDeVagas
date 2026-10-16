using MapeamentoDeVagas.Models;
using MapeamentoDeVagas.Services;

Estacionamento MeuEstacionamento = new Estacionamento(5, 6);
Veiculo MeuToyota = new Veiculo("ABC123", "carro");
Veiculo MeuChevy = new Veiculo("BRA013", "carro");
Veiculo MeuFord = new Veiculo("XYZ489", "carro");

MeuEstacionamento.ConsultarVagas();
// Estacionando os carros
Console.WriteLine(MeuEstacionamento.CheckIn(MeuToyota));
MeuEstacionamento.ConsultarVagas();
Console.WriteLine(MeuEstacionamento.CheckIn(MeuChevy));
MeuEstacionamento.ConsultarVagas();

// Tentando estacionar o mesmo carro
Console.WriteLine(MeuEstacionamento.CheckIn(MeuToyota));

// Check-out do primeiro carro
MeuEstacionamento.CheckOut(MeuToyota);
MeuEstacionamento.ConsultarVagas();

// Estacionando mais um
Console.WriteLine(MeuEstacionamento.CheckIn(MeuFord));
MeuEstacionamento.ConsultarVagas();
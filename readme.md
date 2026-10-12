# 🚗 Simulador de Mapeamento de Vagas em Estacionamento

## 💡 O Problema Real
Estacionamentos modernos utilizam sensores para gerenciar em tempo real quais vagas estão ocupadas, direcionar motoristas para a vaga mais próxima e calcular a cobrança com base na categoria do veículo e no tempo de permanência.

## 🎯 O que Praticar
* **POO:** Classes para `Vaga` (status, tipo, localização), `Veiculo` (placa, tipo: carro/moto/PCD), `Ticket` (hora entrada, hora saída, valor) e `Estacionamento`.
* **Estrutura de Dados:**
  * **Matriz / Array 2D:** Representa o mapa do estacionamento (andares, fileiras e posições).
  * **Map / Dicionário (`Map<Placa, Ticket>`):** Busca instantânea $O(1)$ de um veículo estacionado ao digitar a placa no terminal de pagamento.

## 🛠️ Funcionalidades Principais
* **Estacionar:** Recebe um veículo e encontra automaticamente a vaga mais próxima da entrada adequada ao tipo do veículo.
* **Consultar Vagas:** Exibe o mapa no terminal mostrando vagas livres (`[ L ]`) e ocupadas (`[ X ]`).
* **Checkout:** Procura o veículo pela placa via Dicionário, calcula o tempo decorrido, aplica a tarifa do tipo de vaga e libera a posição na matriz.

------
Vaga
- status
- tipo
- localização na matriz

Veiculo
- placa
- tipo

Ticket
- hora entrada
- hora saída
- valor

Estacionamento
- número de linhas
- número de colunas
- contém a matriz com as vagas
- status
- contém os métodos para estacionar, consultar vagas e fazer o checkout

------



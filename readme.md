# 🚗 Simulador de Mapeamento de Vagas em Estacionamento

## 💡 O Problema Real
Estacionamentos modernos utilizam sensores para gerenciar em tempo real quais vagas estão ocupadas, direcionar motoristas para a vaga mais próxima e calcular a cobrança com base no tempo de permanência. O sistema deve simular a operação de um estacionamento rotativo, que gerencia a entrada, localização, permanência e saída de veículos de forma automatizada, garantindo consulta rápida de dados e exibição visual do estado das vagas.

## 🛠️ Funcionalidades Principais
* **Estacionar:** Recebe um veículo e encontra automaticamente a vaga mais próxima da entrada.
* **Consultar Vagas:** Exibe o mapa no terminal mostrando vagas livres (`[ L ]`) e ocupadas (`[ X ]`).
* **Checkout:** Procura o veículo pela placa via Dicionário, calcula o tempo decorrido, aplica a tarifa do tipo de vaga e libera a posição na matriz.

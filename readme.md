# 🚗 Simulador de Mapeamento de Vagas em Estacionamento

## 📋 Sobre o Projeto
Este é um projeto desenvolvido em **C#** com o objetivo de praticar conceitos fundamentais de **Orientação a Objetos (POO)** e **Estruturas de Dados** (Matrizes e Dicionários). 

O sistema simula a operação de um estacionamento inteligente, controlando a entrada (check-in) de veículos, o mapeamento em tempo real das vagas físicas, o cálculo de permanência e a liberação de saída (check-out).

---

## 🛠️ Tecnologias e Conceitos Utilizados
* **Linguagem:** C#
* **Paradigma:** Orientação a Objetos
* **Estruturas de Dados:**
  * **Matriz Bidimensional (`Vaga[,]`):** Representa o mapa físico das vagas do estacionamento.
  * **Dicionário (`Dictionary<string, Ticket>`):** Permite buscas instantâneas e eficientes ($O(1)$) de veículos ativos pela placa.

---

## 🧩 Funcionalidades Principais
1. **Check-in Automatizado:** Valida se o veículo já está no pátio e o aloca na primeira vaga livre disponível.
2. **Mapa em Tempo Real:** Exibe o layout visual do estacionamento no terminal indicando vagas livres (`[L]`) e ocupadas (`[X]`).
3. **Check-out e Cálculo de Tarifa:** Localiza o veículo pelo ticket, calcula o tempo total de permanência e gera o valor a ser pago com base na tarifa horária.
4. **Proteção contra Duplicidade:** Impede que o mesmo veículo dê entrada duas vezes simultaneamente.

---

## 📁 Estrutura do Código
* **`Services/Estacionamento.cs`**: Classe principal que gerencia o estado da matriz, o dicionário de tickets ativos e as regras de negócio de entrada e saída.
* **`Models/Vaga.cs`**: Representa uma vaga individual e encapsula seu estado (ocupada/livre) e métodos de alteração.
* **`Models/Veiculo.cs`**: Modela os dados essenciais de um automóvel (placa e tipo).
* **`Models/Ticket.cs`**: Registra o vínculo entre o veículo, a vaga alocada e o horário de entrada.
* **`Program.cs`**: Ponto de entrada da aplicação para testes e simulação de uso.

---

## 🚀 Como Executar o Projeto
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/) instalado na sua máquina.
2. Clone este repositório ou abra a pasta do projeto no seu terminal.
3. Navegue até o diretório do projeto e execute o comando:
   ```bash
   dotnet run

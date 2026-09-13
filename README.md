# 🚀 Calculadora de Trajetória Interplanetária e Consumo de Combustível

Aplicação desktop desenvolvida em **C# com WPF** para simular cálculos básicos de uma viagem interplanetária utilizando a **Transferência de Hohmann**.

O sistema recebe dados da órbita de origem e destino, massa da espaçonave e impulso específico do motor. A partir dessas informações, calcula o **tempo estimado da transferência**, o **Delta-v total** e uma **estimativa de combustível necessário**.

O projeto foi desenvolvido como atividade da disciplina de **Programação Visual Básica** e utiliza **.NET 10 para Windows**.

## 🚀 Funcionalidades

- Entrada da distância orbital do corpo de origem
- Entrada da distância orbital do corpo de destino
- Entrada da massa da espaçonave
- Entrada do impulso específico do motor
- Cálculo do semieixo maior da órbita de transferência
- Cálculo do tempo estimado de viagem
- Cálculo do Delta-v da manobra
- Estimativa da massa de combustível
- Exibição do tempo em dias e meses
- Exibição do combustível em quilogramas e toneladas
- Botão para limpar os dados da interface

## 🧮 Cálculos utilizados

O projeto utiliza a constante gravitacional do Sol e aplica relações matemáticas da **Transferência de Hohmann** para determinar as velocidades necessárias na saída e chegada da órbita de transferência.

A estimativa de combustível é feita a partir do Delta-v calculado, da massa da nave, da gravidade terrestre e do impulso específico informado pelo usuário.

> Este é um projeto educacional voltado à prática de programação e aplicação de fórmulas matemáticas em uma interface gráfica.

## 🛠️ Tecnologias

- **C#**
- **WPF (Windows Presentation Foundation)**
- **XAML**
- **.NET 10**
- **Visual Studio**

## ▶️ Como executar

1. Clone o repositório:

```bash
git clone https://github.com/VitorHens/calculadora-trajetoria-interplanetaria.git
```

2. Abra `projeto3BiPVB.slnx` no **Visual Studio**.
3. Confirme que o SDK do **.NET 10** está instalado.
4. Compile e execute o projeto.
5. Informe os quatro valores solicitados, um por linha, na seguinte ordem:

```text
Distância do corpo de origem
Distância do corpo de destino
Massa da espaçonave
Impulso específico do motor
```

6. Clique no botão de cálculo para visualizar os resultados.

## 🧠 Conceitos praticados

- Programação em C#
- Desenvolvimento de interfaces WPF
- Eventos de botões
- Estruturas condicionais e de repetição
- Manipulação de strings e valores numéricos
- Métodos da classe `Math`
- Formatação de números
- Aplicação de fórmulas físicas e matemáticas

## 📐 Fluxograma

<img width="357" height="2345" alt="Fluxograma do projeto" src="https://github.com/user-attachments/assets/0ff3f71e-b677-42fe-ba04-6b216419f362" />

---

Desenvolvido por **Vitor Hens**.

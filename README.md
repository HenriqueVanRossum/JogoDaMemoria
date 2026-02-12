# 🧠 Jogo da Memória (C# Console)

Jogo da Memória desenvolvido em **C#** para rodar no console.
O objetivo é encontrar todos os pares de símbolos com o menor número de tentativas possível.

O jogo utiliza uma matriz 4x4 com símbolos distribuídos aleatoriamente.

---

## 🚀 Como clonar o projeto

No terminal, execute:

```bash
git clone https://github.com/HenriqueVanRossum/JogoDaMemoria.git
```

Entre na pasta do projeto:

```bash
cd JogoDaMemoria
```

---

## ▶️ Como rodar o projeto

### 1️⃣ Verifique se você tem o .NET instalado

No terminal:

```bash
dotnet --version
```

Se não tiver instalado, baixe em:
[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

---

### 2️⃣ Execute o projeto

Dentro da pasta do projeto:

```bash
dotnet run
```

---

## 🎮 Como jogar

* O tabuleiro começa numerado de **01 a 16**.
* Digite o número correspondente à posição que deseja revelar.
* Em seguida, escolha a segunda posição.
* Se os símbolos forem iguais, o par permanece aberto.
* Se forem diferentes, eles serão escondidos novamente.
* O jogo termina quando todos os pares forem encontrados.

Ao final, será exibido o número de tentativas.

---

## 🛠 Tecnologias utilizadas

* C#
* .NET
* Console Application

---

## 📌 Estrutura do projeto

* `Program.cs` → Contém a lógica principal do jogo
* `GerenciarScreen` → Classe responsável por:

  * Gerar o tabuleiro
  * Inserir símbolos aleatórios
  * Desenhar a tela
  * Controlar a exibição

---

## 📚 Objetivo do projeto

Projeto desenvolvido para prática de:

* Matrizes bidimensionais
* Manipulação de arrays
* Estruturas de repetição
* Lógica de jogo
* Organização de código em classes

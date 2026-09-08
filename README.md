# ⏱️ Console Stopwatch em C#

Um cronômetro simples desenvolvido em **C# e .NET**, executado pelo terminal.

O usuário informa um período e sua unidade de tempo, e o programa realiza a contagem até o tempo definido.

## 📌 Funcionalidades

* Contagem de tempo em:

  * `s` — segundos
  * `m` — minutos
  * `h` — horas
* Validação das entradas do usuário.
* Mensagens de preparação antes do início da contagem.
* Opção para encerrar o programa pelo menu.
* Tratamento de valores inválidos ou menores/iguais a zero.

## 🛠️ Tecnologias e conceitos

* C#
* .NET 10
* Métodos e modularização
* `if`, `do/while` e `continue`
* `int.TryParse()`
* Manipulação de `string` e `char`
* `Thread.Sleep()`
* Validação de entrada do usuário

## 🚀 Como executar

### Pré-requisito

* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/gustavoschmittt/Stopwatch.git
```

Entre na pasta:

```bash
cd Stopwatch
```

Execute:

```bash
dotnet run
```

## ▶️ Como usar

Ao iniciar, informe o tempo seguido da unidade desejada:

```text
10s
```

Conta 10 segundos.

```text
2m
```

Conta 2 minutos.

```text
1h
```

Conta 1 hora.

Para encerrar o programa:

```text
0
```

## 🎯 Objetivo

Projeto desenvolvido para praticar fundamentos de **C#**, principalmente controle de fluxo, validação de dados, manipulação de strings e organização do código em métodos.

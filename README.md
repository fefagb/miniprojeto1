# SCtec - Mini Projeto #1 - Mini Banco 

### Olá, este é um projeto estudantil criado para aplicação prática de conhecimentos em programação back-end em linguagem C#.

_Link para o Vídeo enviado via arquivo de entrega no AVA_

<!-- Esse arquivo deve explicar:
    o projeto
    regras de negócio 
    instruções para a execução via dotnet run -->

## O projeto: O que é?

Aqui temos uma aplicação bancária executada via Console.app que simula a movimentação bancária de forma interativa, com histórico de atividade bancária e saúde da conta.

## Regras de negócio

O sistema se utiliza de um índice de pontuação, baseado no tipo de atividade realizada na conta, para determinar se uma conta é saudável ou não. Além de também detalhar item por item no extrato bancário. O que ajuda a determinar o que fazer com a conta, em casos de contas negativadas, por exemplo.

## Instruções de execução

Para a execução desse projeto em sua máquina, certifique-se de que está com o .NET SDK instalado e funcional.

Execute-o como preferir: Seja copiando o diretório através do comando _git clone_ ou fazendo o download de todos os arquivos deste repositório.

### Estrutura do projeto:

```
↳ MiniBanco\
   ↳ Exceptions\
        ↳ SaldoInsuficienteException.cs
   ↳ Models\
        ↳ Conta.cs
        ↳ ContaCorrente.cs
        ↳ ContaPoupanca.cs
        ↳ ContaSalario.cs
        ↳ Transacao.cs
   ↳ Services\
        ↳ MotorAnalise.cs
   ↳ Program.cs
   ↳ MiniBanco.csproj
```


## Considerações Finais

Este projeto foi desenvolvido pela aluna Fernanda Borges com base nos conhecimentos adquiridos em C# e .NET framework durante as primeiras 6 semanas de curso do projeto SCTEC. 

###### _O projeto foi desenvolvido com o mínimo possível de ferramentas de inteligência artificial, com foco em maior absorção de conhecimentos estruturais do código através da prática._ ######
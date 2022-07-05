# TDD_CSharp
Aprendendo conceitos de TDD com C#

## Qual o objetivo dos testes?

- Garantir que o produto atenda aquilo que foi especificado para o projeto.
- Verificação do correto funcionamento da aplicação.
- Detecção de falhas e defeitos que poderiam passar em branco até a subida em produção.

## **O que é um teste unitário?**

- Testa algo por unidade de maneira isolada simulando dependências.

## **O que é um teste automático?**

- Que é o uso do software para realizar o teste. Comparando o resultado esperado com o real.

## **O que é TDD?**

- Desenvolvimento baseado na codificação de testes unitários.
- Essa abordagem teve início em 2002, com a publicação do livro “Test Driven Development: By Example” de Kent que é o pai do xp - extreme programming.

## Como funciona TDD com a implementação de software?

- A construção de uma solução tem que ser de maneira que facilite a integração de ferramentas para a execução de testes unitários.
- A codificação de testes unitários pode/às vezes devem ser antes mesmo da implementação as partes que serão submetidas a análises → Evitando assim a elaboração de testes viciados.

 ## 3 estágios do TDD
 
 ## **Red:**

- Teste elaborado antes mesmo da funcionalidade ter sido codificada (Apenas a estrutura básica), de forma a se evitar uma verificação “viciada”.

## Green:

- Funcionalidade codificada da forma mais simples possível, de maneira a garantir a execução com sucesso dos testes.

## Refactor:

- Eliminação de instruções duplicadas e eventuais melhorias no código.

## Benefícios do TDD

- Código mais claro, já que os testes são escritos como o objetivo de checar.
- Testes podem ser encarados como forma também de documentar.
- Antecipação de falhas.

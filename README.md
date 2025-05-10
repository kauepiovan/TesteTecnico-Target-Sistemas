# 💻 Teste Técnico - Target Sistemas

Este repositório contém as soluções para o teste técnico proposto pela **Target Sistemas**. Busquei evitar ao máximo o uso de funções prontas, preferindo desenvolver as minhas próprias para demonstrar minha lógica de programação.

---

## 📌 Questões

### ✅ 1 - Soma com Estrutura de Repetição

> **Enunciado**:  
> ```csharp
> int INDICE = 13, SOMA = 0, K = 0;
> enquanto (K < INDICE) {
>     K = K + 1;
>     SOMA = SOMA + K;
> }
> imprimir(SOMA);
> ```
> Qual será o valor da variável `SOMA` ao final do processamento?

📎 [Ver código](./Pergunta01/Program.cs)  
📌 **Resposta**: `91`

---

### ✅ 2 - Verificação de Número na Sequência de Fibonacci

> Dada a sequência de Fibonacci (0, 1, 1, 2, 3, 5, 8, 13, 21...), crie um programa que verifique se um número informado pertence à sequência.

📎 [Ver código](./Pergunta02/Program.cs)  
🔢 **Exemplo de input**: `8`  
📌 **Resposta**: `O número 8 pertence à sequência de Fibonacci.`

---

### ✅ 3 - Análise de Faturamento Diário

> Utilizando um arquivo JSON com dados de faturamento diário, desenvolva um programa que calcule:
- 📉 O menor valor de faturamento em um dia útil;
- 📈 O maior valor de faturamento em um dia útil;
- 📊 Quantos dias tiveram faturamento acima da média mensal (desconsiderando dias sem faturamento).

📎 [Ver código](./Pergunta03/Program.cs)

📌 **Resposta**:
- Maior valor: `R$ 48.924,24`
- Menor valor (≠ 0): `R$ 373,78`
- Média (excluindo zeros): `R$ 20.865,37`
- Dias acima da média: `10`

---

### ✅ 4 - Percentual de Representação por Estado

> Dado o faturamento mensal por estado:
SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

> Desenvolva um programa para calcular o percentual que cada estado representa no total.

📎 [Ver código](./Pergunta04/Program.cs)

📌 **Resposta**:
- SP: `37,53%`
- RJ: `20,29%`
- MG: `16,17%`
- ES: `15,03%`
- Outros: `10,98%`

---

### ✅ 5 - Inversão de String

> Crie um programa que inverta os caracteres de uma string informada, sem utilizar funções prontas como `reverse`.

📎 [Ver código](./Pergunta05/Program.cs)  
🔤 **Exemplo de input**: `nuvem`  
📌 **Resposta**: `mevun`

# 💰 Sistema de Caixa - Lanchonete Delícia

# 📑 Sumário

- [📖 Sobre o Projeto](#-sobre-o-projeto)
- [🎬 Demonstração do Funcionamento](#-demonstração-do-funcionamento)
- [🎯 Objetivos do Sistema](#-objetivos-do-sistema)
- [⚙️ Funcionalidades Implementadas](#-funcionalidades-implementadas)
- [🧠 Arquitetura e Lógica Aplicada](#-arquitetura-e-lógica-aplicada)
- [🛠️ Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [🔄 Fluxo do Sistema](#-fluxo-do-sistema)
- [📂 Estrutura do Código](#-estrutura-do-código)
- [🚀 Possíveis Melhorias Futuras](#-possíveis-melhorias-futuras)
- [📄 Licença](#-Licença)
- [👥 Créditos & Contatos](#-créditos--contatos)

---

## 📖 Sobre o Projeto

Sistema de Caixa desenvolvido em **C# com Windows Forms**, simulando o funcionamento real de uma lanchonete.

O sistema permite:

- Abertura de caixa
- Registro de produtos
- Cálculo automático de subtotal
- Processamento de pagamento
- Cálculo de troco
- Geração de recibo formatado
- Controle de valor acumulado em caixa

O projeto foi desenvolvido como atividade prática do curso Técnico em Informática, com foco em aplicação de lógica de programação, manipulação de eventos e controle financeiro básico.

---

## 🎯 Objetivos do Sistema

- Simular um ambiente real de vendas
- Trabalhar manipulação de eventos no Windows Forms
- Aplicar cálculos financeiros com `decimal`
- Controlar estados da interface dinamicamente
- Gerar recibos formatados automaticamente

---

## ⚙ Funcionalidades Implementadas

✔ Abertura de caixa com valor inicial  
✔ Adição de produtos com quantidade  
✔ Cálculo automático de subtotal  
✔ Validação de pagamento insuficiente  
✔ Cálculo automático de troco  
✔ Geração de recibo com data e hora  
✔ Atualização do valor acumulado em caixa  
✔ Encerramento do sistema exibindo valor final  

---

## 🧠 Arquitetura e Lógica Aplicada

O sistema utiliza:

- Controle de estado via variáveis globais (`subTotal`, `valorPago`, `troco`, `valorCaixa`)
- Manipulação de eventos de botões
- Formatação monetária com `ToString("C2")`
- Uso de `DateTime` para geração de recibo
- Manipulação dinâmica da interface (Visible / Enabled)
- Validação de entrada de dados
- Controle manual de layout do recibo com alinhamento por pontos

### Variáveis Principais

- `subTotal` → Soma dos produtos
- `valorPago` → Valor informado pelo cliente
- `troco` → Diferença entre pagamento e subtotal
- `valorCaixa` → Controle acumulado do caixa

---

## 🛠 Tecnologias Utilizadas

- C#
- .NET Framework
- Windows Forms
- Visual Studio

---

## 🔄 Fluxo do Sistema

1. Operador informa valor inicial do caixa
2. Produtos são adicionados
3. Sistema calcula subtotal
4. Cliente informa valor pago
5. Sistema valida pagamento
6. Troco é calculado
7. Recibo é gerado
8. Valor é acumulado no caixa
9. Sistema pode ser encerrado exibindo valor final

---

## 📂 Estrutura do Código

```
Projeto_Wagner_3ºBimestre
 ┣ 📜 Form1.cs
 ┣ 📜 Form1.Designer.cs
 ┣ 📜 Program.cs
 ┗ 📜 Arquivos do projeto (.csproj)
```

A lógica principal está centralizada no `Form1.cs`, responsável pelo controle de interface e processamento das regras de negócio.

---

## 🚀 Possíveis Melhorias Futuras

- Separação da lógica de negócio em classes próprias
- Implementação de persistência em banco de dados
- Uso de orientação a objetos mais avançada
- Implementação de padrão MVC
- Impressão real de recibo
- Controle de estoque
- Relatórios de vendas
- Autenticação de operador

---

# 📄 Licença

Projeto desenvolvido para fins educacionais.

---

# 👥 Créditos & contatos

1. <b>Mateus Todeschini</b> - GitHub: https://github.com/Todeschiniii<br>
2. <b>Heitor Pinheiro</b> - GitHub: https://github.com/HeitorPinheiro11<br>
3. <b>Davi Dancuart</b> - GitHub: https://github.com/DaviDancuart<br>

Repositório: https://github.com/Todeschiniii/CaixaEletronico

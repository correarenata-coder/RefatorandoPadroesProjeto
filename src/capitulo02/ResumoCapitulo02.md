# 📘 Capítulo 02 — Refatoração e Padrões de Projeto

---
## 📌 Visão Geral

Este capítulo apresenta os conceitos de **refatoração** e **padrões de projeto**, destacando a importância de manter um código limpo, organizado e de fácil evolução.
---

## 🔧 O que é Refatoração?

De acordo com o livro *Refactoring: Improving the Design of Existing Code* (1999), de **Martin Fowler**:

> Refatoração é o processo de melhorar a estrutura interna do código sem alterar seu comportamento externo.

O objetivo é tornar o código:

- Mais legível  
- Mais compreensível  
- Mais fácil de manter  

### 📍 Princípios da refatoração

1. **Melhorar o design existente**  
2. **Aplicar mudanças em pequenos passos**  
3. **Evitar quebrar o sistema**  

---

## 🛠️ Técnicas de Refatoração

- **Extrair Método**  
  Criar um novo método a partir de um trecho de código para melhorar legibilidade e reutilização.

- **Mover Método**  
  Transferir um método para outra classe, melhorando a coesão e reduzindo o acoplamento.

- **Mover Campo**  
  Transferir atributos entre classes para melhor organização.

- **Extrair Classe**  
  Criar uma nova classe para dividir responsabilidades e melhorar a estrutura do código.

---

## 🧩 O que são Padrões de Projeto?

Padrões de projeto são **soluções reutilizáveis para problemas comuns** no design de software.

Eles ajudam a:

- Padronizar soluções  
- Melhorar a comunicação entre desenvolvedores  
- Facilitar manutenção e evolução  

📚 Referência clássica:  
*Design Patterns: Elements of Reusable Object-Oriented Software* (1994)

---

## 🗂️ Classificação dos Padrões

### 🏗️ 1. Criação
Relacionados à criação de objetos.

**Exemplos:**
- Singleton  
- Factory Method  
- Abstract Factory  

---

### 🧱 2. Estruturais
Relacionados à organização de classes e objetos.

**Exemplos:**
- Adapter  
- Composite  
- Decorator  

---

### 🔄 3. Comportamentais
Relacionados à comunicação entre objetos.

**Exemplos:**
- Observer  
- Strategy  
- Command  

---

## ✅ Vantagens dos Padrões de Projeto

- ♻️ Reutilização de código  
- 💬 Melhor comunicação entre equipes  
- 🔧 Facilidade de manutenção  
- 🔄 Flexibilidade e extensibilidade  
- 📈 Melhoria da qualidade do código  
- 🧠 Redução da complexidade  
- 🎓 Facilitação do aprendizado  

---

## 🚀 Como fazer uma boa refatoração

1. **Identifique oportunidades de melhoria**  
   Avalie pontos de baixa legibilidade, duplicação ou complexidade.

2. **Entenda o contexto do código**  
   Garanta que você compreende o comportamento atual antes de alterar.

3. **Refatore em pequenos passos**  
   Faça mudanças incrementais e seguras.

4. **Garanta cobertura de testes**  
   Certifique-se de que o sistema continua funcionando corretamente.

---
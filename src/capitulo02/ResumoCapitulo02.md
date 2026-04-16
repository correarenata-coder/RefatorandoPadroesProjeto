# 📘 Capítulo 02 — Refatoração e Padrões de Projeto

---
## 📌 Visão Geral

Este capítulo apresenta os conceitos de refatoração e padrões de projeto, destacando a importância de manter um código limpo e organizado para facilitar a manutenção e evolução dos sistemas.
---

Refatoração de acordo com  livro de Martin Fowler, "Refactoring: Improving the Design of Existing Code" (1999), é o processo de alterar um sistema de software para melhorar sua estrutura interna sem modificar seu comportamento externo. O objetivo é tornar o código mais legível, compreensível e fácil de manter.
Ela pode ser entendida de 3 partes:

1. Melhorar o design existente
2.Aplicar mudanças em pequenos passos
3.Evitar deixar o sistema quebrado
---

Tecnicas de refarotação :

1. Extrair método : Criar um novo método a partir de um trecho de código existente para melhorar a legibilidade e reutilização.
2. Mover Método : Transferir um método de uma classe para outra para melhorar a coesão e reduzir o acoplamento.
3. Mover campo : Transferir um campo de uma classe para outra para melhorar a coesão e reduzir o acoplamento.
4. Extrair Classe : Criar uma nova classe a partir de um trecho de código existente para melhorar a organização e a responsabilidade.

---

Padrões de projetos são soluções reutilizáveis para problemas comuns de design de software. Eles fornecem uma estrutura para resolver problemas específicos de design, promovendo a reutilização e a manutenção do código.
Dica de livro para padrões de projeto: "Design Patterns: Elements of Reusable Object-Oriented Software" (1994), de Erich Gamma, Ralph Johnson, Richard Helm e John Vlissides.

Os padrões de projeto são classificados em três categorias principais:

1- Criação - Padrões de criação lidam com a criação de objetos, abstraindo o processo de instanciamento e promovendo a flexibilidade e reutilização do código. Exemplos incluem Singleton, Factory Method e Abstract Factory.
2- Estruturais - Padrões estruturais lidam com a composição de classes e objetos para formar estruturas maiores, promovendo a flexibilidade e a reutilização do código. Exemplos incluem Adapter, Composite e Decorator.
3- Comportamentais - Padrões comportamentais lidam com a interação e a responsabilidade entre objetos, promovendo a flexibilidade e a reutilização do código. Exemplos incluem Observer, Strategy e Command.

---

Vantagens de usar padrões de projeto:

1. Reutilização de código: Padrões de projeto fornecem soluções testadas e comprovadas para problemas comuns, permitindo que os desenvolvedores reutilizem código e evitem reinventar a roda.
2. Melhoria da comunicação: Padrões de projeto fornecem uma linguagem comum para os desenvolvedores, facilitando a comunicação e a colaboração entre equipes.
3. Facilitação da manutenção: Padrões de projeto promovem a organização e a estrutura do código, facilitando a manutenção e a evolução dos sistemas.
4. Flexibilidade e extensibilidade: Padrões de projeto promovem a flexibilidade e a extensibilidade do código, permitindo que os sistemas sejam adaptados e evoluídos ao longo do tempo.
5. Melhoria da qualidade do código: Padrões de projeto promovem boas práticas de design, melhorando a qualidade do código e reduzindo a probabilidade de erros e bugs.
6. Redução da complexidade: Padrões de projeto ajudam a reduzir a complexidade do código, tornando-o mais fácil de entender e manter.
7. Facilitação do aprendizado: Padrões de projeto fornecem uma estrutura para aprender e entender conceitos de design de software, facilitando o aprendizado e a aplicação desses conceitos na prática.

---

Para fazer uma boa refatoração podemos seguir os sequintes passos :

1. Identificar uma oportunidad de melhoria: Analise o código existente e identifique áreas que podem ser melhoradas em termos de legibilidade, organização ou desempenho.
2. Entender o contexto do código: Compreenda o propósito e a funcionalidade do código que você deseja refatorar para garantir que as mudanças não afetem o comportamento externo.
3. Alicar pequenas mudanças nos testes e códigos: Faça mudanças incrementais no código, garantindo que os testes sejam atualizados para refletir as mudanças e que o sistema continue funcionando corretamente.
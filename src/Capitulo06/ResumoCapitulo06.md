# CAPÍTULO	6 TEMPLATE	METHOD: DEFININDO	ALGORITMOS EXTENSÍVEIS 


---
## 📌 Visão Geral
Template Method é um padrão de projeto comportamental que define a estrutura de um algoritmo em uma classe base, permitindo que as subclasses implementem partes específicas do algoritmo sem alterar sua estrutura geral. Ele é útil para criar algoritmos flexíveis e reutilizáveis, onde a lógica principal é definida na classe base, e as variações são implementadas nas subclasses.

## Projeto
Implementar um worker que envia e-mails, dado um usuário, uma lista com destinatárioa e tipo de conteúdo da mensagem (Convitem promocional , etc)
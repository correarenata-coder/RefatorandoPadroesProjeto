# CAPÍTULO	7 - ADAPTER:	SEJA	COMO	A ÁGUA


---
## 📌 Visão Geral
Adapter é um padrão de projeto estrutural que permite que classes com interfaces incompatíveis trabalhem juntas. Ele atua como um "adaptador" que converte a interface de uma classe em outra interface que os clientes esperam. O Adapter é útil quando você deseja usar uma classe existente, mas sua interface não é compatível com o código que você está escrevendo.

## Projeto
Fazer um projeto que unifique informaçõs sobre fornacedores, estoque e cliente de um sistema legado de uma grande loja online, sem que ele fique preso ao design anterior para uma nova aplicação.


## Como estão os sistemas antigos

1. Aplicação controla **estoque** guarda todas as informações em uma base de dados não relecional.
2. As informações dos **fornecedores** utiliza um servicço de mensagend em fila.
3. As informações dos **clientes** são expostas e consumidas por uma API SOAP troacando arquivos XML.



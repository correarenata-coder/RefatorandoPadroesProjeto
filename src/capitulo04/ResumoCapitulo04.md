# 📘 Capítulo 04 — Factory : Gerenciando a criação de objetos
---
## 📌 Visão Geral
Precisa ser desenvolvido para um site de comprar uma ferramenta de busca. Usuários querem encontrar os produtos o mais rápido possível.

# 4.1 O Custo da flexibilidade

Para a entender a demanda dos usuários foi detectado 3 diferentes tipos de busca : Nomal,
 por categoria e  promocional.


Possibilidade de especificar a busca de produtos com base em 3 critérios:

1. Quantidade de produtos exibidos por página, sendo 15 por padrão
2. A categoria de produtos
3. A ordem de exibição dos produtos


1. Busca Normal =>nome do produto precisa ser especificado. Se não for especificado, será usada ordem de "relevância".

2. Busca por categoria => especificar a categoria que está se buscando, se não for especificada , voltará a ser normal.
Ordem : mais recente, a menos que um valor seja especificado.

3. Busca promocional => Categoria será sempre "em promoção" e p resiltado será ordenado por "mais recente" não importando os outros valores

Como foi decidido a implementação :

Será recebido um objeto ParametrosDeBusca com os seguintes atributos :

1. tipoDeBusca : "normal", "categoria" ou "promocional" (indicado pelo usuário)
2. resultadosPorPagina : número de resultados por página
3. categoria : define que tipo de produto deve ser pesquisado
4. ordenarPor : informa o critério de ordenação escolhido pelo usuário


Definição da classe :
```csharp
public	class	ParametrosDeBusca	{
	private	int	resultadosPorPagina	=	15;
	private	Categoria	categoria	=	Categoria.TUDO;
	private	TipoDeBusca	tipoDeBusca	=	TipoDeBusca.NORMAL;
	private	OrdenarPor	ordernarPor	=	OrdenarPor.RELEVANCIA;
}

```
O Enum abaixo representa a categoria

```csharp
public	enum	OrdenarPor	{
	RECENTE,	PRECO,	RELEVANCIA
}

```



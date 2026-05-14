# 📘 Capítulo 04 — FACTORY:	GERENCIANDO A	CRIAÇÃO	DE	OBJETOS

---
## 📌 Visão Geral

Neste capítulo, será abordado o padrão de projeto **Factory**, que é um dos padrões mais comuns e úteis para gerenciar a criação de objetos em sistemas orientados a objetos.

---

## 🧩 O que é o padrão Factory?
O padrão Factory é um **padrão de criação** que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

## ### 🔹 Vantagens do padrão Factory
- **Desacoplamento**: O código cliente não precisa conhecer as classes concretas que estão sendo instanciadas, promovendo um baixo acoplamento.
- **Flexibilidade**: Permite que o sistema seja facilmente estendido para criar novos tipos de objetos sem modificar o código cliente.
- **Centralização da criação de objetos**: Facilita a manutenção e evolução do código, pois a lógica de criação está concentrada em um único lugar.	

## Exemplo prático em C#
Melhorar a busca em um site de compras.

1. Definir os tipos diferentes de busca
<pre>
public enum TipoDeBusca
    {
        NORMAL, POR_CATEGORIA, PROMOCIONAL
    }
</pre>

2. Espeficicar os campos da busca :
a-) Quantidade de produtos exibidos por página, sendo 15 padrão
b-) Categoria dos produtos
c-) Ordem de exibição dos produtos

Sobre as categorias:
Normal => apenas o nome do produt precisa ser especificado ( padrão será por relevância)
Por categoria => espeficicar categoria (padrão Normal), ordem se não for espeficicada será a "mais recente"
Promocional => Ordem deve ser a "mais recente" não importando os outros valores

<pre>
public enum Categoria
    {
        TUDO, EM_PROMOCAO, ELETRONICOS
    }

public enum OrdenarPor
    {
        RECENTE, PRECO, RELEVANCIA, NAO_ESPECIFICADO
    }
</pre>

Com isso os parametros da busca terão os seguintes campos :
a-) Tipo de busca => Indica o tipo de busca selecionado pelo usuário
b-) resultado por página = > Indica quantos produtos devem ser exibidos
c-) Categoria => define que tipo de produto deve ser pesquisado
d-) ordenarPor => qual o critério da ordenação dos produtos

<pre>
 public class ParametrosDeBusca
    {
        public int resultadosPorPagina { get; set; } = 15;
        public Categoria categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca tipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor ordernarPor { get; set; } = OrdenarPor.RELEVANCIA;
    }
</pre>


Foi definica uma classe Busca que recebe ParametrosDeBusca e a partir dele cria CriterioDeBusca.
Com o CriterioDeBusca definido a classe ServicodeBusca será usada para fazer a busca de fato.
<pre>

 public class Busca
    {
        private ServicoDeBusca servicoDeBusca;
        public Busca(ServicoDeBusca servicoDeBusca)
        {
            this.servicoDeBusca = servicoDeBusca;
        }
        public void por(ParametrosDeBusca parametros)
        {
            CriterioDeBusca criterio = criarCriterio(parametros);
            List<String> idsDeResultado =
                            servicoDeBusca.RealizarBuscaCom(criterio);
            EncontrarProdutosPorIds(idsDeResultado);

        }
    }

public CriterioDeBusca criarCriterio(ParametrosDeBusca parametros)
        {
            var criterio = new CriterioDeBusca
            {
                Paginacao = parametros.resultadosPorPagina,
                Categoria = parametros.categoria
            };
            TipoDeBusca busca = parametros.tipoDeBusca;


            if (busca == TipoDeBusca.PROMOCIONAL)
            {
                //	Busca	promocional	ignora	parâmetros	de	busca
                criterio.Categoria = Categoria.EM_PROMOCAO;
                criterio.OrdenarPor = OrdenarPor.RECENTE;
            }
            else if (busca == TipoDeBusca.POR_CATEGORIA)
            {
                criterio.Categoria = parametros.categoria;

                if (parametros.categoria == Categoria.TUDO)
                {
                    // Se categoria não for especificada, volta para busca normal
                    criterio.OrdenarPor = OrdenarPor.RELEVANCIA;
                }
                else
                {
                    // Se tiver categoria, ordena conforme parâmetro
                    criterio.OrdenarPor = parametros.ordernarPor;
                }
            }
            else
            {   //Busca	normal
                criterio.OrdenarPor = parametros.ordernarPor;
            }
            return criterio;
        }

</pre>

Nesse exemplo o metodo criarCriterio ficou com vários "ifs" e dificil de manter.
Seria interessante :
a-) Criar uma classe para cada tipo de busca, cada uma com sua própria implementação do método criarCriterio.
b-) Criar uma interface ou classe abstrata para definir o contrato do método criarCriterio, e cada classe de busca concreta implementaria essa interface ou estenderia a classe abstrata.
c-) Utilizar um padrão de projeto Factory para criar as instâncias das classes de busca com base no tipo de busca selecionado pelo usuário, centralizando a lógica de criação e facilitando a manutenção do código.
d-) Dessa forma, o código ficaria mais organizado, fácil de entender e manter, além de seguir os princípios de design orientado a objetos, como o princípio da responsabilidade única e o princípio da substituição de Liskov.


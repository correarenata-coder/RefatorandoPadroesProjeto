

using capitulo04;


//cria Criterio De Busca Normal

ServicoDeBusca servico = new ServicoDeBusca(); 

Busca busca = new Busca(servico);

ParametrosDeBusca parametros = new ParametrosDeBusca();

// Espeficificando os parâmetros de busca, por pagina
parametros.resultadosPorPagina = 20;

CriterioDeBusca criterio = busca.criarCriterio(parametros);

Console.WriteLine("Paginação é 15 ?" + (criterio.Paginacao == 15).ToString());
Console.WriteLine("Ordenação é Relevância ?" + ( criterio.OrdenarPor == OrdenarPor.RELEVANCIA).ToString());
Console.WriteLine("Categoria é TUDO ?" + (criterio.Categoria == Categoria.TUDO).ToString());






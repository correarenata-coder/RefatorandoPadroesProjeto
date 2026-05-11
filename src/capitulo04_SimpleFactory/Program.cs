



using capitulo04_SimpleFactory;

ServicoDeBusca servico = new ServicoDeBusca();

Busca busca = new Busca(servico);

ParametrosDeBusca parametros = new ParametrosDeBusca( TipoDeBusca.NORMAL);
busca.por(parametros);

CriterioDeBusca criterio = new FabricaDeCriterio(parametros).criarCriterio();

servico.RealizarBuscaCom(criterio);

Console.WriteLine("Busca executada.");


Console.WriteLine("Paginação é 15 ?" + (criterio.Paginacao == 15).ToString());
Console.WriteLine("Ordenação é Relevância ?" + (criterio.OrdenarPor == OrdenarPor.RELEVANCIA).ToString());
Console.WriteLine("Categoria é TUDO ?" + (criterio.Categoria == Categoria.TUDO).ToString());


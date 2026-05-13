//#region FactoruMethod

using capitulo04_FactoryMethod.ExemploLivro;


ServicoDeBusca servico = new ServicoDeBusca();

Busca busca = new Busca(servico);

var parametros = new ParametrosDeBusca(TipoDeBusca.POR_CATEGORIA, Engine.ElasticSearch);
//{
//    Engine = Engine.ElasticSearch,
//    tipoDeBusca = TipoDeBusca.PROMOCIONAL,
//    categoria = Categoria.ELETRONICOS,
//     ordernarPor = OrdenarPor.PRECO,

//};
//var busca = new Busca


busca.Por(parametros);

CriterioDeBusca criterio = FabricaDeBusca.Criar(parametros).CriarCriterio();


Console.WriteLine("Engine ?" + (criterio.engine ).ToString());
Console.WriteLine("Paginação é 15 ?" + (criterio.Paginacao == 15).ToString());
Console.WriteLine("Ordenação é Relevância ?" + (criterio.OrdenarPor == OrdenarPor.RELEVANCIA).ToString());
Console.WriteLine("Categoria é TUDO ?" + (criterio.Categoria == Categoria.TUDO).ToString());


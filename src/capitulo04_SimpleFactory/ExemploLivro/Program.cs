using capitulo04_SimpleFactory.ExemploLivro;


#region FabricaDeCriterioTest

//ParametrosDeBusca parametros = new ParametrosDeBusca( TipoDeBusca.NORMAL);

//var  criterio = new FabricaDeCriterio(parametros).criarCriterio();



//Console.WriteLine("Paginação é 15 ?" + (criterio.Paginacao == 15).ToString());
//Console.WriteLine("Ordenação é Relevância ?" + (criterio.OrdenarPor == OrdenarPor.RELEVANCIA).ToString());
//Console.WriteLine("Categoria é TUDO ?" + (criterio.Categoria == Categoria.TUDO).ToString());

#endregion


#region Teste Busca

ServicoDeBusca servico = new ServicoDeBusca();

Busca busca = new Busca(servico);
ParametrosDeBusca param = new ParametrosDeBusca(TipoDeBusca.NORMAL);
busca.por(param);
CriterioDeBusca criterio2 =
                new FabricaDeCriterio(param).criarCriterio();

Console.WriteLine(
               $"Critério criado: {criterio2.Categoria}");

#endregion
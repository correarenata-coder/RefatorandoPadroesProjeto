//#region FactoruMethod

using capitulo04_FactoryMethod.ExemploLivro;
using capitulo04_FactoryMethod.ExemploLivro.Criterios;
using capitulo04_FactoryMethod.ExemploLivro.Enum;
using capitulo04_FactoryMethod.ExemploLivro.Model;
using capitulo04_FactoryMethod.ExemploLivro.Services;



var parametros = new ParametrosDeBusca(TipoDeBusca.NORMAL,10,Categoria.TUDO, OrdenarPor.RECENTE, Engine.Banco);

var servico =
    new ServicoDeBusca();

var busca =
    new Busca(servico);

var criterio =busca.Por(parametros);



Console.WriteLine("Engine ?" + (criterio.Engine ).ToString());
Console.WriteLine("Paginação é 15 ?" + (criterio.Paginacao == 15).ToString());
Console.WriteLine("Ordenação é Relevância ?" + (criterio.OrdenarPor == OrdenarPor.RELEVANCIA).ToString());
Console.WriteLine("Categoria é TUDO ?" + (criterio.Categoria == Categoria.TUDO).ToString());


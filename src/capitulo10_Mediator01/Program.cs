using capitulo10_Mediator01;

IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

User macoratti = new ConcreteUser(facebookMediator, "Macoratti");
User ana = new ConcreteUser(facebookMediator, "ana");
User joao = new ConcreteUser(facebookMediator, "joao");

facebookMediator.RegisterUser(macoratti);
facebookMediator.RegisterUser(ana);
facebookMediator.RegisterUser(joao);


macoratti.Send("O canal macoratti .net está apresentando padrões de projeto");
ana.Send("aqui estão os vídeos");
macoratti.Send("Veja aqui");

Console.Read();
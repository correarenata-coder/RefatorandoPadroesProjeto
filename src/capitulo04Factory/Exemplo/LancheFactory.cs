namespace capitulo04FactoryAdicional.Exemplo
{
    public class LancheFactory : LancheFactoryMethod
    {
        //public override Lanche CriarLanche(int tipo)
        //{
        //    if (tipo == 1)
        //    {
        //        return new Bauru();
        //    }
        //    else if (tipo == 2)
        //    {
        //        return new Frango();
        //    }
        //    else if (tipo == 3)
        //    {
        //        return new MistoQuente();
        //    }
        //    else if (tipo == 4)
        //    {
        //        return new Vegetariano();
        //    }
        //    else
        //    {
        //        throw new System.ArgumentException("Lanche não encontrada");
        //    }
        //}


        // Opção para não ficar vários ifs

        public override Lanche CriarLanche(int tipo)
        {
            var factory = LancheFactories[tipo];
            return factory();
        }


        //Criamos um método estático chamado LancheFactories onde usamos a classe Dictionary que representa uma coleção de
        //chaves e valores.
        public static Dictionary<int, Func<Lanche>> LancheFactories =
                 new Dictionary<int, Func<Lanche>>
       {
                  { 1, ()=>new Bauru() },
                  { 2, ()=>new Frango() },
                  { 3, ()=>new MistoQuente()},
                  { 4, ()=>new Vegetariano() },
       };
    }
}

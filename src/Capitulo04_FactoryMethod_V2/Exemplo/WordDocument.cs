using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo04_FactoryMethod_V2.Exemplo
{
    public class WordDocument : IDocument
    {
        public void Generate()
        => Console.WriteLine("Gerando um documento Word...");
    }
}

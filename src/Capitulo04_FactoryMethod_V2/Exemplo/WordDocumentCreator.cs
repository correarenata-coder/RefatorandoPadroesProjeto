using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo04_FactoryMethod_V2.Exemplo
{
    public class WordDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        => new WordDocument();
    }
}

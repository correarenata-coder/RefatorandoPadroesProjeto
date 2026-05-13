using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo04_FactoryMethod_V2.Exemplo
{
    public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();

        public void GenerateDocument()
            {
                var document = CreateDocument();
                document.Generate();
        }
    }
}

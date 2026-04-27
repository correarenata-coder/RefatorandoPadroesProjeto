using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04Factory
{
    public class Frango :Lanche
    {
        public Frango()
        {
            Ingredientes.Add("Lanche Frango");
            Ingredientes.Add("Peito de frango");           
            Ingredientes.Add("Tomate e maionese");

        }
    }
}

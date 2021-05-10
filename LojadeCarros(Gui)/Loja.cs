using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCarro
{
    public class Loja
    {


        public List<Carro> ListaCarros { get; set; }
        public List<Carro> ListaDeCompras { get; set; }
        public Loja()
        {
            ListaCarros = new List<Carro>();
            ListaDeCompras = new List<Carro>();
        }

        public decimal Checkout ()
        {
            decimal valorTotal = 0;
            foreach (var c in ListaDeCompras)
            {
                valorTotal = valorTotal + c.Preço;
            }
            //ListaDeCompras.Clear();
            return valorTotal;
        }

        public override string ToString()
        {
            return $"{ListaDeCompras}";
        }
    }
}

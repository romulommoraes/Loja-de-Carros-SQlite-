using System;

namespace ClasseCarro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Preço { get; set; }
        public int Ano { get; set; }
        public string Estado { get; set; }
        public string Portas { get; set; }
        public int Qtd { get; set; }
        public string Codigo { get; set; }

        public Carro()
        {
            this.Marca = "marca";
            this.Modelo = "modelo";
            this.Preço = 0.0M;
            this.Ano = 0000;
            this.Estado = "estado";
            this.Portas = "portas";
            this.Qtd = 0;
            this.Codigo = "00000000";
        }

        public Carro(string a, string b, decimal c, int d, string e, string f, int g, string h)
        {
            this.Marca = a;
            this.Modelo = b;
            this.Preço = c;
            this.Ano = d;
            this.Estado = e;
            this.Portas = f;
            this.Qtd = g;
            this.Codigo = h;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, PreçoR$: {Preço}";
        }
        public string ToStringData()
        {
            return $"{Marca}\t{Modelo}\t{Preço}\t{Ano}\t{Estado}\t{Portas}\t{Qtd}\t{Codigo}";
        }
    }
}


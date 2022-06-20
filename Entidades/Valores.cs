using System;

namespace Entidades
{
    public class Valores
    {
        public Decimal? ValorSolicitado  { get; set; }

       
    }

    public class Notas
    {
        public int Quantidade { get; set; }
        public Double Cedulas { get; set; }
    }

    public class ListaNotas
    {
        public int Quantidade { get; set; }
        public Double Cedulas { get; set; }
    }

    public class NotasSaque
    {
        public Double Cedulas1 { get; set; }
        public Double Cedulas2 { get; set; }
        public Double Cedulas3 { get; set; }
    }
}

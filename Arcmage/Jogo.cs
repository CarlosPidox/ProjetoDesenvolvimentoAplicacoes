//------------------------------------------------------------------------------
// <auto-generated>
//    Este código foi gerado a partir de um modelo.
//
//    Alterações manuais a este ficheiro poderão provocar um comportamento inesperado da sua aplicação.
//    Alterações manuais a este ficheiro serão substituídas se o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arcmage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jogo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public System.DateTime Data { get; set; }
        public int Numero { get; set; }
    
        public virtual Arbitro Arbitro { get; set; }
        public virtual Deck Deck1 { get; set; }
        public virtual Deck Deck2 { get; set; }
    }
}

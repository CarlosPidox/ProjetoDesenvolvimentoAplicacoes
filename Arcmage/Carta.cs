//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arcmage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carta()
        {
            this.Deck = new HashSet<Deck>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Facao { get; set; }
        public string Tipo { get; set; }
        public string Custo { get; set; }
        public int Lealdade { get; set; }
        public string Texto { get; set; }
        public Nullable<int> Ataque { get; set; }
        public Nullable<int> Defesa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deck> Deck { get; set; }
    }
}

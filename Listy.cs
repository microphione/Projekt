//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaZakupow
{
    using System;
    using System.Collections.Generic;
    
    public partial class Listy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Listy()
        {
            this.Produkty = new HashSet<Produkty>();
        }
    
        public int ID { get; set; }
        public int UzytkownikID { get; set; }
        public string Nazwa { get; set; }
    
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autopilot
{
    using System;
    using System.Collections.Generic;
    
    public partial class buchung
    {
        public int buc_id { get; set; }
        public int auf_id { get; set; }
        public Nullable<System.DateTime> buc_datum { get; set; }
        public Nullable<decimal> buc_soll { get; set; }
        public Nullable<decimal> buc_haben { get; set; }
        public string buc_text { get; set; }
    }
}

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
    
    public partial class auftrag
    {
        public int auf_id { get; set; }
        public int sta_id { get; set; }
        public Nullable<int> aart_id { get; set; }
        public Nullable<int> knd_id { get; set; }
        public Nullable<int> mst_id { get; set; }
        public Nullable<int> ablg_id { get; set; }
        public Nullable<int> flh_id_beginn { get; set; }
        public Nullable<int> flh_id_ende { get; set; }
        public Nullable<decimal> auf_panzahl { get; set; }
        public Nullable<decimal> auf_dauer_h { get; set; }
        public string auf_wuensche { get; set; }
        public Nullable<decimal> auf_preis { get; set; }
        public Nullable<decimal> auf_zusatzkosten { get; set; }
        public Nullable<System.DateTime> auf_faellig_am { get; set; }
    }
}

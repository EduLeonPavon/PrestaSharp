//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ps_address
    {
        public long id_address { get; set; }
        public long id_country { get; set; }
        public Nullable<long> id_state { get; set; }
        public long id_customer { get; set; }
        public long id_manufacturer { get; set; }
        public long id_supplier { get; set; }
        public long id_warehouse { get; set; }
        public string alias { get; set; }
        public string company { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string postcode { get; set; }
        public string city { get; set; }
        public string other { get; set; }
        public string phone { get; set; }
        public string phone_mobile { get; set; }
        public string vat_number { get; set; }
        public string dni { get; set; }
        public System.DateTime date_add { get; set; }
        public System.DateTime date_upd { get; set; }
        public bool active { get; set; }
        public bool deleted { get; set; }
    }
}

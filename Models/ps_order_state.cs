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
    
    public partial class ps_order_state
    {
        public long id_order_state { get; set; }
        public Nullable<bool> invoice { get; set; }
        public bool send_email { get; set; }
        public string module_name { get; set; }
        public string color { get; set; }
        public bool unremovable { get; set; }
        public bool hidden { get; set; }
        public bool logable { get; set; }
        public bool delivery { get; set; }
        public bool shipped { get; set; }
        public bool paid { get; set; }
        public bool deleted { get; set; }
    }
}

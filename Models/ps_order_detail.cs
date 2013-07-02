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
    
    public partial class ps_order_detail
    {
        public long id_order_detail { get; set; }
        public long id_order { get; set; }
        public Nullable<int> id_order_invoice { get; set; }
        public Nullable<long> id_warehouse { get; set; }
        public long id_shop { get; set; }
        public long product_id { get; set; }
        public Nullable<long> product_attribute_id { get; set; }
        public string product_name { get; set; }
        public long product_quantity { get; set; }
        public int product_quantity_in_stock { get; set; }
        public long product_quantity_refunded { get; set; }
        public long product_quantity_return { get; set; }
        public long product_quantity_reinjected { get; set; }
        public decimal product_price { get; set; }
        public decimal reduction_percent { get; set; }
        public decimal reduction_amount { get; set; }
        public decimal reduction_amount_tax_incl { get; set; }
        public decimal reduction_amount_tax_excl { get; set; }
        public decimal group_reduction { get; set; }
        public decimal product_quantity_discount { get; set; }
        public string product_ean13 { get; set; }
        public string product_upc { get; set; }
        public string product_reference { get; set; }
        public string product_supplier_reference { get; set; }
        public decimal product_weight { get; set; }
        public bool tax_computation_method { get; set; }
        public string tax_name { get; set; }
        public decimal tax_rate { get; set; }
        public decimal ecotax { get; set; }
        public decimal ecotax_tax_rate { get; set; }
        public bool discount_quantity_applied { get; set; }
        public string download_hash { get; set; }
        public Nullable<long> download_nb { get; set; }
        public Nullable<System.DateTime> download_deadline { get; set; }
        public decimal total_price_tax_incl { get; set; }
        public decimal total_price_tax_excl { get; set; }
        public decimal unit_price_tax_incl { get; set; }
        public decimal unit_price_tax_excl { get; set; }
        public decimal total_shipping_price_tax_incl { get; set; }
        public decimal total_shipping_price_tax_excl { get; set; }
        public decimal purchase_supplier_price { get; set; }
        public decimal original_product_price { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaModelos.Modelos
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class CAB_FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAB_FACTURA()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
        }
    
        public int id_cfactura { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int id_cliente { get; set; }
        public int id_estado_pago { get; set; }
        public int id_estado_envio { get; set; }
        public string ruc_emisor { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ESTADO_ENVIO ESTADO_ENVIO { get; set; }
        public virtual ESTADO_PAGO ESTADO_PAGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
    }
}

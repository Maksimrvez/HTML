//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ycebnaia.Bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class yslygi_client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yslygi_client()
        {
            this.prodagi_yslyg_client = new HashSet<prodagi_yslyg_client>();
        }
    
        public int id_yslyg_client { get; set; }
        public int id_client { get; set; }
        public int id_yslyg { get; set; }
        public string soglasit_client { get; set; }
        public System.DateTime nachalo_okazaniya_ys { get; set; }
        public Nullable<double> oplata { get; set; }
    
        public virtual client client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prodagi_yslyg_client> prodagi_yslyg_client { get; set; }
        public virtual yslygi yslygi { get; set; }
    }
}

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
    
    public partial class tip_clienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tip_clienta()
        {
            this.client = new HashSet<client>();
        }
    
        public int id_tip { get; set; }
        public string nazvanie { get; set; }
        public string color { get; set; }
        public string rasnovidnost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client> client { get; set; }
    }
}
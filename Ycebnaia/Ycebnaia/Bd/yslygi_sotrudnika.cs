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
    
    public partial class yslygi_sotrudnika
    {
        public int id_yslyg_sotrudnik { get; set; }
        public int id_sotrudnik { get; set; }
        public int id_yslyg { get; set; }
        public System.DateTime data_vremya_yslygi { get; set; }
    
        public virtual sotrudnik sotrudnik { get; set; }
        public virtual yslygi yslygi { get; set; }
    }
}

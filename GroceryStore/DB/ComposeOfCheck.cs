//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroceryStore.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComposeOfCheck
    {
        public int idCheck { get; set; }
        public int idProduct { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<double> fullPrice { get; set; }
        public Nullable<int> price { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
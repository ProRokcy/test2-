//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int Id { get; set; }
        public Nullable<int> IdExecutor { get; set; }
        public string Title { get; set; }
        public string Descripshion { get; set; }
        public int IdStatus { get; set; }
        public int IdProject { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Status Status { get; set; }
        public virtual Users Users { get; set; }
    }
}

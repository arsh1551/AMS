//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcessLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogInfo
    {
        public string ModuleName { get; set; }
        public string FieldName { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public string ModifiedBy { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
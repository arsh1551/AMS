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
    
    public partial class sp_GetFoldersWithPermissions_Result
    {
        public long FolderId { get; set; }
        public string FolderName { get; set; }
        public string FolderPath { get; set; }
        public Nullable<long> ParentFolderId { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}

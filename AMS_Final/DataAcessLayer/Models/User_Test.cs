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
    
    public partial class User_Test
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public string Profession { get; set; }
        public string UserCode { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> UserRoleId { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}

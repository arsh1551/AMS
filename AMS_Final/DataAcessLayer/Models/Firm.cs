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
    
    public partial class Firm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firm()
        {
            this.Clients = new HashSet<Client>();
            this.IndividualRoles = new HashSet<IndividualRole>();
        }
    
        public long FirmId { get; set; }
        public string FirmName { get; set; }
        public string FirmLogo { get; set; }
        public string FirmAddress1 { get; set; }
        public string FirmAddress2 { get; set; }
        public string FirmCity { get; set; }
        public string FirmState { get; set; }
        public string FirmZip { get; set; }
        public string FirmPhone { get; set; }
        public string FirmEmail { get; set; }
        public string FirmWebsite { get; set; }
        public Nullable<long> FirmRootFolderId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualRole> IndividualRoles { get; set; }
    }
}

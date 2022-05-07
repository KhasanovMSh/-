//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ООО__Телеком_Нева_Связь_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscribers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscribers()
        {
            this.CrmRequests = new HashSet<CrmRequests>();
            this.SubscriberAdress = new HashSet<SubscriberAdress>();
        }
    
        public int Id { get; set; }
        public string SubscriberNumber { get; set; }
        public string FIO { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PlaceOfResidence { get; set; }
        public string ResidentialAddress { get; set; }
        public string SeriesAndPassportNumber { get; set; }
        public string DepartmentCode { get; set; }
        public string IssuedBy { get; set; }
        public Nullable<System.DateTime> PassportIssueDate { get; set; }
        public string NumberOfContract { get; set; }
        public Nullable<System.DateTime> DateOfConclusionContract { get; set; }
        public string ContractType { get; set; }
        public string ReasonForTermination { get; set; }
        public string PersonalAccount { get; set; }
        public string Services { get; set; }
        public Nullable<System.DateTime> ContractTerminationDate { get; set; }
        public string EquipmentRent { get; set; }
        public string SerialNumberOfEquipment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrmRequests> CrmRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberAdress> SubscriberAdress { get; set; }
    }
}

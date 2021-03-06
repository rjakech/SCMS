//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsReceivedNote
    {
        public GoodsReceivedNote()
        {
            this.GoodsReceivedNoteItems = new HashSet<GoodsReceivedNoteItem>();
            this.Notifications = new HashSet<Notification>();
        }
    
        public System.Guid Id { get; set; }
        public string RefNumber { get; set; }
        public System.Guid SupplierId { get; set; }
        public string DnNumber { get; set; }
        public Nullable<System.DateTime> DeliverDate { get; set; }
        public System.Guid CountryOfficeId { get; set; }
        public System.Guid PurchaseOrderId { get; set; }
        public string Remarks { get; set; }
        public bool GoodCondition { get; set; }
        public bool CorrectQuantity { get; set; }
        public bool GoodsDamaged { get; set; }
        public bool Shortfall { get; set; }
        public string DeliveredBy { get; set; }
        public string DeliveryCompany { get; set; }
        public string VehicleRegNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
        public System.Guid ReceivedBy { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
        public long Index { get; set; }
        public bool Verified { get; set; }
        public Nullable<System.Guid> PreparedBy { get; set; }
        public Nullable<System.DateTime> PreparedOn { get; set; }
        public Nullable<System.Guid> ReceptionApprovedBy { get; set; }
        public bool IsSubmitted { get; set; }
        public bool IsRejected { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public System.Guid WareHouseId { get; set; }
    
        public virtual CountrySubOffice CountrySubOffice { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public virtual ICollection<GoodsReceivedNoteItem> GoodsReceivedNoteItems { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}

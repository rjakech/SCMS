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
    
    public partial class OrderRequest
    {
        public OrderRequest()
        {
            this.DocumentBackDatings = new HashSet<DocumentBackDating>();
            this.Notifications = new HashSet<Notification>();
            this.OrderRequestItems = new HashSet<OrderRequestItem>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }
    
        public System.Guid Id { get; set; }
        public string RefNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public System.Guid CurrencyId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.Guid> RequestedDestinationId { get; set; }
        public Nullable<System.Guid> FinalDestinationId { get; set; }
        public string Remarks { get; set; }
        public System.Guid PreparedBy { get; set; }
        public Nullable<System.Guid> ReviewedBy { get; set; }
        public Nullable<System.Guid> AuthorizedBy { get; set; }
        public Nullable<System.DateTime> PreparedOn { get; set; }
        public Nullable<System.DateTime> ReviewedOn { get; set; }
        public Nullable<System.DateTime> AuthorizedOn { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> FromOneBL { get; set; }
        public Nullable<System.Guid> CountryProgrammeId { get; set; }
        public Nullable<bool> IsReviewed { get; set; }
        public Nullable<bool> IsAuthorized { get; set; }
        public string RejectedReviewRemarks { get; set; }
        public string RejectedAuthorizeRemarks { get; set; }
        public int RecordCount { get; set; }
        public Nullable<System.Guid> MBCurrencyId { get; set; }
        public Nullable<decimal> MBValue { get; set; }
        public Nullable<System.Guid> ProjectDonorId { get; set; }
        public Nullable<bool> IsRejected { get; set; }
        public bool IsSubmitted { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.Guid> ApprovedBy { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
    
        public virtual CountryProgramme CountryProgramme { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual ICollection<DocumentBackDating> DocumentBackDatings { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Staff Staff2 { get; set; }
        public virtual ProjectDonor ProjectDonor { get; set; }
        public virtual Staff Staff3 { get; set; }
        public virtual ICollection<OrderRequestItem> OrderRequestItems { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

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
    
    public partial class BudgetCommitment
    {
        public BudgetCommitment()
        {
            this.Rebookings = new HashSet<Rebooking>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid BudgetLineId { get; set; }
        public decimal AmountCommitted { get; set; }
        public System.DateTime DateCommitted { get; set; }
        public Nullable<System.Guid> OrderRequestItemId { get; set; }
        public Nullable<System.Guid> PurchaseOrderItemId { get; set; }
        public Nullable<System.Guid> RFPBudgetLineId { get; set; }
    
        public virtual OrderRequestItem OrderRequestItem { get; set; }
        public virtual ProjectBudget ProjectBudget { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
        public virtual PaymentRequestBudgetLine PaymentRequestBudgetLine { get; set; }
        public virtual ICollection<Rebooking> Rebookings { get; set; }
    }
}

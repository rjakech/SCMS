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
    
    public partial class GoodsIssuedVoucherItem
    {
        public System.Guid Id { get; set; }
        public System.Guid GoodsIssuedVoucherId { get; set; }
        public Nullable<System.Guid> WarehouseReleaseItemId { get; set; }
        public long QTYDelivered { get; set; }
        public string Remarks { get; set; }
    
        public virtual GoodsIssuedVoucher GoodsIssuedVoucher { get; set; }
        public virtual WarehouseReleaseItem WarehouseReleaseItem { get; set; }
    }
}

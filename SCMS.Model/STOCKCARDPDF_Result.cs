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
    
    public partial class STOCKCARDPDF_Result
    {
        public string BINNO { get; set; }
        public Nullable<System.DateTime> Issuedate { get; set; }
        public string ConvertedIssueDate { get; set; }
        public string DNNumber { get; set; }
        public string DocNumber { get; set; }
        public Nullable<int> QntyIssued { get; set; }
        public Nullable<int> QntyReceived { get; set; }
        public Nullable<int> BalanceStock { get; set; }
        public string WareHouseManager { get; set; }
    }
}
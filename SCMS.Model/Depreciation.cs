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
    
    public partial class Depreciation
    {
        public System.Guid Id { get; set; }
        public System.Guid AssetId { get; set; }
        public double MonthlyDepreciation { get; set; }
        public double AccDepreciation { get; set; }
        public double NetbookValue { get; set; }
        public int Period { get; set; }
        public double AnnualDepreciation { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Asset Asset { get; set; }
    }
}

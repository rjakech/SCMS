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
    
    public partial class VProjectDonor
    {
        public string DonorName { get; set; }
        public string DonorShortName { get; set; }
        public System.Guid CountryId { get; set; }
        public System.Guid ProjectId { get; set; }
        public System.Guid DonorId { get; set; }
        public Nullable<System.Guid> CurrencyId { get; set; }
        public string DonorProNo { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
        public string ProjectShortName { get; set; }
        public string Currency { get; set; }
    }
}

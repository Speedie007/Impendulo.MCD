//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impendulo.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApprenticeshipEnrollmentDocument
    {
        public int ApprenticeshipEnrollmentDocumentID { get; set; }
        public int EnrollmentID { get; set; }
        public int ImageID { get; set; }
        public int LookupEnrollentDocumentTypeID { get; set; }
    
        public virtual ApprienticeshipEnrollment ApprienticeshipEnrollment { get; set; }
        public virtual LookupEnrollentDocumentType LookupEnrollentDocumentType { get; set; }
        public virtual File File { get; set; }
    }
}

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
    
    public partial class ApprienticeshipEnrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApprienticeshipEnrollment()
        {
            this.ApprenticeshipEnrollmentDocuments = new ObservableListSource<ApprenticeshipEnrollmentDocument>();
        }
    
        public int EnrollmentID { get; set; }
        public int LookupSectionalEnrollmentTypeID { get; set; }
    
        public virtual Enrollment Enrollment { get; set; }
        public virtual LookupSectionalEnrollmentType LookupSectionalEnrollmentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<ApprenticeshipEnrollmentDocument> ApprenticeshipEnrollmentDocuments { get; set; }
    }
}

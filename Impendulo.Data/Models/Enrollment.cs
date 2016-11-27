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
    
    public partial class Enrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enrollment()
        {
            this.CurriculumCourseEnrollments = new ObservableListSource<CurriculumCourseEnrollment>();
            this.CurriculumEnquiries = new ObservableListSource<CurriculumEnquiry>();
            this.Schedules = new ObservableListSource<Schedule>();
        }
    
        public int EnrollmentID { get; set; }
        public int LookupEnrollmentProgressStateID { get; set; }
        public int CurriculumID { get; set; }
        public System.DateTime DateIntitiated { get; set; }
        public int IndividualID { get; set; }
        public Nullable<int> EnrolmentParentID { get; set; }
        public Nullable<bool> EnrollmentExcempt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumCourseEnrollment> CurriculumCourseEnrollments { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual LookupEnrollmentProgressState LookupEnrollmentProgressState { get; set; }
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumEnquiry> CurriculumEnquiries { get; set; }
        public virtual ApprienticeshipEnrollment ApprienticeshipEnrollment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Schedule> Schedules { get; set; }
    }
}
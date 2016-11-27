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
    
    public partial class CurriculumCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CurriculumCourse()
        {
            this.CurriculumCourseEnrollments = new ObservableListSource<CurriculumCourseEnrollment>();
            this.CurriculumCourseModules = new ObservableListSource<CurriculumCourseModule>();
            this.CurriculumCoursePredecessors = new ObservableListSource<CurriculumCoursePredecessor>();
            this.VenueAssociatedCurriculumCourses = new ObservableListSource<VenueAssociatedCurriculumCourse>();
            this.LookupSetas = new ObservableListSource<LookupSeta>();
            this.CurriculumEquirySelectedCourses = new ObservableListSource<CurriculumEquirySelectedCours>();
            this.CurriculumPrequisiteCourses = new ObservableListSource<CurriculumPrequisiteCourse>();
            this.Schedules = new ObservableListSource<Schedule>();
        }
    
        public int CurriculumCourseID { get; set; }
        public int CurriculumCourseParentID { get; set; }
        public int CurriculumID { get; set; }
        public int CourseID { get; set; }
        public int EnrollmentTypeID { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual CurricullumCourseCode CurricullumCourseCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumCourseEnrollment> CurriculumCourseEnrollments { get; set; }
        public virtual CurriculumCourseMinimumMaximum CurriculumCourseMinimumMaximum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumCourseModule> CurriculumCourseModules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumCoursePredecessor> CurriculumCoursePredecessors { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual LookupEnrollmentType LookupEnrollmentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<VenueAssociatedCurriculumCourse> VenueAssociatedCurriculumCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<LookupSeta> LookupSetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumEquirySelectedCours> CurriculumEquirySelectedCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumPrequisiteCourse> CurriculumPrequisiteCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Schedule> Schedules { get; set; }
    }
}
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
    
    public partial class CurriculumCourseMinimumMaximum
    {
        public int CurriculumCourseID { get; set; }
        public int CurriculumCourseMinimum { get; set; }
        public int CurriculumCourseMaximum { get; set; }
    
        public virtual CurriculumCourse CurriculumCourse { get; set; }
    }
}

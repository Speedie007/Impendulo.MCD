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
    
    public partial class EmailMessageRepositoryHistory
    {
        public int EmailMessageRepositoryHistoryID { get; set; }
        public int EmailMessageRepositoryID { get; set; }
        public int EmailMessageRepositoryHistoryTrancationTypeID { get; set; }
        public System.DateTime DateTransactionCompleted { get; set; }
    
        public virtual EmailMessageRepository EmailMessageRepository { get; set; }
        public virtual LookupEmailMessageRepositoryHistoryTrancationType LookupEmailMessageRepositoryHistoryTrancationType { get; set; }
    }
}

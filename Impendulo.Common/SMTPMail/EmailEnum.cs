using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Common.Enum
{
    public enum AttachmentType : int
    {
        PathBasedAttachment = 1,
        DatabaseImageAttachment = 2
    }
    public partial class EmailAttachmentMetaData
    {

        public AttachmentType CurrentAttachmentType { get; set; }
        public string AttachmentPath { get; set; }
        public int DatabaseFileID { get; set; }

        public EmailAttachmentMetaData(int _DatabseFileID)
        {
            CurrentAttachmentType = AttachmentType.DatabaseImageAttachment;
            this.DatabaseFileID = _DatabseFileID;
        }
        public EmailAttachmentMetaData(string _AttachmentPath)
        {
            CurrentAttachmentType = AttachmentType.PathBasedAttachment;
            this.AttachmentPath = _AttachmentPath;
        }
       

    }


}

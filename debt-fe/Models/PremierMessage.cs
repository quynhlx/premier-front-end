//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace debt_fe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PremierMessage
    {
        public int MessageISN { get; set; }
        public Nullable<int> MemberISN { get; set; }
        public string MsgSubject { get; set; }
        public string LastMessage { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public Nullable<int> addedBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public Nullable<int> updatedBy { get; set; }
        public Nullable<byte> ClientRead { get; set; }
    
        public virtual Member Member { get; set; }
    }
}

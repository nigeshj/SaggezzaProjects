//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiExample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int SID { get; set; }
        public string Name { get; set; }
        public Nullable<int> PID { get; set; }
        public string CID { get; set; }
    
        public virtual Professor Professor { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CC_MVC1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental1
    {
        public string ClientNo { get; set; }
        public string propertyNo { get; set; }
        public System.DateTime rentStart { get; set; }
        public System.DateTime rentFinish { get; set; }
        public decimal rent { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Property Property { get; set; }
    }
}
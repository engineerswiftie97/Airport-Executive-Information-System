//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AirportTerminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AirportTerminal()
        {
            this.ApronInformations = new HashSet<ApronInformation>();
        }
    
        public int TerminalID { get; set; }
        public string TerminalName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApronInformation> ApronInformations { get; set; }

        public override string ToString()
        {
            return TerminalName;
        }
    }
}
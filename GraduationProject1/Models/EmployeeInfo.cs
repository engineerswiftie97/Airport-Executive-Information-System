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
    
    public partial class EmployeeInfo
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeKeyword { get; set; }
        public string CardNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeShiftDates { get; set; }
        public string EmployeeAdress { get; set; }
        public int WorkFieldID { get; set; }
    
        public virtual WorkField WorkField { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Windows_And_Doors_Project_CS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_Transaction
    {
        public int Transaction_Id { get; set; }
        public int Employee_Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Paid { get; set; }
    
        public virtual Employee_salary Employee_salary { get; set; }
    }
}

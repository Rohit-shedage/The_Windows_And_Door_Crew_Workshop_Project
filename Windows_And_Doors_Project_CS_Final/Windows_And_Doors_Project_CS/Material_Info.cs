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
    
    public partial class Material_Info
    {
        public int Material_Id { get; set; }
        public string Material_Name { get; set; }
        public int Group_Id { get; set; }
    
        public virtual Material_Group Material_Group { get; set; }
    }
}

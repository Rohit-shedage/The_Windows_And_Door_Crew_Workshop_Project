﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class The_Windows_And_Door_Crew_DBEntities : DbContext
    {
        public The_Windows_And_Door_Crew_DBEntities()
            : base("name=The_Windows_And_Door_Crew_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Catagory> Catagories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Transaction> Customer_Transaction { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<Distributor_Material> Distributor_Material { get; set; }
        public virtual DbSet<Distributor_Transaction> Distributor_Transaction { get; set; }
        public virtual DbSet<Employee_Details> Employee_Details { get; set; }
        public virtual DbSet<Employee_salary> Employee_salary { get; set; }
        public virtual DbSet<Employee_Transaction> Employee_Transaction { get; set; }
        public virtual DbSet<Maintainance> Maintainances { get; set; }
        public virtual DbSet<Material_Group> Material_Group { get; set; }
        public virtual DbSet<Material_Info> Material_Info { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Stock_Order> Stock_Order { get; set; }
        public virtual DbSet<Stock_Order_Items> Stock_Order_Items { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Material_Colour> Material_Colour { get; set; }
        public virtual DbSet<Material_Size> Material_Size { get; set; }
        public virtual DbSet<Material_Track> Material_Track { get; set; }
        public virtual DbSet<Material_Type> Material_Type { get; set; }
        public virtual DbSet<Ordered_Items> Ordered_Items { get; set; }
        public virtual DbSet<Product_Material> Product_Material { get; set; }
    }
}

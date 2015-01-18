﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampleModel.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities()
            : base("name=NorthwindEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Territories> Territories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Alphabetical_list_of_products> Alphabetical_list_of_products { get; set; }
        public DbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        public DbSet<Current_Product_List> Current_Product_List { get; set; }
        public DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_City { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Order_Details_Extended> Order_Details_Extended { get; set; }
        public DbSet<Order_Subtotals> Order_Subtotals { get; set; }
        public DbSet<Orders_Qry> Orders_Qry { get; set; }
        public DbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        public DbSet<Products_Above_Average_Price> Products_Above_Average_Price { get; set; }
        public DbSet<Products_by_Category> Products_by_Category { get; set; }
        public DbSet<Sales_by_Category> Sales_by_Category { get; set; }
        public DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amount { get; set; }
        public DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarter { get; set; }
        public DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Year { get; set; }
    
        public virtual ObjectResult<CustOrdersOrders_Result> CustOrdersOrders(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrdersOrders_Result>("CustOrdersOrders", customerIDParameter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Entities : DbContext 
{ 
    public DbSet<Account> Accounts { get; set; } 
    public DbSet<Person> Persons { get; set; } 
    public DbSet<Address> Addresses { get; set; } 
    public DbSet<Service> Services { get; set; } 
    public DbSet<Category> Categories { get; set; } 
    public DbSet<Order> Orders { get; set; } 
    public DbSet<OrDetail> OrderDetails { get; set; } 
}

public class Account
{
	public string Username { get; set; }
	public string Password { get; set; }
	public string Category { get; set; }
}

public class Person
{
	public int PersonId { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	public Adress Adress { get; set; }
	public int PhoneNumber { get; set; }
	public string Email { get; set; }
	public int Points { get; set; }
	
}

public class Address
{
	public int AddressId { get; set; }
	public string Street { get; set; }
	public string Colony { get; set; }
	public int ZipCode { get; set; }
}

public class Service
{
    public int ServiceId { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public Category Category { get; set; }
}

public class Category
{
    public string CategoryId { get; set; }
}

public class Order
{
	public string OrderId { get; set; }
	public string Total { get; set; }
	public Date CreatedDate { get; set; }
	public Date DeliverDate { get; set; }
	public Person Person { get; set; }
	public int IsDelivered { get; set; }
}

public class OrderDetail
{
	public string OrderDetailId { get; set; }
	public Order Order { get; set; }
	public Service Service { get; set; }
	public int Quantity { get; set; }
	public int Total { get; set; }
	public int IsDelivered { get; set; }
}


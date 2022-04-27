
using HRApp.Models;
using Microsoft.EntityFrameworkCore;

public class HrDbContext : DbContext{

public HrDbContext(DbContextOptions<HrDbContext> options): base(options)
{}
public DbSet<Department> Departments {get;set;}
public DbSet<Designation> Designations{get;set;}
public DbSet<Employee> Employees{get;set;}

}
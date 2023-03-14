// C# week 5 lesson 22
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext 
  // ToDoListContext class inherits (or "extends") from EF Core's DbContext class. This ensures it includes all default built-in DbContext functionality.
  // this is where we 'define' the database we will be working with. It will be called on at the top of the controllers.
  {
    public DbSet<Category> Categories { get; set; } // think of 'DbSet' like it's a list. It represents a table in our database.
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags {get; set;}
    public DbSet<ItemTag> ItemTags { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
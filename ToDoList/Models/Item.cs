using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; } // each Item gets an Id. It is the PRIMARY KEY, and is auto-incrementing. This field is set up in sql.
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; } // this field is set by the user in the UI
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public int CategoryId { get; set; } // Since each Item must belong to a category, it must hold an Id for the the category it belongs to.
    public Category Category { get; set; } // this is where the Category Object that the Item belongs to is held. It is set in the UI.
    public List<ItemTag> JoinEntities { get;}
  }
}


/* With EF Core, we no longer need to write verbose custom methods to query a database, like Find() and Save(). 
Instead, we use simple built-in methods, which we'll call from the controller. */
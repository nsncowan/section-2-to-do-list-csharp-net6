using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;


namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; } // each Item gets an Id. It is the PRIMARY KEY, and is auto-incrementing. This field is set up in sql.
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; } // this field is set by the user in the UI
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public int CategoryId { get; set; } // Since each Item must belong to a category, it must hold an Id for the the category it belongs to.
    public string DueDate { get; set; }
    public Category Category { get; set; } // this is where the Category Object that the Item belongs to is held. It is set in the UI.
    public List<ItemTag> JoinEntities { get;}

    public void FormatDate()
    {
      string inputString = this.DueDate;
      string[] dateElements = inputString.Split('-');
      // string outputString = dateElements[1] + "/" + dateElements[2] + "/" + dateElements[0];
      DateTime date1 = new DateTime(Int32.Parse(dateElements[0]), Int32.Parse(dateElements[1]), Int32.Parse(dateElements[2]));
      string outputString = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
      this.DueDate = outputString;
    } 

  }
}


/* With EF Core, we no longer need to write verbose custom methods to query a database, like Find() and Save(). 
Instead, we use simple built-in methods, which we'll call from the controller. */


/* 
using System.Globalization;

public void FormatDate()
    {
      string inputString = this.DueDate;
      string[] dateElements = inputString.Split('-');
      // string outputString = dateElements[1] + "/" + dateElements[2] + "/" + dateElements[0];
      DateTime date1 = new DateTime(Int32.Parse(dateElements[0]), Int32.Parse(dateElements[1]), Int32.Parse(dateElements[2]));
      string outputString = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
      this.DueDate = outputString;
    } 
*/
using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // each category gets an id. it is set as the PRIMARY KEY in sql. It is also set to auto-increment. 
        public string Name { get; set; } // this is set by the user in the UI
        public List<Item> Items { get; set; } // each category is populated by Items. Those Item objects are kept in a list, as defined here. 
    }
}
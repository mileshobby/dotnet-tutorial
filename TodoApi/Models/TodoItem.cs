using System;
namespace TodoApi.Models
{
    public class TodoItem
    {
	    //basically setter and getter methods on the id class
	    public long Id { get; set; }
	    public string Name { get; set; }
	    public bool IsComplete { get; set; }

    }
}

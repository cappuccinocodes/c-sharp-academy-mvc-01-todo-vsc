using System.Collections.Generic;

namespace Todo.Models.ViewModels
{
    public class TodoViewModel
    {
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}
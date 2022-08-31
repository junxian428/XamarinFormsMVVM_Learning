using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{

    public class Todo
    {
        public string TodoText { get; set ; }
        public bool Completed { get; set; }
        public Todo(String TodoText, bool Completed)
        {
            this.TodoText = TodoText;
            this.Completed = Completed;

        }
    }
}

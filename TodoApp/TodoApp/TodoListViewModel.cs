using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace TodoApp
{
    public class TodoListViewModel
    {
        public ObservableCollection<Todo> Todo { get; set; }

        public TodoListViewModel()
        {
            Todo = new ObservableCollection<Todo>();

            Todo.Add(new Todo("Todo 1",false));
            Todo.Add(new Todo("Todo 2", false));
            Todo.Add(new Todo("Todo 3", true));
            Todo.Add(new Todo("Todo 4", false));

        }
        public ICommand AddTodoCommand => new Command(AddTodoItem);

        public string NewTodoInputValue{ get; set;}

        void AddTodoItem()
        {
            Console.WriteLine("AddTodo Item is running");
            Todo.Add(new Todo(NewTodoInputValue,false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);

        void RemoveTodoItem(object o)
        {
            Todo todoItemBeingRemoved = o as Todo;
            Console.WriteLine(todoItemBeingRemoved.TodoText);
            Todo.Remove(todoItemBeingRemoved);
        }

    }
}

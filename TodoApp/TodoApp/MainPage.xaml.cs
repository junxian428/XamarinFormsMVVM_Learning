using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("hi");
            Label label = new Label();
            Console.WriteLine(Input.Text);
            label.Text = Input.Text;
            label.FontSize = 20;
            Todolist.Children.Add(label);
            Input.Text = "";

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine(e.NewTextValue);
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
           Console.WriteLine("Completed!");
            Label label = new Label();
            Console.WriteLine(Input.Text);
            label.Text = Input.Text;
            label.FontSize = 20;
            Todolist.Children.Add(label);
            Input.Text = "";

        }

     
    }
}

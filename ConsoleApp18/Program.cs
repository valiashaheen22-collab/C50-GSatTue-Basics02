#region Question 1
//Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in avariable of type object. Print it
using System;

namespace ConsoleApp16
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object book = new Book();
            Console.WriteLine(book);
        }
    }
}


#endregion
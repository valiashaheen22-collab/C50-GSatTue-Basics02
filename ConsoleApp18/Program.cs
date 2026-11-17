#region Question 1
//Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in avariable of type object. Print it
////using System;

////namespace ConsoleApp16
////{
////    class Book
////    {
////        public string Title { get; set; }
////        public int Pages { get; set; }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            object book = new Book();
////            Console.WriteLine(book);
////        }
////    }
////}


#endregion
#region Question 2
//Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book withitself), GetHashCode(), and GetType() on book.using System;

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

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
        }
    }

#endregion
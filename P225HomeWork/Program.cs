using P225HomeWork.Enums;
using P225HomeWork.Models;
using P225HomeWork.Services;
using System;

namespace P225HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("CSharp", "Andres Helsberg", 500, Genre.ScienceFiction);
            Book book2 = new Book("Type Script", "Andres Helsberg", 100, Genre.ScienceFiction);
            Book book3 = new Book("Xemse", "Nizami Gencevi", 300, Genre.Drama);
            Book book4 = new Book("Sefiller", "Viktor Hugo", 250, Genre.Detective);
            Book book5 = new Book("Baxaqda", "Viktor Hugo", 250, Genre.Detective);
            Book book6 = new Book("Adinida Deyisinde", "Viktor Hugo", 250, Genre.ScienceFiction);
            Book book7 = new Book("Cinayet Ve Ceza", "Dostayevski", 150, Genre.Detective);

            LibraryManager libraryManager = new LibraryManager();

            libraryManager.Add(book1);
            libraryManager.Add(book2);
            libraryManager.Add(book3);
            libraryManager.Add(book4);
            libraryManager.Add(book5);
            libraryManager.Add(book6);
            libraryManager.Add(book7);

            //Console.WriteLine(libraryManager.ShowInfo("Xemse"));


            //foreach (Book book in libraryManager.Filter("Viktor Hugo",Genre.Detective))
            //{
            //    Console.WriteLine(book);
            //}


            foreach (Book book in libraryManager.Search("r"))
            {
                Console.WriteLine(book);
            }
        }
    }
}
using P225HomeWork.Enums;
using P225HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(string author, Genre genre);
    }
}

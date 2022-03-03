using P225HomeWork.Enums;
using P225HomeWork.Exceptions;
using P225HomeWork.Interfaces;
using P225HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(b => b.Name == book.Name))
                throw new SameBookalreadyAddedExpection($"{book.Name} adli Kitab Artiq Movcuddur");

            _books.Add(book);

        }

        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(b => b.Author == author || b.Genre == genre);
        }

        public List<Book> Search(string search)
        {
            return _books.FindAll(b => b.Author.Contains(search) || 
            b.Genre.ToString().Contains(search) ||
            b.PageCount.ToString().Contains(search) || b.Name.Contains(search));
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name == name);

            if (book != null)
            {
                return book;
            }

            throw new BookNotFoundException($"{name} adli kitab tapilmadi");
        }
    }
}

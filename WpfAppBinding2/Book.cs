﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBinding2
{
    public class BookRepository
    {
        // BindingList
        private ObservableCollection<Book> books;
        public BookRepository()
        {
            books = new ObservableCollection<Book>();

            // template data
            books.Add(new Book() { BookId = 1, Name = "Book 1", Author = "Author 1", YearOfIssue = 2000, DateOf = DateTime.Now });
            books.Add(new Book() { BookId = 2, Name = "Book 2", Author = "Author 2", YearOfIssue = 2000, DateOf = DateTime.Now });
            books.Add(new Book() { BookId = 3, Name = "Book 3", Author = "Author 3", YearOfIssue = 2000, DateOf = DateTime.Now });
            books.Add(new Book() { BookId = 4, Name = "Book 4", Author = "Author 4", YearOfIssue = 2000, DateOf = DateTime.Now });
            books.Add(new Book() { BookId = 5, Name = "Book 5", Author = "Author 5", YearOfIssue = 2000, DateOf = DateTime.Now });
        }

        public ObservableCollection<Book> GetBooks() => books;
    }

    public class Book: INotifyPropertyChanged
    {
        private int bookId;
        private string name;
        private short yearOfIssue;
        private string author;
        private DateTime dateOf;
        public int BookId {
            get => bookId;
            set { SetProperty(ref bookId, value, nameof(BookId)); }
        }
        public string Name {
            get => name;
            set { SetProperty(ref name, value, nameof(Name)); }
        }
        public short YearOfIssue
        {
            get => yearOfIssue;
            set { SetProperty(ref yearOfIssue, value, nameof(YearOfIssue)); }
        }
        public string Author
        {
            get => author;
            set { SetProperty(ref author, value, nameof(Author)); }
        }
        public DateTime DateOf
        {
            get => dateOf;
            set { SetProperty(ref dateOf, value, nameof(DateOf)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(ref T field, T value, string name)
        {
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public override string ToString()
        {
            return $"{Name} ({YearOfIssue}), {Author}[{BookId}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Book
    {   
        // class variable declaration
        private string title;
        private string author;
        private int publishYear;

        // constructor
        public Book(string title, string author, int publishYear)
        {
            Title = title;
            Author = author;
            PublishYear = publishYear;
        }

        // getters and setters for all class variables - NEW SYNTAX
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PublishYear
        {
            get { return publishYear; }
            set { publishYear = value; }
        }
    }
}
